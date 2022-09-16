
namespace RecordCost
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.costDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.itemsTextBox = new System.Windows.Forms.TextBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.EmptyButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.costBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SearchButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.reviseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.lotteryRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ThisMonthButton = new System.Windows.Forms.Button();
            this.ThisLotteryButton = new System.Windows.Forms.Button();
            this.LastLotteryButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lastLotteryLabel = new System.Windows.Forms.Label();
            this.thisLotteryLabel = new System.Windows.Forms.Label();
            this.NewButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.costBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // costDateTimePicker
            // 
            this.costDateTimePicker.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.costDateTimePicker.Location = new System.Drawing.Point(149, 94);
            this.costDateTimePicker.Name = "costDateTimePicker";
            this.costDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.costDateTimePicker.TabIndex = 3;
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NumberLabel.Location = new System.Drawing.Point(12, 154);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(120, 27);
            this.NumberLabel.TabIndex = 4;
            this.NumberLabel.Text = "發票號碼";
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ItemsLabel.Location = new System.Drawing.Point(37, 222);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(66, 27);
            this.ItemsLabel.TabIndex = 5;
            this.ItemsLabel.Text = "品項";
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CountLabel.Location = new System.Drawing.Point(37, 287);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(66, 27);
            this.CountLabel.TabIndex = 6;
            this.CountLabel.Text = "數量";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PriceLabel.Location = new System.Drawing.Point(37, 353);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(66, 27);
            this.PriceLabel.TabIndex = 7;
            this.PriceLabel.Text = "價格";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numberTextBox.Location = new System.Drawing.Point(149, 151);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(173, 40);
            this.numberTextBox.TabIndex = 8;
            // 
            // itemsTextBox
            // 
            this.itemsTextBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.itemsTextBox.Location = new System.Drawing.Point(149, 219);
            this.itemsTextBox.Name = "itemsTextBox";
            this.itemsTextBox.Size = new System.Drawing.Size(458, 40);
            this.itemsTextBox.TabIndex = 9;
            // 
            // countTextBox
            // 
            this.countTextBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.countTextBox.Location = new System.Drawing.Point(149, 284);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(173, 40);
            this.countTextBox.TabIndex = 10;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.priceTextBox.Location = new System.Drawing.Point(149, 350);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(173, 40);
            this.priceTextBox.TabIndex = 11;
            // 
            // EmptyButton
            // 
            this.EmptyButton.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EmptyButton.Location = new System.Drawing.Point(42, 449);
            this.EmptyButton.Name = "EmptyButton";
            this.EmptyButton.Size = new System.Drawing.Size(130, 39);
            this.EmptyButton.TabIndex = 12;
            this.EmptyButton.Text = "清空欄位";
            this.EmptyButton.UseVisualStyleBackColor = true;
            this.EmptyButton.Click += new System.EventHandler(this.EmptyButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DeleteButton.Location = new System.Drawing.Point(373, 449);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(216, 39);
            this.DeleteButton.TabIndex = 13;
            this.DeleteButton.Text = "刪除資料";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startDateTimePicker.Location = new System.Drawing.Point(677, 315);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.startDateTimePicker.TabIndex = 14;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SearchButton.Location = new System.Drawing.Point(677, 353);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(130, 39);
            this.SearchButton.TabIndex = 15;
            this.SearchButton.Text = "查詢資料";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateLabel.Location = new System.Drawing.Point(37, 92);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(66, 27);
            this.dateLabel.TabIndex = 16;
            this.dateLabel.Text = "日期";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(624, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(643, 237);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.endDateTimePicker.Location = new System.Drawing.Point(942, 315);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.endDateTimePicker.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(896, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 27);
            this.label2.TabIndex = 19;
            this.label2.Text = "~";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.searchTextBox.Location = new System.Drawing.Point(790, 255);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(320, 40);
            this.searchTextBox.TabIndex = 20;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.searchLabel.Location = new System.Drawing.Point(672, 258);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(93, 27);
            this.searchLabel.TabIndex = 21;
            this.searchLabel.Text = "關鍵字";
            // 
            // reviseButton
            // 
            this.reviseButton.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.reviseButton.Location = new System.Drawing.Point(207, 449);
            this.reviseButton.Name = "reviseButton";
            this.reviseButton.Size = new System.Drawing.Size(130, 39);
            this.reviseButton.TabIndex = 22;
            this.reviseButton.Text = "修改資料";
            this.reviseButton.UseVisualStyleBackColor = true;
            this.reviseButton.Click += new System.EventHandler(this.reviseButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(37, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 27);
            this.label3.TabIndex = 23;
            this.label3.Text = "序號";
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.idTextBox.Location = new System.Drawing.Point(149, 25);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(173, 40);
            this.idTextBox.TabIndex = 24;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.totalLabel.Location = new System.Drawing.Point(937, 359);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(120, 27);
            this.totalLabel.TabIndex = 25;
            this.totalLabel.Text = "總花費：";
            // 
            // lotteryRichTextBox
            // 
            this.lotteryRichTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lotteryRichTextBox.Location = new System.Drawing.Point(942, 449);
            this.lotteryRichTextBox.Name = "lotteryRichTextBox";
            this.lotteryRichTextBox.Size = new System.Drawing.Size(126, 118);
            this.lotteryRichTextBox.TabIndex = 26;
            this.lotteryRichTextBox.Text = "";
            // 
            // ThisMonthButton
            // 
            this.ThisMonthButton.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ThisMonthButton.Location = new System.Drawing.Point(677, 408);
            this.ThisMonthButton.Name = "ThisMonthButton";
            this.ThisMonthButton.Size = new System.Drawing.Size(130, 39);
            this.ThisMonthButton.TabIndex = 28;
            this.ThisMonthButton.Text = "本月資料";
            this.ThisMonthButton.UseVisualStyleBackColor = true;
            this.ThisMonthButton.Click += new System.EventHandler(this.ThisMonthButton_Click);
            // 
            // ThisLotteryButton
            // 
            this.ThisLotteryButton.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ThisLotteryButton.Location = new System.Drawing.Point(106, 61);
            this.ThisLotteryButton.Name = "ThisLotteryButton";
            this.ThisLotteryButton.Size = new System.Drawing.Size(88, 39);
            this.ThisLotteryButton.TabIndex = 29;
            this.ThisLotteryButton.Text = "這期";
            this.ThisLotteryButton.UseVisualStyleBackColor = true;
            this.ThisLotteryButton.Click += new System.EventHandler(this.ThisLotteryButton_Click);
            // 
            // LastLotteryButton
            // 
            this.LastLotteryButton.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LastLotteryButton.Location = new System.Drawing.Point(6, 61);
            this.LastLotteryButton.Name = "LastLotteryButton";
            this.LastLotteryButton.Size = new System.Drawing.Size(88, 39);
            this.LastLotteryButton.TabIndex = 30;
            this.LastLotteryButton.Text = "上期";
            this.LastLotteryButton.UseVisualStyleBackColor = true;
            this.LastLotteryButton.Click += new System.EventHandler(this.LastLotteryButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lastLotteryLabel);
            this.groupBox1.Controls.Add(this.thisLotteryLabel);
            this.groupBox1.Controls.Add(this.ThisLotteryButton);
            this.groupBox1.Controls.Add(this.LastLotteryButton);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(677, 458);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 113);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查詢中獎號碼";
            // 
            // lastLotteryLabel
            // 
            this.lastLotteryLabel.AutoSize = true;
            this.lastLotteryLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lastLotteryLabel.Location = new System.Drawing.Point(35, 36);
            this.lastLotteryLabel.Name = "lastLotteryLabel";
            this.lastLotteryLabel.Size = new System.Drawing.Size(29, 16);
            this.lastLotteryLabel.TabIndex = 33;
            this.lastLotteryLabel.Text = "last";
            // 
            // thisLotteryLabel
            // 
            this.thisLotteryLabel.AutoSize = true;
            this.thisLotteryLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.thisLotteryLabel.Location = new System.Drawing.Point(134, 36);
            this.thisLotteryLabel.Name = "thisLotteryLabel";
            this.thisLotteryLabel.Size = new System.Drawing.Size(30, 16);
            this.thisLotteryLabel.TabIndex = 32;
            this.thisLotteryLabel.Text = "this";
            // 
            // NewButton
            // 
            this.NewButton.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NewButton.Location = new System.Drawing.Point(42, 509);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(130, 39);
            this.NewButton.TabIndex = 32;
            this.NewButton.Text = "新增資料";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(937, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 27);
            this.label1.TabIndex = 33;
            this.label1.Text = "請輸入號碼(不含英文)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 583);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ThisMonthButton);
            this.Controls.Add(this.lotteryRichTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reviseButton);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EmptyButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.itemsTextBox);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.ItemsLabel);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.costDateTimePicker);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.costBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker costDateTimePicker;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox itemsTextBox;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button EmptyButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.BindingSource costBindingSource;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button reviseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.RichTextBox lotteryRichTextBox;
        private System.Windows.Forms.Button ThisMonthButton;
        private System.Windows.Forms.Button ThisLotteryButton;
        private System.Windows.Forms.Button LastLotteryButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label thisLotteryLabel;
        private System.Windows.Forms.Label lastLotteryLabel;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Label label1;
    }
}

