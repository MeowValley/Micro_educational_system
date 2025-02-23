namespace Satelliteeducationsystem.teacher
{
    partial class teacherMainForm
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
            this.components = new System.ComponentModel.Container();
            AntdUI.CarouselItem carouselItem1 = new AntdUI.CarouselItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacherMainForm));
            AntdUI.CarouselItem carouselItem2 = new AntdUI.CarouselItem();
            AntdUI.CarouselItem carouselItem3 = new AntdUI.CarouselItem();
            AntdUI.CarouselItem carouselItem4 = new AntdUI.CarouselItem();
            this.stuMenu = new System.Windows.Forms.MenuStrip();
            this.账户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.聊天ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.空闲教室ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我的班级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课表管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.公告ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.公共留言板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件中心ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于本系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paisi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.关于本校ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.username = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.carousel1 = new AntdUI.Carousel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.stuMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stuMenu
            // 
            this.stuMenu.AllowMerge = false;
            this.stuMenu.AutoSize = false;
            this.stuMenu.BackColor = System.Drawing.Color.Aqua;
            this.stuMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.stuMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.账户管理ToolStripMenuItem,
            this.聊天ToolStripMenuItem,
            this.空闲教室ToolStripMenuItem,
            this.我的班级ToolStripMenuItem,
            this.成绩管理ToolStripMenuItem,
            this.公告ToolStripMenuItem,
            this.公共留言板ToolStripMenuItem,
            this.文件中心ToolStripMenuItem,
            this.关于本系统ToolStripMenuItem,
            this.paisi,
            this.退出登录ToolStripMenuItem});
            this.stuMenu.Location = new System.Drawing.Point(0, 0);
            this.stuMenu.Name = "stuMenu";
            this.stuMenu.Padding = new System.Windows.Forms.Padding(5, 6, 5, 20);
            this.stuMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.stuMenu.Size = new System.Drawing.Size(183, 590);
            this.stuMenu.TabIndex = 16;
            this.stuMenu.Text = "menuStrip1";
            // 
            // 账户管理ToolStripMenuItem
            // 
            this.账户管理ToolStripMenuItem.BackColor = System.Drawing.Color.Aqua;
            this.账户管理ToolStripMenuItem.CheckOnClick = true;
            this.账户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.账户管理ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 0, 10);
            this.账户管理ToolStripMenuItem.Name = "账户管理ToolStripMenuItem";
            this.账户管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.账户管理ToolStripMenuItem.Text = "账户管理   >>>";
            this.账户管理ToolStripMenuItem.Click += new System.EventHandler(this.账户管理ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem1.Text = "个人信息";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem2.Text = "修改密码";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // 聊天ToolStripMenuItem
            // 
            this.聊天ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.聊天ToolStripMenuItem.Name = "聊天ToolStripMenuItem";
            this.聊天ToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.聊天ToolStripMenuItem.Text = "聊天";
            this.聊天ToolStripMenuItem.Click += new System.EventHandler(this.聊天ToolStripMenuItem_Click);
            // 
            // 空闲教室ToolStripMenuItem
            // 
            this.空闲教室ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.空闲教室ToolStripMenuItem.Name = "空闲教室ToolStripMenuItem";
            this.空闲教室ToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.空闲教室ToolStripMenuItem.Text = "空闲教室";
            this.空闲教室ToolStripMenuItem.Click += new System.EventHandler(this.空闲教室ToolStripMenuItem_Click);
            // 
            // 我的班级ToolStripMenuItem
            // 
            this.我的班级ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生管理ToolStripMenuItem,
            this.课表管理ToolStripMenuItem});
            this.我的班级ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.我的班级ToolStripMenuItem.Name = "我的班级ToolStripMenuItem";
            this.我的班级ToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.我的班级ToolStripMenuItem.Text = "班级管理";
            this.我的班级ToolStripMenuItem.Click += new System.EventHandler(this.我的班级ToolStripMenuItem_Click);
            // 
            // 学生管理ToolStripMenuItem
            // 
            this.学生管理ToolStripMenuItem.Name = "学生管理ToolStripMenuItem";
            this.学生管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.学生管理ToolStripMenuItem.Text = "学生管理";
            this.学生管理ToolStripMenuItem.Click += new System.EventHandler(this.学生管理ToolStripMenuItem_Click);
            // 
            // 课表管理ToolStripMenuItem
            // 
            this.课表管理ToolStripMenuItem.Name = "课表管理ToolStripMenuItem";
            this.课表管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.课表管理ToolStripMenuItem.Text = "课表管理";
            this.课表管理ToolStripMenuItem.Click += new System.EventHandler(this.课表管理ToolStripMenuItem_Click);
            // 
            // 成绩管理ToolStripMenuItem
            // 
            this.成绩管理ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.成绩管理ToolStripMenuItem.Name = "成绩管理ToolStripMenuItem";
            this.成绩管理ToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.成绩管理ToolStripMenuItem.Text = "成绩管理";
            this.成绩管理ToolStripMenuItem.Click += new System.EventHandler(this.成绩管理ToolStripMenuItem_Click);
            // 
            // 公告ToolStripMenuItem
            // 
            this.公告ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.公告ToolStripMenuItem.Name = "公告ToolStripMenuItem";
            this.公告ToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.公告ToolStripMenuItem.Text = "公告中心";
            this.公告ToolStripMenuItem.Click += new System.EventHandler(this.公告ToolStripMenuItem_Click);
            // 
            // 公共留言板ToolStripMenuItem
            // 
            this.公共留言板ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.公共留言板ToolStripMenuItem.Name = "公共留言板ToolStripMenuItem";
            this.公共留言板ToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.公共留言板ToolStripMenuItem.Text = "公共留言板";
            this.公共留言板ToolStripMenuItem.Click += new System.EventHandler(this.公共留言板ToolStripMenuItem_Click);
            // 
            // 文件中心ToolStripMenuItem
            // 
            this.文件中心ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.文件中心ToolStripMenuItem.Name = "文件中心ToolStripMenuItem";
            this.文件中心ToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.文件中心ToolStripMenuItem.Text = "文件中心";
            this.文件中心ToolStripMenuItem.Click += new System.EventHandler(this.文件中心ToolStripMenuItem_Click);
            // 
            // 关于本系统ToolStripMenuItem
            // 
            this.关于本系统ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.关于本系统ToolStripMenuItem.Name = "关于本系统ToolStripMenuItem";
            this.关于本系统ToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.关于本系统ToolStripMenuItem.Text = "关于本系统";
            this.关于本系统ToolStripMenuItem.Click += new System.EventHandler(this.关于本系统ToolStripMenuItem_Click);
            // 
            // paisi
            // 
            this.paisi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.关于本校ToolStripMenuItem,
            this.toolStripMenuItem4});
            this.paisi.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.paisi.Name = "paisi";
            this.paisi.Size = new System.Drawing.Size(172, 24);
            this.paisi.Text = "重庆工商大学派斯学院";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 26);
            this.toolStripMenuItem3.Text = "学校风光";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // 关于本校ToolStripMenuItem
            // 
            this.关于本校ToolStripMenuItem.Name = "关于本校ToolStripMenuItem";
            this.关于本校ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.关于本校ToolStripMenuItem.Text = "关于本校";
            this.关于本校ToolStripMenuItem.Click += new System.EventHandler(this.关于本校ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(152, 26);
            this.toolStripMenuItem4.Text = "学校官网";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // 退出登录ToolStripMenuItem
            // 
            this.退出登录ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            this.退出登录ToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.退出登录ToolStripMenuItem.Text = "退出登录";
            this.退出登录ToolStripMenuItem.Click += new System.EventHandler(this.退出登录ToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("新宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(239, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(328, 50);
            this.label6.TabIndex = 30;
            this.label6.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("新宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(239, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 50);
            this.label3.TabIndex = 27;
            this.label3.Text = "年龄：";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("新宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(239, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 50);
            this.label4.TabIndex = 28;
            this.label4.Text = "手机号：";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("新宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(239, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(328, 50);
            this.label5.TabIndex = 29;
            this.label5.Text = "身份证号：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 31);
            this.button1.TabIndex = 33;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("新宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(239, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(328, 50);
            this.label7.TabIndex = 31;
            this.label7.Text = "性别：";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("新宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(239, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(328, 50);
            this.label8.TabIndex = 32;
            this.label8.Text = "电子邮箱：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("华文中宋", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(67, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(265, 26);
            this.label9.TabIndex = 34;
            this.label9.Text = "您的个人身份信息如下：";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("新宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(239, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 45);
            this.label1.TabIndex = 35;
            this.label1.Text = "编号：";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status1,
            this.username,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(183, 564);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1035, 26);
            this.statusStrip1.TabIndex = 36;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status1
            // 
            this.status1.Name = "status1";
            this.status1.Size = new System.Drawing.Size(167, 20);
            this.status1.Text = "toolStripStatusLabel1";
            // 
            // username
            // 
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(84, 20);
            this.username.Text = "当前账户：";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Padding = new System.Windows.Forms.Padding(450, 0, 0, 0);
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(762, 20);
            this.toolStripStatusLabel1.Text = "重庆工商大学派斯学院---课程设计（舒冰冰）";
            // 
            // carousel1
            // 
            this.carousel1.DotPosition = AntdUI.TAlignMini.Bottom;
            this.carousel1.DotSize = new System.Drawing.Size(28, 6);
            carouselItem1.Img = ((System.Drawing.Image)(resources.GetObject("carouselItem1.Img")));
            carouselItem2.Img = ((System.Drawing.Image)(resources.GetObject("carouselItem2.Img")));
            carouselItem3.Img = ((System.Drawing.Image)(resources.GetObject("carouselItem3.Img")));
            carouselItem4.Img = ((System.Drawing.Image)(resources.GetObject("carouselItem4.Img")));
            this.carousel1.Image.Add(carouselItem1);
            this.carousel1.Image.Add(carouselItem2);
            this.carousel1.Image.Add(carouselItem3);
            this.carousel1.Image.Add(carouselItem4);
            this.carousel1.Location = new System.Drawing.Point(183, 0);
            this.carousel1.Name = "carousel1";
            this.carousel1.Size = new System.Drawing.Size(1035, 358);
            this.carousel1.TabIndex = 37;
            this.carousel1.Text = "carousel1";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // teacherMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1218, 590);
            this.Controls.Add(this.carousel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stuMenu);
            this.Controls.Add(this.label9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "teacherMainForm";
            this.Text = "教师客户端";
            this.Load += new System.EventHandler(this.teacherMainForm_Load);
            this.stuMenu.ResumeLayout(false);
            this.stuMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip stuMenu;
        private System.Windows.Forms.ToolStripMenuItem 账户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 我的班级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 公告ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 公共留言板ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文件中心ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于本系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paisi;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 关于本校ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 退出登录ToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status1;
        private System.Windows.Forms.ToolStripStatusLabel username;
        private System.Windows.Forms.ToolStripMenuItem 学生管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课表管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩管理ToolStripMenuItem;
        private AntdUI.Carousel carousel1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem 聊天ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem 空闲教室ToolStripMenuItem;
    }
}