namespace Satelliteeducationsystem
{
    partial class ForgetPwd
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
            this.windowBar1 = new AntdUI.WindowBar();
            this.idcard = new System.Windows.Forms.TextBox();
            this.button2 = new AntdUI.Button();
            this.button1 = new AntdUI.Button();
            this.confirmpassword = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // windowBar1
            // 
            this.windowBar1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.windowBar1.DividerColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.windowBar1.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.windowBar1.ForeColor = System.Drawing.Color.Transparent;
            this.windowBar1.Location = new System.Drawing.Point(-1, -1);
            this.windowBar1.Name = "windowBar1";
            this.windowBar1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.windowBar1.Size = new System.Drawing.Size(579, 31);
            this.windowBar1.TabIndex = 11;
            this.windowBar1.Text = " 忘记密码";
            // 
            // idcard
            // 
            this.idcard.Location = new System.Drawing.Point(201, 110);
            this.idcard.Name = "idcard";
            this.idcard.Size = new System.Drawing.Size(242, 25);
            this.idcard.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(334, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 57);
            this.button2.TabIndex = 20;
            this.button2.Text = "返回";
            this.button2.Type = AntdUI.TTypeMini.Error;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 57);
            this.button1.TabIndex = 19;
            this.button1.Text = " 确认";
            this.button1.ToggleBackActive = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.button1.ToggleBackHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(144)))));
            this.button1.Type = AntdUI.TTypeMini.Success;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // confirmpassword
            // 
            this.confirmpassword.Location = new System.Drawing.Point(200, 247);
            this.confirmpassword.Name = "confirmpassword";
            this.confirmpassword.PasswordChar = '*';
            this.confirmpassword.Size = new System.Drawing.Size(243, 25);
            this.confirmpassword.TabIndex = 18;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(200, 176);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(243, 25);
            this.password.TabIndex = 17;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(200, 47);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(243, 25);
            this.phone.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(95, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "确认密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(95, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "新密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(75, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "身份证号码:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(95, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "手机号：";
            // 
            // ForgetPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 384);
            this.Controls.Add(this.idcard);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.confirmpassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.windowBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgetPwd";
            this.Text = "ForgetPwd";
            this.Load += new System.EventHandler(this.ForgetPwd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AntdUI.WindowBar windowBar1;
        private System.Windows.Forms.TextBox idcard;
        private AntdUI.Button button2;
        private AntdUI.Button button1;
        private System.Windows.Forms.TextBox confirmpassword;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}