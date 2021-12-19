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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();//建立資料庫連線
            scsb.DataSource = @".";
            scsb.InitialCatalog = "myCost";
            scsb.IntegratedSecurity = true;
            myCostConnectionString = scsb.ToString();
            connect = new SqlConnection(myCostConnectionString);
            connect.Open();
            dataInDataGridView();
            connect.Close();

            costDateTimePicker.Value = DateTime.Now;

            if (DateTime.Now.Month % 2 == 0)//設定中獎號碼的標籤
            {
                thisLotteryLabel.Text = $"{DateTime.Now.AddMonths(-3).Month}-{DateTime.Now.AddMonths(-2).Month}";
                lastLotteryLabel.Text = $"{DateTime.Now.AddMonths(-5).Month}-{DateTime.Now.AddMonths(-4).Month}";
            }

            else
            {
                thisLotteryLabel.Text = $"{DateTime.Now.AddMonths(-2).Month}-{DateTime.Now.AddMonths(-1).Month}";
                lastLotteryLabel.Text = $"{DateTime.Now.AddMonths(-4).Month}-{DateTime.Now.AddMonths(-3).Month}";
            }
        }

        private void EmptyButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = "";
            numberTextBox.Text = "";
            itemsTextBox.Text = "";
            countTextBox.Text = "";
            priceTextBox.Text = "";
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            if (numberTextBox.Text != "" || itemsTextBox.Text != "")
            {
                connect = new SqlConnection(myCostConnectionString);
                connect.Open();
                string newSQL = "insert into Cost output inserted.id values (@newDate, @newNumber, @newItems, @newCount, @newPrice);";
                SqlCommand command = new SqlCommand(newSQL, connect);
                command.Parameters.AddWithValue("@newDate", costDateTimePicker.Value);
                command.Parameters.AddWithValue("@newNumber", numberTextBox.Text);
                command.Parameters.AddWithValue("@newItems", itemsTextBox.Text);
                command.Parameters.AddWithValue("@newCount", countTextBox.Text);
                command.Parameters.AddWithValue("@newPrice", priceTextBox.Text);

                string id = command.ExecuteScalar().ToString();

                dataInDataGridView();
                connect.Close();

                JumpRowFromID(id);
            }

            else
            {
                MessageBox.Show("請輸入發票號碼或品項");
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
                    JumpRowFromID(id.ToString());
                    MessageBox.Show($"{rows}筆資料修改成功");
                }

                else
                {
                    MessageBox.Show("請輸入發票號碼或品項");
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(idTextBox.Text, out id);

            if (id > 0)
            {
                connect = new SqlConnection(myCostConnectionString);
                connect.Open();
                string delSQL = "delete from Cost where id = @searchID;";
                SqlCommand command = new SqlCommand(delSQL, connect);
                command.Parameters.AddWithValue("@searchID", id);

                int rows = command.ExecuteNonQuery();

                dataInDataGridView();
                connect.Close();
                MessageBox.Show($"{rows}筆資料刪除成功");
            }
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
                command.Parameters.AddWithValue("@startDate", startDateTimePicker.Value.ToShortDateString());
                command.Parameters.AddWithValue("@endDate", endDateTimePicker.Value.ToShortDateString());

                TotalCost(command.ExecuteReader());
                connect.Close();
            }

            else
            {
                connect = new SqlConnection(myCostConnectionString);
                connect.Open();
                string searchSQL = $"select * from Cost where costDate between @startDate and @endDate;";
                SqlCommand command = new SqlCommand(searchSQL, connect);
                command.Parameters.AddWithValue("@startDate", startDateTimePicker.Value.ToShortDateString());
                command.Parameters.AddWithValue("@endDate", endDateTimePicker.Value.ToShortDateString());

                TotalCost(command.ExecuteReader());
                connect.Close();
            }
        }

        private void ThisMonthButton_Click(object sender, EventArgs e)
        {
            string searchItems = searchTextBox.Text;

            if (searchItems != "")
            {
                connect = new SqlConnection(myCostConnectionString);
                connect.Open();
                string searchSQL = "select * from Cost where (items like @searchitems ) and (costDate like @monthDate);";
                SqlCommand command = new SqlCommand(searchSQL, connect);
                command.Parameters.AddWithValue("@searchitems", $"%{searchItems}%");
                command.Parameters.AddWithValue("@monthDate", $"{DateTime.Now.ToString("yyyy-MM")}%");

                TotalCost(command.ExecuteReader());
                connect.Close();
            }

            else
            {
                connect = new SqlConnection(myCostConnectionString);
                connect.Open();
                string searchSQL = $"select * from Cost where costDate like @monthDate order by costDate;";
                SqlCommand command = new SqlCommand(searchSQL, connect);
                command.Parameters.AddWithValue("@monthDate", $"{DateTime.Now.ToString("yyyy-MM")}%");

                TotalCost(command.ExecuteReader());
                connect.Close();
            }
        }

        private void ThisLotteryButton_Click(object sender, EventArgs e)
        {
            if (lotteryRichTextBox.Text != "")
            {
                string[] slice = new string[lotteryRichTextBox.Lines.Length];

                for (int index = 0; index < lotteryRichTextBox.Lines.Length; index++)//擷取後3碼
                {
                    if (lotteryRichTextBox.Lines[index].Length >= 3 && lotteryRichTextBox.Lines[index].Length <= 8)
                    {
                        slice[index] = lotteryRichTextBox.Lines[index].PadLeft(8, '*').Substring(5);
                        slice[index] = $"number like '%{slice[index]}'";
                        continue;
                    }

                    else
                    {
                        MessageBox.Show("輸入錯誤");
                        return;
                    }
                }

                string number = string.Join(" or ", slice);

                connect = new SqlConnection(myCostConnectionString);
                connect.Open();
                string searchSQL = "select * from Cost where (" + number + ") and (costDate like @startDate or costDate like @endDate) " +
                                   "order by costDate;";
                SqlCommand command = new SqlCommand(searchSQL, connect);

                if (DateTime.Now.Month % 2 == 0)//設定月份
                {
                    command.Parameters.AddWithValue("@startDate", $"{DateTime.Now.AddMonths(-3).ToString("yyyy-MM")}%");
                    command.Parameters.AddWithValue("@endDate", $"{DateTime.Now.AddMonths(-2).ToString("yyyy-MM")}%");
                }

                else
                {
                    command.Parameters.AddWithValue("@startDate", $"{DateTime.Now.AddMonths(-2).ToString("yyyy-MM")}%");
                    command.Parameters.AddWithValue("@endDate", $"{DateTime.Now.AddMonths(-1).ToString("yyyy-MM")}%");
                }

                TotalCost(command.ExecuteReader());
                connect.Close();
            }
        }

        private void LastLotteryButton_Click(object sender, EventArgs e)
        {
            if (lotteryRichTextBox.Text != "")
            {
                string[] slice = new string[lotteryRichTextBox.Lines.Length];

                for (int index = 0; index < lotteryRichTextBox.Lines.Length; index++)//擷取後3碼
                {
                    if (lotteryRichTextBox.Lines[index].Length >= 3 && lotteryRichTextBox.Lines[index].Length <= 8)
                    {
                        slice[index] = lotteryRichTextBox.Lines[index].PadLeft(8, '*').Substring(5);
                        slice[index] = $"number like '%{slice[index]}'";
                        continue;
                    }

                    else
                    {
                        MessageBox.Show("輸入錯誤");
                        return;
                    }
                }

                string number = string.Join(" or ", slice);

                connect = new SqlConnection(myCostConnectionString);
                connect.Open();
                string searchSQL = "select * from Cost where (" + number + ") and (costDate like @startDate or costDate like @endDate) " +
                    "order by costDate;";
                SqlCommand command = new SqlCommand(searchSQL, connect);

                if (DateTime.Now.Month % 2 == 0)//設定月份
                {
                    command.Parameters.AddWithValue("@startDate", $"{DateTime.Now.AddMonths(-5).ToString("yyyy-MM")}%");
                    command.Parameters.AddWithValue("@endDate", $"{DateTime.Now.AddMonths(-4).ToString("yyyy-MM")}%");
                }

                else
                {
                    command.Parameters.AddWithValue("@startDate", $"{DateTime.Now.AddMonths(-4).ToString("yyyy-MM")}%");
                    command.Parameters.AddWithValue("@endDate", $"{DateTime.Now.AddMonths(-3).ToString("yyyy-MM")}%");
                }

                TotalCost(command.ExecuteReader());
                connect.Close();
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
            numberTextBox.Text = "";
            itemsTextBox.Text = "";
            countTextBox.Text = "";
            priceTextBox.Text = "";
        }

        private void JumpRowFromID(string id)
        {
            System.Collections.IList list = (System.Collections.IList)dataGridView1.Rows;//每一筆資料放進list
            for (int i = 0; i < list.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)list[i];
                if (row.Cells[0].Value.ToString() == id)//找到符合序號的索引，給予焦點
                {
                    row.Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                    dataGridView1.Focus();
                    dataGridView1_RowEnter(this, new DataGridViewCellEventArgs(0, i));
                    break;
                }
            }
        }

        private void TotalCost(SqlDataReader reader)
        {
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;

                int total = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)//合計每筆資料的費用
                {
                    total += (int?)dataGridView1.Rows[i].Cells[5]?.Value ?? 0;
                }

                totalLabel.Text = $"總花費：{total}";
            }

            else
            {
                MessageBox.Show("查無資料");
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var temp = dataGridView1.Rows[e.RowIndex].Cells;//觸發事件的那筆資料
            idTextBox.Text = $"{temp[0].Value}";
            costDateTimePicker.Value = Convert.ToDateTime(temp[1].Value);
            numberTextBox.Text = $"{temp[2].Value}";
            itemsTextBox.Text = $"{temp[3].Value}";
            countTextBox.Text = $"{temp[4].Value}";
            priceTextBox.Text = $"{temp[5].Value}";
        }
    }
}