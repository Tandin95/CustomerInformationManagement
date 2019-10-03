namespace CustomerInformationManagementApp
{
    partial class CustomerInformation
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.lastName1 = new System.Windows.Forms.Label();
            this.firstName1 = new System.Windows.Forms.Label();
            this.age1 = new System.Windows.Forms.Label();
            this.necessary2 = new System.Windows.Forms.Label();
            this.birthDate = new System.Windows.Forms.Label();
            this.year1 = new System.Windows.Forms.Label();
            this.month1 = new System.Windows.Forms.Label();
            this.day1 = new System.Windows.Forms.Label();
            this.emailAddress1 = new System.Windows.Forms.Label();
            this.necessary4 = new System.Windows.Forms.Label();
            this.necessary3 = new System.Windows.Forms.Label();
            this.necessary = new System.Windows.Forms.Label();
            this.emailAddress = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.ComboBox();
            this.month = new System.Windows.Forms.ComboBox();
            this.year = new System.Windows.Forms.ComboBox();
            this.ageN = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "登録";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lastName1
            // 
            this.lastName1.AutoSize = true;
            this.lastName1.Location = new System.Drawing.Point(76, 64);
            this.lastName1.Name = "lastName1";
            this.lastName1.Size = new System.Drawing.Size(30, 15);
            this.lastName1.TabIndex = 8;
            this.lastName1.Text = "姓：";
            this.lastName1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // firstName1
            // 
            this.firstName1.AutoSize = true;
            this.firstName1.Location = new System.Drawing.Point(240, 64);
            this.firstName1.Name = "firstName1";
            this.firstName1.Size = new System.Drawing.Size(30, 15);
            this.firstName1.TabIndex = 9;
            this.firstName1.Text = "名：";
            // 
            // age1
            // 
            this.age1.AutoSize = true;
            this.age1.Location = new System.Drawing.Point(67, 119);
            this.age1.Name = "age1";
            this.age1.Size = new System.Drawing.Size(45, 15);
            this.age1.TabIndex = 10;
            this.age1.Text = "年齢：";
            // 
            // necessary2
            // 
            this.necessary2.AutoSize = true;
            this.necessary2.Location = new System.Drawing.Point(403, 119);
            this.necessary2.Name = "necessary2";
            this.necessary2.Size = new System.Drawing.Size(47, 15);
            this.necessary2.TabIndex = 11;
            this.necessary2.Text = "(必須)";
            // 
            // birthDate
            // 
            this.birthDate.AutoSize = true;
            this.birthDate.Location = new System.Drawing.Point(39, 170);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(75, 15);
            this.birthDate.TabIndex = 12;
            this.birthDate.Text = "生年月日：";
            // 
            // year1
            // 
            this.year1.AutoSize = true;
            this.year1.Location = new System.Drawing.Point(203, 168);
            this.year1.Name = "year1";
            this.year1.Size = new System.Drawing.Size(22, 15);
            this.year1.TabIndex = 13;
            this.year1.Text = "年";
            // 
            // month1
            // 
            this.month1.AutoSize = true;
            this.month1.Location = new System.Drawing.Point(276, 168);
            this.month1.Name = "month1";
            this.month1.Size = new System.Drawing.Size(22, 15);
            this.month1.TabIndex = 14;
            this.month1.Text = "月";
            this.month1.Click += new System.EventHandler(this.Month_Click);
            // 
            // day1
            // 
            this.day1.AutoSize = true;
            this.day1.Location = new System.Drawing.Point(349, 165);
            this.day1.Name = "day1";
            this.day1.Size = new System.Drawing.Size(22, 15);
            this.day1.TabIndex = 15;
            this.day1.Text = "日";
            // 
            // emailAddress1
            // 
            this.emailAddress1.AutoSize = true;
            this.emailAddress1.Location = new System.Drawing.Point(21, 215);
            this.emailAddress1.Name = "emailAddress1";
            this.emailAddress1.Size = new System.Drawing.Size(93, 15);
            this.emailAddress1.TabIndex = 16;
            this.emailAddress1.Text = "メールアドレス：";
            this.emailAddress1.Click += new System.EventHandler(this.Label9_Click);
            // 
            // necessary4
            // 
            this.necessary4.AutoSize = true;
            this.necessary4.Location = new System.Drawing.Point(403, 215);
            this.necessary4.Name = "necessary4";
            this.necessary4.Size = new System.Drawing.Size(181, 15);
            this.necessary4.TabIndex = 17;
            this.necessary4.Text = "(責任　例：aaaaaaa@xxxxxx)";
            // 
            // necessary3
            // 
            this.necessary3.AutoSize = true;
            this.necessary3.Location = new System.Drawing.Point(403, 162);
            this.necessary3.Name = "necessary3";
            this.necessary3.Size = new System.Drawing.Size(95, 15);
            this.necessary3.TabIndex = 18;
            this.necessary3.Text = "(必須：　数値)";
            // 
            // necessary
            // 
            this.necessary.AutoSize = true;
            this.necessary.Location = new System.Drawing.Point(403, 68);
            this.necessary.Name = "necessary";
            this.necessary.Size = new System.Drawing.Size(47, 15);
            this.necessary.TabIndex = 19;
            this.necessary.Text = "(必須)";
            this.necessary.Click += new System.EventHandler(this.Name_Click);
            // 
            // emailAddress
            // 
            this.emailAddress.Location = new System.Drawing.Point(115, 212);
            this.emailAddress.Name = "emailAddress";
            this.emailAddress.Size = new System.Drawing.Size(277, 22);
            this.emailAddress.TabIndex = 6;
            // 
            // date
            // 
            this.date.FormattingEnabled = true;
            this.date.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "20",
            "31"});
            this.date.Location = new System.Drawing.Point(304, 162);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(39, 23);
            this.date.TabIndex = 5;
            // 
            // month
            // 
            this.month.FormattingEnabled = true;
            this.month.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.month.Location = new System.Drawing.Point(231, 162);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(39, 23);
            this.month.TabIndex = 4;
            // 
            // year
            // 
            this.year.FormattingEnabled = true;
            this.year.Items.AddRange(new object[] {
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990"});
            this.year.Location = new System.Drawing.Point(115, 162);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(76, 23);
            this.year.TabIndex = 3;
            this.year.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // ageN
            // 
            this.ageN.Location = new System.Drawing.Point(115, 116);
            this.ageN.Name = "ageN";
            this.ageN.Size = new System.Drawing.Size(277, 22);
            this.ageN.TabIndex = 2;
            this.ageN.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(276, 61);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(116, 22);
            this.firstName.TabIndex = 1;
            this.firstName.TextChanged += new System.EventHandler(this.LasName_TextChanged);
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(115, 61);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(116, 22);
            this.lastName.TabIndex = 0;
            this.lastName.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 20;
            // 
            // CustomerInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.necessary);
            this.Controls.Add(this.necessary3);
            this.Controls.Add(this.necessary4);
            this.Controls.Add(this.emailAddress1);
            this.Controls.Add(this.day1);
            this.Controls.Add(this.month1);
            this.Controls.Add(this.year1);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.necessary2);
            this.Controls.Add(this.age1);
            this.Controls.Add(this.firstName1);
            this.Controls.Add(this.lastName1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.emailAddress);
            this.Controls.Add(this.date);
            this.Controls.Add(this.month);
            this.Controls.Add(this.year);
            this.Controls.Add(this.ageN);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.lastName);
            this.Name = "CustomerInformation";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.CustomerInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lastName1;
        private System.Windows.Forms.Label firstName1;
        private System.Windows.Forms.Label age1;
        private System.Windows.Forms.Label necessary2;
        private System.Windows.Forms.Label birthDate;
        private System.Windows.Forms.Label year1;
        private System.Windows.Forms.Label month1;
        private System.Windows.Forms.Label day1;
        private System.Windows.Forms.Label emailAddress1;
        private System.Windows.Forms.Label necessary4;
        private System.Windows.Forms.Label necessary3;
        private System.Windows.Forms.Label necessary;
        private System.Windows.Forms.TextBox emailAddress;
        private System.Windows.Forms.ComboBox date;
        private System.Windows.Forms.ComboBox month;
        private System.Windows.Forms.ComboBox year;
        private System.Windows.Forms.TextBox ageN;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label1;
    }
}

