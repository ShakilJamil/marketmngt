namespace market_management
{
    partial class Employees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            ename = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label7 = new Label();
            textBox5 = new TextBox();
            pictureBox2 = new PictureBox();
            jdate = new DateTimePicker();
            addbtn = new Button();
            editbtn = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            emplist = new DataGridView();
            label8 = new Label();
            deletebtn = new Button();
            backm = new Label();
            pictureBox4 = new PictureBox();
            shoplb = new Label();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            prdlb = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emplist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 1, 3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 22);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.OrangeRed;
            panel2.CausesValidation = false;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 1, 3, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(950, 166);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(328, 22);
            label2.Name = "label2";
            label2.Size = new Size(410, 34);
            label2.TabIndex = 0;
            label2.Text = "Employee management";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria Math", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(222, 2);
            label1.Name = "label1";
            label1.Size = new Size(410, 20);
            label1.TabIndex = 0;
            label1.Text = "Emplyee management";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.OrangeRed;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 547);
            panel3.Margin = new Padding(3, 1, 3, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(950, 7);
            panel3.TabIndex = 2;
            // 
            // ename
            // 
            ename.Font = new Font("Candara Light", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            ename.Location = new Point(68, 143);
            ename.Margin = new Padding(3, 1, 3, 1);
            ename.Name = "ename";
            ename.Size = new Size(153, 23);
            ename.TabIndex = 3;
            ename.TextAlign = HorizontalAlignment.Center;
            ename.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(67, 112);
            label3.Name = "label3";
            label3.Size = new Size(129, 21);
            label3.TabIndex = 7;
            label3.Text = "Employee Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(66, 181);
            label5.Name = "label5";
            label5.Size = new Size(78, 21);
            label5.TabIndex = 9;
            label5.Text = "Join Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(66, 250);
            label7.Name = "label7";
            label7.Size = new Size(54, 21);
            label7.TabIndex = 12;
            label7.Text = "Salary";
            label7.Click += label7_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(66, 283);
            textBox5.Margin = new Padding(3, 1, 3, 1);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(144, 23);
            textBox5.TabIndex = 11;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(73, 57);
            pictureBox2.Margin = new Padding(3, 1, 3, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(71, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // jdate
            // 
            jdate.CalendarFont = new Font("Candara", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            jdate.CalendarMonthBackground = Color.Red;
            jdate.CalendarTitleBackColor = Color.RebeccaPurple;
            jdate.Format = DateTimePickerFormat.Short;
            jdate.Location = new Point(66, 203);
            jdate.Margin = new Padding(3, 1, 3, 1);
            jdate.Name = "jdate";
            jdate.Size = new Size(153, 23);
            jdate.TabIndex = 15;
            jdate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.Green;
            addbtn.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addbtn.ForeColor = SystemColors.ActiveCaptionText;
            addbtn.Location = new Point(31, 335);
            addbtn.Margin = new Padding(3, 1, 3, 1);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(89, 38);
            addbtn.TabIndex = 9;
            addbtn.Text = "Add";
            addbtn.TextAlign = ContentAlignment.TopCenter;
            addbtn.UseMnemonic = false;
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // editbtn
            // 
            editbtn.BackColor = Color.Yellow;
            editbtn.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            editbtn.ForeColor = SystemColors.ActiveCaptionText;
            editbtn.Location = new Point(172, 336);
            editbtn.Margin = new Padding(3, 1, 3, 1);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(82, 37);
            editbtn.TabIndex = 16;
            editbtn.Text = "Update";
            editbtn.TextAlign = ContentAlignment.TopCenter;
            editbtn.UseMnemonic = false;
            editbtn.UseVisualStyleBackColor = false;
            editbtn.Click += editbtn_Click;
            // 
            // emplist
            // 
            emplist.BackgroundColor = Color.Bisque;
            emplist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            emplist.GridColor = Color.OrangeRed;
            emplist.Location = new Point(328, 203);
            emplist.Margin = new Padding(3, 1, 3, 1);
            emplist.Name = "emplist";
            emplist.RowHeadersWidth = 51;
            emplist.RowTemplate.Height = 29;
            emplist.Size = new Size(559, 290);
            emplist.TabIndex = 47;
            emplist.CellContentClick += emplist_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.OrangeRed;
            label8.Location = new Point(558, 178);
            label8.Name = "label8";
            label8.Size = new Size(126, 24);
            label8.TabIndex = 48;
            label8.Text = "EmployeeLIst";
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.Red;
            deletebtn.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deletebtn.ForeColor = SystemColors.ActiveCaptionText;
            deletebtn.Location = new Point(102, 393);
            deletebtn.Margin = new Padding(3, 1, 3, 1);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(83, 39);
            deletebtn.TabIndex = 73;
            deletebtn.Text = "Delete";
            deletebtn.TextAlign = ContentAlignment.TopCenter;
            deletebtn.UseMnemonic = false;
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click;
            // 
            // backm
            // 
            backm.AutoSize = true;
            backm.BackColor = Color.Transparent;
            backm.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            backm.ForeColor = Color.Red;
            backm.Location = new Point(776, 123);
            backm.Name = "backm";
            backm.Size = new Size(45, 21);
            backm.TabIndex = 85;
            backm.Text = "Back";
            backm.Click += backm_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(711, 90);
            pictureBox4.Margin = new Padding(3, 1, 3, 1);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(59, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 84;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // shoplb
            // 
            shoplb.AutoSize = true;
            shoplb.BackColor = Color.Transparent;
            shoplb.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            shoplb.ForeColor = Color.Red;
            shoplb.Location = new Point(598, 123);
            shoplb.Name = "shoplb";
            shoplb.Size = new Size(55, 21);
            shoplb.TabIndex = 83;
            shoplb.Text = "Shops";
            shoplb.Click += shoplb_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(533, 90);
            pictureBox3.Margin = new Padding(3, 1, 3, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(59, 54);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 82;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(312, 90);
            pictureBox1.Margin = new Padding(3, 1, 3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 86;
            pictureBox1.TabStop = false;
            // 
            // prdlb
            // 
            prdlb.AutoSize = true;
            prdlb.BackColor = Color.Transparent;
            prdlb.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            prdlb.ForeColor = Color.Red;
            prdlb.Location = new Point(377, 123);
            prdlb.Name = "prdlb";
            prdlb.Size = new Size(75, 21);
            prdlb.TabIndex = 87;
            prdlb.Text = "Products";
            prdlb.Click += prdlb_Click;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 554);
            Controls.Add(label2);
            Controls.Add(prdlb);
            Controls.Add(pictureBox1);
            Controls.Add(backm);
            Controls.Add(pictureBox4);
            Controls.Add(shoplb);
            Controls.Add(pictureBox3);
            Controls.Add(deletebtn);
            Controls.Add(label8);
            Controls.Add(emplist);
            Controls.Add(editbtn);
            Controls.Add(addbtn);
            Controls.Add(jdate);
            Controls.Add(pictureBox2);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(ename);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Candara Light", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MinimizeBox = false;
            Name = "Employees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employees";
            Load += Employees_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)emplist).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private TextBox ename;
        private Label label3;
        private Label label5;
        private Label label7;
        private TextBox textBox5;
        private PictureBox pictureBox2;
        private DateTimePicker jdate;
        private Button addbtn;
        private Button editbtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView emplist;
        private Label label8;
        private Button deletebtn;
        private Label backm;
        private PictureBox pictureBox4;
        private Label shoplb;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label prdlb;
    }
}