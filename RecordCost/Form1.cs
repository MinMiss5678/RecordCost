using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ZXing.QrCode;
using ZXing;
using ZXing.Common;
using ZXing.Rendering;
using System.Diagnostics;

namespace RecordCost
{
    public partial class Form1 : Form
    {
        SqlConnectionStringBuilder scsb;
        string myCostConnectionString = "";
        SqlConnection connect;
        public Form1()
        {
            InitializeComponent();
            this.pictureBox1.Image = Image.FromFile(@"C:\Users\jerem\Downloads\qrcode_dotblogs.com.tw.png");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "myCost";
            scsb.IntegratedSecurity = true;
            myCostConnectionString = scsb.ToString();

            connect = new SqlConnection(myCostConnectionString);
            connect.Open();
            dataInDataGridView();
        }

        private string imagePath = "";


        private Bitmap GetQRCodeByZXingNet(String strMessage, Int32 width, Int32 height)
        {
            Bitmap result = null;
            try
            {
                BarcodeWriter barCodeWriter = new BarcodeWriter();
                barCodeWriter.Format = BarcodeFormat.QR_CODE; //barcode格式
                barCodeWriter.Options.Hints.Add(EncodeHintType.CHARACTER_SET, "UTF-8");  //編碼字元utf-8
                barCodeWriter.Options.Hints.Add(EncodeHintType.ERROR_CORRECTION, ZXing.QrCode.Internal.ErrorCorrectionLevel.H); //錯誤校正等級
                barCodeWriter.Options.Height = height; //高度
                barCodeWriter.Options.Width = width; //寬度
                barCodeWriter.Options.Margin = 0; //外邊距
                ZXing.Common.BitMatrix bm = barCodeWriter.Encode(strMessage); //將訊息寫入
                result = barCodeWriter.Write(bm);

                Bitmap overlay = new Bitmap(imagePath); //載入圖片

                int deltaHeigth = result.Height - overlay.Height; //圖片y
                int deltaWidth = result.Width - overlay.Width; //圖片x

                Graphics g = Graphics.FromImage(result); //圖型
                g.DrawImage(overlay, new Point(deltaWidth / 2, deltaHeigth / 2)); //畫出圖片
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return result;


        }



        /// <summary>
        /// 生成二維碼圖片
        /// </summary>
        /// <param name="strMessage">要生成二維碼的字元串</param>
        /// <param name="width">二維碼圖片寬度</param>
        /// <param name="height">二維碼圖片高度</param>
        /// <returns></returns>

        private string DecodeQrCode(Bitmap barcodeBitmap)
        {
            BarcodeReader reader = new BarcodeReader();
            reader.Options.CharacterSet = "UTF-8";
            var result = reader.Decode(barcodeBitmap);
            return (result == null) ? null : result.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.label1.Text = DecodeQrCode((Bitmap)this.pictureBox1.Image);
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            if (numberTextBox.Text != "" || itemsTextBox.Text != "")
            {
                int count;
                int price;
                int.TryParse(countTextBox.Text, out count);
                int.TryParse(priceTextBox.Text, out price);

                connect = new SqlConnection(myCostConnectionString);
                connect.Open();
                string newSQL = "insert into Cost values (@newDate, @newNumber, @newItems, @newCount, @newPrice);";
                SqlCommand command = new SqlCommand(newSQL, connect);
                command.Parameters.AddWithValue("@newDate", costDateTimePicker.Value);
                command.Parameters.AddWithValue("@newNumber", numberTextBox.Text);
                command.Parameters.AddWithValue("@newItems", itemsTextBox.Text);
                command.Parameters.AddWithValue("@newCount", countTextBox.Text);
                command.Parameters.AddWithValue("@newPrice", priceTextBox.Text);

                int rows = command.ExecuteNonQuery();
                dataInDataGridView();
                connect.Close();

                MessageBox.Show($"{rows}筆資料新增成功");
            }

            else
            {
                MessageBox.Show("請輸入發票號碼或品項");
            }
        }

        private void dataInDataGridView()
        {
            string dataSQL = "select * from Cost order by costDate;";
            SqlCommand command = new SqlCommand(dataSQL, connect);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
            }

            reader.Close();

            idTextBox.Text = "";
            costDateTimePicker.Value = DateTime.Now.Date;
            numberTextBox.Text = "";
            itemsTextBox.Text = "";
            countTextBox.Text = "";
            priceTextBox.Text = "";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(idTextBox.Text, out id);

            if (id > 0)
            {
                connect = new SqlConnection(myCostConnectionString);
                connect.Open();
                string strSQL = "delete from Cost where id = @searchID;";
                SqlCommand cmd = new SqlCommand(strSQL, connect);
                cmd.Parameters.AddWithValue("@searchID", id);

                int rows = cmd.ExecuteNonQuery();

                dataInDataGridView();
                connect.Close();
                MessageBox.Show($"{rows}筆資料刪除成功");
            }


            //costBindingSource.AddNew();
            //costDateTimePicker.Value = DateTime.Now.Date;
            //costBindingSource.EndEdit();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchItems = searchTextBox.Text;

            if (searchItems != "")
            {
                connect = new SqlConnection(myCostConnectionString);
                connect.Open();
                string searchSQL = "select * from Cost where (items like @searchitems ) and (costDate between @startDate and @endDate);";
                SqlCommand command = new SqlCommand(searchSQL, connect);
                command.Parameters.AddWithValue("@searchitems", $"%{searchItems}%");
                command.Parameters.AddWithValue("@startDate", startDateTimePicker.Value.Date);
                command.Parameters.AddWithValue("@endDate", endDateTimePicker.Value.Date);

                SqlDataReader reader = command.ExecuteReader();

                int total = 0;

                while (reader.Read())
                {
                    total += Convert.ToInt32(reader["price"]);
                }

                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;
                }

                totalLabel.Text = $"總花費：{total}";

                reader.Close();
                connect.Close();
            }

