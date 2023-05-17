namespace market_management
{
    partial class productms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productms));
            Editbtn = new Button();
            label1 = new Label();
            pricetb = new TextBox();
            sidcb = new ComboBox();
            pictureBox2 = new PictureBox();
            Addbtn = new Button();
            ditb = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            productnametb = new TextBox();
            panel2 = new Panel();
            label2 = new Label();
            Prdlist = new DataGridView();
            label6 = new Label();
            deletebtn = new Button();
            pictureBox1 = new PictureBox();
            emplb = new Label();
            pictureBox3 = new PictureBox();
            shoplb = new Label();
            pictureBox4 = new PictureBox();
            backm = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Prdlist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // Editbtn
            // 
            Editbtn.BackColor = Color.Yellow;
            Editbtn.Font = new Font("Cascadia Mono", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            Editbtn.ForeColor = SystemColors.ActiveCaptionText;
            Editbtn.Location = new Point(113, 411);
            Editbtn.Margin = new Padding(2, 3, 2, 3);
            Editbtn.Name = "Editbtn";
            Editbtn.Size = new Size(71, 30);
            Editbtn.TabIndex = 63;
            Editbtn.Text = "Update";
            Editbtn.TextAlign = ContentAlignment.TopCenter;
            Editbtn.UseMnemonic = false;
            Editbtn.UseVisualStyleBackColor = false;
            Editbtn.Click += Editbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 301);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 62;
            label1.Text = "price";
            label1.Click += label1_Click;
            // 
            // pricetb
            // 
            pricetb.Location = new Point(30, 324);
            pricetb.Margin = new Padding(2, 3, 2, 3);
            pricetb.Name = "pricetb";
            pricetb.Size = new Size(143, 23);
            pricetb.TabIndex = 61;
            pricetb.TextChanged += pricetb_TextChanged;
            // 
            // sidcb
            // 
            sidcb.Font = new Font("Candara Light", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            sidcb.FormattingEnabled = true;
            sidcb.ItemHeight = 15;
            sidcb.Location = new Point(30, 374);
            sidcb.Margin = new Padding(2, 3, 2, 3);
            sidcb.Name = "sidcb";
            sidcb.Size = new Size(143, 23);
            sidcb.TabIndex = 60;
            sidcb.SelectedIndexChanged += sidcb_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(44, 106);
            pictureBox2.Margin = new Padding(2, 3, 2, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 59;
            pictureBox2.TabStop = false;
            // 
            // Addbtn
            // 
            Addbtn.BackColor = Color.Green;
            Addbtn.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Addbtn.ForeColor = SystemColors.ActiveCaptionText;
            Addbtn.Location = new Point(15, 411);
            Addbtn.Margin = new Padding(2, 3, 2, 3);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(78, 30);
            Addbtn.TabIndex = 58;
            Addbtn.Text = "Add";
            Addbtn.TextAlign = ContentAlignment.TopCenter;
            Addbtn.UseMnemonic = false;
            Addbtn.UseVisualStyleBackColor = false;
            Addbtn.Click += Addbtn_Click;
            // 
            // ditb
            // 
            ditb.CalendarFont = new Font("Candara", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            ditb.CalendarMonthBackground = Color.Red;
            ditb.CalendarTitleBackColor = Color.RebeccaPurple;
            ditb.Format = DateTimePickerFormat.Short;
            ditb.Location = new Point(30, 272);
            ditb.Margin = new Padding(2, 3, 2, 3);
            ditb.Name = "ditb";
            ditb.Size = new Size(143, 23);
            ditb.TabIndex = 57;
            ditb.ValueChanged += ditb_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(30, 248);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 21);
            label5.TabIndex = 54;
            label5.Text = "Import Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 350);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 53;
            label4.Text = "SHOP  ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(30, 197);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 21);
            label3.TabIndex = 52;
            label3.Text = "Product  Name";
            // 
            // productnametb
            // 
            productnametb.Location = new Point(30, 222);
            productnametb.Margin = new Padding(2, 3, 2, 3);
            productnametb.Name = "productnametb";
            productnametb.Size = new Size(143, 23);
            productnametb.TabIndex = 51;
            productnametb.TextChanged += productnametb_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.OrangeRed;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(967, 94);
            panel2.TabIndex = 64;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cambria Math", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(163, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(364, 86);
            label2.TabIndex = 0;
            label2.Text = "PRODUCTS MANAGEMENT";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Prdlist
            // 
            Prdlist.BackgroundColor = Color.Bisque;
            Prdlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Prdlist.GridColor = Color.OrangeRed;
            Prdlist.Location = new Point(254, 222);
            Prdlist.Margin = new Padding(2, 3, 2, 3);
            Prdlist.Name = "Prdlist";
            Prdlist.RowHeadersWidth = 51;
            Prdlist.RowTemplate.Height = 29;
            Prdlist.Size = new Size(594, 338);
            Prdlist.TabIndex = 46;
            Prdlist.CellContentClick += Prdlist_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(500, 190);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(130, 28);
            label6.TabIndex = 65;
            label6.Text = "Product List";
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.Red;
            deletebtn.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deletebtn.ForeColor = SystemColors.ActiveCaptionText;
            deletebtn.Location = new Point(67, 457);
            deletebtn.Margin = new Padding(2, 3, 2, 3);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(81, 30);
            deletebtn.TabIndex = 72;
            deletebtn.Text = "Delete";
            deletebtn.TextAlign = ContentAlignment.TopCenter;
            deletebtn.UseMnemonic = false;
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(231, 106);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 73;
            pictureBox1.TabStop = false;
            // 
            // emplb
            // 
            emplb.AutoSize = true;
            emplb.BackColor = Color.Transparent;
            emplb.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            emplb.ForeColor = Color.Red;
            emplb.Location = new Point(287, 133);
            emplb.Margin = new Padding(2, 0, 2, 0);
            emplb.Name = "emplb";
            emplb.Size = new Size(80, 21);
            emplb.TabIndex = 74;
            emplb.Text = "Emplyees";
            emplb.Click += emplb_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(480, 106);
            pictureBox3.Margin = new Padding(2, 3, 2, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(52, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 75;
            pictureBox3.TabStop = false;
            // 
            // shoplb
            // 
            shoplb.AutoSize = true;
            shoplb.BackColor = Color.Transparent;
            shoplb.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            shoplb.ForeColor = Color.Red;
            shoplb.Location = new Point(536, 133);
            shoplb.Margin = new Padding(2, 0, 2, 0);
            shoplb.Name = "shoplb";
            shoplb.Size = new Size(55, 21);
            shoplb.TabIndex = 76;
            shoplb.Text = "Shops";
            shoplb.Click += shoplb_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(703, 106);
            pictureBox4.Margin = new Padding(2, 3, 2, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 78;
            pictureBox4.TabStop = false;
            // 
            // backm
            // 
            backm.AutoSize = true;
            backm.BackColor = Color.Transparent;
            backm.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            backm.ForeColor = Color.Red;
            backm.Location = new Point(759, 133);
            backm.Margin = new Padding(2, 0, 2, 0);
            backm.Name = "backm";
            backm.Size = new Size(45, 21);
            backm.TabIndex = 79;
            backm.Text = "Back";
            backm.Click += backm_Click;
            // 
            // productms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(967, 594);
            Controls.Add(backm);
            Controls.Add(pictureBox4);
            Controls.Add(shoplb);
            Controls.Add(pictureBox3);
            Controls.Add(emplb);
            Controls.Add(pictureBox1);
            Controls.Add(deletebtn);
            Controls.Add(label6);
            Controls.Add(Prdlist);
            Controls.Add(panel2);
            Controls.Add(Editbtn);
            Controls.Add(label1);
            Controls.Add(pricetb);
            Controls.Add(sidcb);
            Controls.Add(pictureBox2);
            Controls.Add(Addbtn);
            Controls.Add(ditb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(productnametb);
            Font = new Font("Candara Light", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "productms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "productms";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Prdlist).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Editbtn;
        private Label label1;
        private TextBox pricetb;
        private ComboBox sidcb;
        private PictureBox pictureBox2;
        private Button Addbtn;
        private DateTimePicker ditb;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox productnametb;
        private Panel panel2;
        private Label label2;
        private DataGridView Prdlist;
        private Label label6;
        private Button deletebtn;
        private PictureBox pictureBox1;
        private Label emplb;
        private PictureBox pictureBox3;
        private Label shoplb;
        private PictureBox pictureBox4;
        private Label backm;
    }
}