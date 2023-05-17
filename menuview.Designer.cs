namespace market_management
{
    partial class menuview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuview));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            emplb = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            logoutlb = new Label();
            shoplb = new Label();
            prdlb = new Label();
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 107);
            panel1.TabIndex = 29;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria Math", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(231, 0);
            label1.Name = "label1";
            label1.Size = new Size(468, 97);
            label1.TabIndex = 0;
            label1.Text = "Market Management";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(393, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // emplb
            // 
            emplb.AutoSize = true;
            emplb.BackColor = Color.Transparent;
            emplb.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            emplb.ForeColor = Color.Red;
            emplb.Location = new Point(393, 187);
            emplb.Name = "emplb";
            emplb.Size = new Size(80, 21);
            emplb.TabIndex = 41;
            emplb.Text = "Emplyees";
            emplb.Click += emplb_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(601, 275);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(67, 54);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 42;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(197, 275);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(764, 144);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(46, 28);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 44;
            pictureBox4.TabStop = false;
            // 
            // logoutlb
            // 
            logoutlb.AutoSize = true;
            logoutlb.BackColor = Color.Transparent;
            logoutlb.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            logoutlb.ForeColor = Color.Red;
            logoutlb.Location = new Point(816, 151);
            logoutlb.Name = "logoutlb";
            logoutlb.Size = new Size(58, 21);
            logoutlb.TabIndex = 45;
            logoutlb.Text = "logout";
            logoutlb.Click += logoutlb_Click;
            // 
            // shoplb
            // 
            shoplb.AutoSize = true;
            shoplb.BackColor = Color.Transparent;
            shoplb.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            shoplb.ForeColor = Color.Red;
            shoplb.Location = new Point(197, 332);
            shoplb.Name = "shoplb";
            shoplb.Size = new Size(55, 21);
            shoplb.TabIndex = 46;
            shoplb.Text = "Shops";
            shoplb.Click += shoplb_Click;
            // 
            // prdlb
            // 
            prdlb.AutoSize = true;
            prdlb.BackColor = Color.Transparent;
            prdlb.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            prdlb.ForeColor = Color.Red;
            prdlb.Location = new Point(601, 332);
            prdlb.Name = "prdlb";
            prdlb.Size = new Size(75, 21);
            prdlb.TabIndex = 47;
            prdlb.Text = "Products";
            prdlb.Click += prdlb_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.OrangeRed;
            panel2.Dock = DockStyle.Bottom;
            panel2.ForeColor = Color.Crimson;
            panel2.Location = new Point(0, 533);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 38);
            panel2.TabIndex = 48;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(311, 231);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(272, 171);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 49;
            pictureBox5.TabStop = false;
            // 
            // menuview
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 571);
            Controls.Add(pictureBox5);
            Controls.Add(panel2);
            Controls.Add(prdlb);
            Controls.Add(shoplb);
            Controls.Add(logoutlb);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(emplb);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "menuview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "menuview";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label emplb;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Label logoutlb;
        private Label shoplb;
        private Label prdlb;
        private Panel panel2;
        private PictureBox pictureBox5;
    }
}