            else
            {
                connect = new SqlConnection(myCostConnectionString);
                connect.Open();
                string searchSQL = "select * from Cost where costDate between @startDate and @endDate;";
                SqlCommand command = new SqlCommand(searchSQL, connect);
                command.Parameters.AddWithValue("@startDate", startDateTimePicker.Value.Date);
                command.Parameters.AddWithValue("@endDate", endDateTimePicker.Value.Date);
            }
        }

        private void reviseButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(idTextBox.Text, out id);

            if (id > 0)
            {
                if (numberTextBox.Text != "" || itemsTextBox.Text != "")
                {
                    connect = new SqlConnection(myCostConnectionString);
                    connect.Open();
                    string updateSQL = "update Cost set costDate = @newDate, number = @newNumber, items = @newItems, " +
                        "count = @newCount, price = @newPrice where id = @searchID;";

                    SqlCommand command = new SqlCommand(updateSQL, connect);
                    command.Parameters.AddWithValue("@searchID", id);
                    command.Parameters.AddWithValue("@newDate", costDateTimePicker.Value);
                    command.Parameters.AddWithValue("@newNumber", numberTextBox.Text);
                    command.Parameters.AddWithValue("@newItems", itemsTextBox.Text);
                    command.Parameters.AddWithValue("@newCount", countTextBox.Text);
                    command.Parameters.AddWithValue("@newPrice", priceTextBox.Text);

                    int rows = command.ExecuteNonQuery();
                    dataInDataGridView();
                    connect.Close();
                    MessageBox.Show($"{rows}筆資料修改成功");
                }

                else
                {
                    MessageBox.Show("請輸入發票號碼或品項");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            string strselectID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            int intSelectID = Convert.ToInt32(strselectID);

            connect = new SqlConnection(myCostConnectionString);
            connect.Open();
            string strSQL = "select * from Cost where id = @searchID";
            SqlCommand cmd = new SqlCommand(strSQL, connect);
            cmd.Parameters.AddWithValue("@searchID", intSelectID);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                idTextBox.Text = $"{reader["id"]}";
                costDateTimePicker.Value = Convert.ToDateTime(reader["costDate"]);
                numberTextBox.Text = $"{reader["number"]}";
                itemsTextBox.Text = $"{reader["items"]}";
                countTextBox.Text = $"{reader["count"]}";
                priceTextBox.Text = $"{reader["price"]}";
            }

            reader.Close();
            connect.Close();
        }

        private void LotteryButton_Click(object sender, EventArgs e)
        {
            if (lotteryRichTextBox.Text != "")
            {
                string[] slice = new string[lotteryRichTextBox.Lines.Length];

                for (int index = 0; index < lotteryRichTextBox.Lines.Length; index++)
                {
                    if (lotteryRichTextBox.Lines[index].Length < 8)
                    {
                        slice[index] = lotteryRichTextBox.Lines[index].PadLeft(8, '*').Substring(5);
                        slice[index] = $"number like '%{slice[index]}'";
                        continue;
                    }

                    slice[index] = lotteryRichTextBox.Lines[index].Substring(5);
                    slice[index] = $"number like '%{slice[index]}'";
                }

                string number = string.Join(" or ", slice);

                connect = new SqlConnection(myCostConnectionString);
                connect.Open();
                string searchSQL = "select * from Cost where (@searchNumber) and (costDate between @startDate and @endDate);";
                SqlCommand command = new SqlCommand(searchSQL, connect);
                command.Parameters.AddWithValue("@searchNumber", number);
                command.Parameters.AddWithValue("@startDate", startDateTimePicker.Value.Date);
                command.Parameters.AddWithValue("@endDate", endDateTimePicker.Value.Date);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;
                }

                reader.Close();
                connect.Close();
            }
        }
    }
}
