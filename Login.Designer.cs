namespace Satelliteeducationsystem
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.codebox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Identity = new System.Windows.Forms.ComboBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new AntdUI.Button();
            this.label5 = new AntdUI.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new AntdUI.Label();
            this.label7 = new AntdUI.Label();
            this.label8 = new AntdUI.Label();
            this.label9 = new AntdUI.Label();
            this.label10 = new AntdUI.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // codebox
            // 
            this.codebox.Location = new System.Drawing.Point(264, 276);
            this.codebox.Name = "codebox";
            this.codebox.Size = new System.Drawing.Size(200, 25);
            this.codebox.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 24;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Green;
            this.linkLabel2.Location = new System.Drawing.Point(468, 120);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(112, 25);
            this.linkLabel2.TabIndex = 23;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "忘记密码";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(468, 45);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(62, 25);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "注册";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 64);
            this.button2.TabIndex = 21;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 64);
            this.button1.TabIndex = 20;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Identity
            // 
            this.Identity.FormattingEnabled = true;
            this.Identity.Items.AddRange(new object[] {
            "学生",
            "教师",
            "管理员"});
            this.Identity.Location = new System.Drawing.Point(286, 195);
            this.Identity.Name = "Identity";
            this.Identity.Size = new System.Drawing.Size(200, 23);
            this.Identity.TabIndex = 19;
            this.Identity.Text = "学生";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(181, 120);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(260, 25);
            this.Password.TabIndex = 18;
            // 
            // ID
            // 
            this.ID.ForeColor = System.Drawing.Color.Silver;
            this.ID.Location = new System.Drawing.Point(181, 45);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(260, 25);
            this.ID.TabIndex = 17;
            this.ID.Text = "(请输入手机号,身份证号或电子邮箱)";
            this.ID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ID_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(75, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "登录身份选择：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(87, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(86, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "账户：";
            // 
            // button3
            // 
            this.button3.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(668, 319);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 73);
            this.button3.TabIndex = 27;
            this.button3.Text = "生成验证码";
            this.button3.ToggleBackActive = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.button3.ToggleBackHover = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(32)))), ((int)(((byte)(216)))));
            this.button3.ToggleFore = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.BackgroundImage = global::Satelliteeducationsystem.Properties.Resources.用户;
            this.label5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.label5.Location = new System.Drawing.Point(54, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 38);
            this.label5.TabIndex = 28;
            this.label5.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Satelliteeducationsystem.Properties.Resources.logo1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(626, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(92, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 35);
            this.label6.TabIndex = 29;
            this.label6.Text = "验证码：";
            // 
            // label7
            // 
            this.label7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("label7.BackgroundImage")));
            this.label7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.label7.Location = new System.Drawing.Point(47, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 48);
            this.label7.TabIndex = 30;
            this.label7.Text = "";
            // 
            // label8
            // 
            this.label8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("label8.BackgroundImage")));
            this.label8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.label8.Location = new System.Drawing.Point(51, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 37);
            this.label8.TabIndex = 31;
            this.label8.Text = "";
            // 
            // label9
            // 
            this.label9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("label9.BackgroundImage")));
            this.label9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.label9.Location = new System.Drawing.Point(50, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 25);
            this.label9.TabIndex = 32;
            this.label9.Text = "";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(595, 423);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(285, 38);
            this.label10.TabIndex = 33;
            this.label10.Text = "完工纪念：2024年12月30日 22：11";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 473);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.codebox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Identity);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox codebox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Identity;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private AntdUI.Button button3;
        private AntdUI.Label label5;
        private AntdUI.Label label6;
        private AntdUI.Label label7;
        private AntdUI.Label label8;
        private AntdUI.Label label9;
        private AntdUI.Label label10;
    }
}

