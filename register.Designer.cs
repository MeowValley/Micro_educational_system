namespace Satelliteeducationsystem
{
    partial class register
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
            this.Phone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FirmPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.Age = new System.Windows.Forms.NumericUpDown();
            this.IDcard = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Femael = new System.Windows.Forms.RadioButton();
            this.Meal = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.Identity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).BeginInit();
            this.SuspendLayout();
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(163, 403);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(251, 25);
            this.Phone.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 40;
            this.label9.Text = "手机号：";
            // 
            // FirmPassword
            // 
            this.FirmPassword.Location = new System.Drawing.Point(163, 318);
            this.FirmPassword.Name = "FirmPassword";
            this.FirmPassword.PasswordChar = '*';
            this.FirmPassword.Size = new System.Drawing.Size(251, 25);
            this.FirmPassword.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 38;
            this.label8.Text = "确认密码:";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(163, 364);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(251, 25);
            this.Email.TabIndex = 37;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(163, 276);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(251, 25);
            this.Password.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "邮箱：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "密码：";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(394, 445);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(94, 33);
            this.back.TabIndex = 33;
            this.back.Text = "返回";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(84, 445);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(83, 33);
            this.next.TabIndex = 32;
            this.next.Text = "注册";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(172, 123);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(120, 25);
            this.Age.TabIndex = 31;
            this.Age.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // IDcard
            // 
            this.IDcard.Location = new System.Drawing.Point(152, 175);
            this.IDcard.Name = "IDcard";
            this.IDcard.Size = new System.Drawing.Size(284, 25);
            this.IDcard.TabIndex = 30;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(152, 24);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(189, 25);
            this.UserName.TabIndex = 29;
            // 
            // Femael
            // 
            this.Femael.AutoSize = true;
            this.Femael.Location = new System.Drawing.Point(247, 77);
            this.Femael.Name = "Femael";
            this.Femael.Size = new System.Drawing.Size(43, 19);
            this.Femael.TabIndex = 28;
            this.Femael.Text = "女";
            this.Femael.UseVisualStyleBackColor = true;
            // 
            // Meal
            // 
            this.Meal.AutoSize = true;
            this.Meal.Checked = true;
            this.Meal.Location = new System.Drawing.Point(172, 77);
            this.Meal.Name = "Meal";
            this.Meal.Size = new System.Drawing.Size(43, 19);
            this.Meal.TabIndex = 27;
            this.Meal.TabStop = true;
            this.Meal.Text = "男";
            this.Meal.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "性别：";
            // 
            // Identity
            // 
            this.Identity.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Identity.FormattingEnabled = true;
            this.Identity.Items.AddRange(new object[] {
            "学生",
            "教师",
            "管理员"});
            this.Identity.Location = new System.Drawing.Point(204, 227);
            this.Identity.Name = "Identity";
            this.Identity.Size = new System.Drawing.Size(121, 23);
            this.Identity.TabIndex = 25;
            this.Identity.Text = "学生";
            this.Identity.SelectedIndexChanged += new System.EventHandler(this.Identity_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "注册身份选择：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "身份证号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "年龄：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "姓名：";
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 502);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FirmPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.back);
            this.Controls.Add(this.next);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.IDcard);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Femael);
            this.Controls.Add(this.Meal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Identity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "register";
            this.Text = "用户注册";
            this.Load += new System.EventHandler(this.register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FirmPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.NumericUpDown Age;
        private System.Windows.Forms.TextBox IDcard;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.RadioButton Femael;
        private System.Windows.Forms.RadioButton Meal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Identity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}