namespace Satelliteeducationsystem.通知
{
    partial class FrmNotice
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
            AntdUI.Tabs.StyleCard2 styleCard21 = new AntdUI.Tabs.StyleCard2();
            this.tabs1 = new AntdUI.Tabs();
            this.tabPage1 = new AntdUI.TabPage();
            this.sysnotice = new Sunny.UI.UIRichTextBox();
            this.tabPage2 = new AntdUI.TabPage();
            this.classnotice = new Sunny.UI.UIRichTextBox();
            this.tabPage3 = new AntdUI.TabPage();
            this.send = new AntdUI.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new AntdUI.TabPage();
            this.button1 = new AntdUI.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.notice = new Sunny.UI.UIRichTextBox();
            this.tabs1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs1
            // 
            this.tabs1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabs1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabs1.Location = new System.Drawing.Point(2, 1);
            this.tabs1.Name = "tabs1";
            this.tabs1.Pages.Add(this.tabPage1);
            this.tabs1.Pages.Add(this.tabPage2);
            this.tabs1.Pages.Add(this.tabPage3);
            this.tabs1.Pages.Add(this.tabPage4);
            this.tabs1.Size = new System.Drawing.Size(797, 448);
            styleCard21.BorderActive = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            styleCard21.Closable = AntdUI.Tabs.StyleCard2.CloseType.none;
            this.tabs1.Style = styleCard21;
            this.tabs1.TabIndex = 0;
            this.tabs1.Text = "tabs1";
            this.tabs1.Type = AntdUI.TabType.Card2;
            this.tabs1.SelectedIndexChanged += new AntdUI.IntEventHandler(this.tabs1_SelectedIndexChanged);
            this.tabs1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabs1_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage1.Controls.Add(this.sysnotice);
            this.tabPage1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(3, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(791, 406);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = "0";
            this.tabPage1.Text = "系统公告";
            // 
            // sysnotice
            // 
            this.sysnotice.FillColor = System.Drawing.Color.White;
            this.sysnotice.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sysnotice.Location = new System.Drawing.Point(-3, 0);
            this.sysnotice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sysnotice.MinimumSize = new System.Drawing.Size(1, 1);
            this.sysnotice.Name = "sysnotice";
            this.sysnotice.Padding = new System.Windows.Forms.Padding(2);
            this.sysnotice.ShowText = false;
            this.sysnotice.Size = new System.Drawing.Size(797, 409);
            this.sysnotice.Style = Sunny.UI.UIStyle.Custom;
            this.sysnotice.TabIndex = 0;
            this.sysnotice.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.sysnotice.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage2.Controls.Add(this.classnotice);
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(0, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = "1";
            this.tabPage2.Text = "班级公告";
            // 
            // classnotice
            // 
            this.classnotice.FillColor = System.Drawing.Color.White;
            this.classnotice.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.classnotice.Location = new System.Drawing.Point(-3, 0);
            this.classnotice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.classnotice.MinimumSize = new System.Drawing.Size(1, 1);
            this.classnotice.Name = "classnotice";
            this.classnotice.Padding = new System.Windows.Forms.Padding(2);
            this.classnotice.ShowText = false;
            this.classnotice.Size = new System.Drawing.Size(797, 406);
            this.classnotice.Style = Sunny.UI.UIStyle.Custom;
            this.classnotice.TabIndex = 0;
            this.classnotice.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.classnotice.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage3.Controls.Add(this.send);
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage3.Location = new System.Drawing.Point(-791, -406);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(791, 406);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Tag = "2";
            this.tabPage3.Text = "发布班级公告";
            this.tabPage3.Visible = false;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // send
            // 
            this.send.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(254)))), ((int)(((byte)(147)))));
            this.send.BackHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(59)))));
            this.send.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.send.Location = new System.Drawing.Point(274, 331);
            this.send.Name = "send";
            this.send.Radius = 0;
            this.send.Size = new System.Drawing.Size(251, 67);
            this.send.TabIndex = 1;
            this.send.Text = "发布";
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(-3, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(797, 308);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.richTextBox2);
            this.tabPage4.Location = new System.Drawing.Point(-791, -406);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(791, 406);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "发布系统公告";
            this.tabPage4.Visible = false;
            // 
            // button1
            // 
            this.button1.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(254)))), ((int)(((byte)(147)))));
            this.button1.BackHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(59)))));
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(274, 335);
            this.button1.Name = "button1";
            this.button1.Radius = 0;
            this.button1.Size = new System.Drawing.Size(251, 67);
            this.button1.TabIndex = 3;
            this.button1.Text = "发布";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(-3, 4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(797, 308);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // notice
            // 
            this.notice.FillColor = System.Drawing.Color.White;
            this.notice.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.notice.Location = new System.Drawing.Point(-3, 39);
            this.notice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.notice.MinimumSize = new System.Drawing.Size(1, 1);
            this.notice.Name = "notice";
            this.notice.Padding = new System.Windows.Forms.Padding(2);
            this.notice.ShowText = false;
            this.notice.Size = new System.Drawing.Size(800, 409);
            this.notice.Style = Sunny.UI.UIStyle.Custom;
            this.notice.TabIndex = 0;
            this.notice.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.notice.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // FrmNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabs1);
            this.Name = "FrmNotice";
            this.Text = "公告中心";
            this.Load += new System.EventHandler(this.FrmNotice_Load);
            this.tabs1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Tabs tabs1;
        private AntdUI.TabPage tabPage1;
        private AntdUI.TabPage tabPage2;
        private AntdUI.TabPage tabPage3;
        private Sunny.UI.UIRichTextBox sysnotice;
        private Sunny.UI.UIRichTextBox classnotice;
        private Sunny.UI.UIRichTextBox notice;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private AntdUI.Button send;
        private AntdUI.TabPage tabPage4;
        private AntdUI.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}