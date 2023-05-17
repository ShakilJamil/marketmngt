namespace market_management
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            label1 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            MarketMM = new Label();
            username = new TextBox();
            password = new TextBox();
            label3 = new Label();
            label4 = new Label();
            loginbtn = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            resetbtn = new Label();
            pictureBox5 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calisto MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(460, 43);
            label1.Name = "label1";
            label1.Size = new Size(76, 32);
            label1.TabIndex = 0;
            label1.Text = "login";
            label1.UseMnemonic = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.Red;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 1, 3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 682);
            panel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Cascadia Mono", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(35, 224);
            label5.Name = "label5";
            label5.Size = new Size(143, 134);
            label5.TabIndex = 13;
            label5.Text = "SUPER MARKET";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // MarketMM
            // 
            MarketMM.AutoSize = true;
            MarketMM.Font = new Font("Cambria Math", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            MarketMM.ForeColor = Color.OrangeRed;
            MarketMM.Location = new Point(358, -22);
            MarketMM.Name = "MarketMM";
            MarketMM.Size = new Size(438, 190);
            MarketMM.TabIndex = 2;
            MarketMM.Text = "MARKET MANEGMENT";
            MarketMM.Click += MarketMM_Click;
            // 
            // username
            // 
            username.Font = new Font("Candara Light", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(424, 318);
            username.Margin = new Padding(3, 1, 3, 1);
            username.Name = "username";
            username.RightToLeft = RightToLeft.No;
            username.Size = new Size(219, 23);
            username.TabIndex = 3;
            // 
            // password
            // 
            password.Font = new Font("Candara Light", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(424, 391);
            password.Margin = new Padding(3, 1, 3, 1);
            password.Name = "password";
            password.Size = new Size(219, 23);
            password.TabIndex = 4;
            password.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(409, 69);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(424, 356);
            label4.Name = "label4";
            label4.Size = new Size(81, 21);
            label4.TabIndex = 7;
            label4.Text = "password";
            label4.Click += label4_Click;
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.PowderBlue;
            loginbtn.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginbtn.ForeColor = SystemColors.ActiveCaptionText;
            loginbtn.Location = new Point(460, 441);
            loginbtn.Margin = new Padding(3, 1, 3, 1);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(145, 32);
            loginbtn.TabIndex = 8;
            loginbtn.Text = "login";
            loginbtn.TextAlign = ContentAlignment.TopCenter;
            loginbtn.UseMnemonic = false;
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(424, 285);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 5;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.bf61ea162400633_Y3JvcCwxNDMzLDExMjEsMjg3LDE5OA;
            pictureBox1.Location = new Point(361, 127);
            pictureBox1.Margin = new Padding(3, 1, 3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(438, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(361, 285);
            pictureBox2.Margin = new Padding(3, 1, 3, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(361, 356);
            pictureBox3.Margin = new Padding(3, 1, 3, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 58);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // resetbtn
            // 
            resetbtn.AutoSize = true;
            resetbtn.Font = new Font("Candara", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            resetbtn.Location = new Point(503, 486);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(59, 21);
            resetbtn.TabIndex = 12;
            resetbtn.Text = "Forget";
            resetbtn.Click += resetbtn_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(976, 0);
            pictureBox5.Margin = new Padding(3, 1, 3, 1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(37, 54);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1015, 682);
            Controls.Add(pictureBox5);
            Controls.Add(resetbtn);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(loginbtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(MarketMM);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Candara Light", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += login_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label MarketMM;
        private TextBox username;
        private TextBox password;
        private Label label3;
        private Label label4;
        private Button loginbtn;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label5;
        private Label resetbtn;
        private PictureBox pictureBox5;
    }
}