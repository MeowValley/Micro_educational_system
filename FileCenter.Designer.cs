namespace Satelliteeducationsystem
{
    partial class FileCenter
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.filelist = new Sunny.UI.UIDataGridView();
            this.fid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ftype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fsize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uploadtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgressState = new System.Windows.Forms.RichTextBox();
            this.fileprogress = new AntdUI.Progress();
            this.label1 = new AntdUI.Label();
            this.uploadDragger3 = new AntdUI.UploadDragger();
            this.uploadDragger2 = new AntdUI.UploadDragger();
            this.uploadDragger1 = new AntdUI.UploadDragger();
            this.label2 = new AntdUI.Label();
            this.State = new AntdUI.IconState();
            this.pagelabel = new AntdUI.Label();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.search = new Sunny.UI.UITextBox();
            this.uploadDragger4 = new AntdUI.UploadDragger();
            this.uiButton3 = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filelist)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // filelist
            // 
            this.filelist.AllowUserToAddRows = false;
            this.filelist.AllowUserToDeleteRows = false;
            this.filelist.AllowUserToResizeColumns = false;
            this.filelist.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.filelist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.filelist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.filelist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.filelist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.filelist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.filelist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.filelist.ColumnHeadersHeight = 32;
            this.filelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.filelist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fid,
            this.fname,
            this.ftype,
            this.fsize,
            this.uploadtime});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.filelist.DefaultCellStyle = dataGridViewCellStyle3;
            this.filelist.EnableHeadersVisualStyles = false;
            this.filelist.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.filelist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.filelist.Location = new System.Drawing.Point(8, 49);
            this.filelist.Name = "filelist";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.filelist.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.filelist.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.filelist.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.filelist.RowTemplate.Height = 27;
            this.filelist.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.filelist.SelectedIndex = -1;
            this.filelist.Size = new System.Drawing.Size(1125, 254);
            this.filelist.Style = Sunny.UI.UIStyle.Custom;
            this.filelist.TabIndex = 18;
            this.filelist.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.filelist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.filelist_CellClick);
            // 
            // fid
            // 
            this.fid.DataPropertyName = "fid";
            this.fid.HeaderText = "文件编号";
            this.fid.MinimumWidth = 6;
            this.fid.Name = "fid";
            this.fid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // fname
            // 
            this.fname.DataPropertyName = "fname";
            this.fname.HeaderText = "文件名称";
            this.fname.MinimumWidth = 6;
            this.fname.Name = "fname";
            this.fname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ftype
            // 
            this.ftype.DataPropertyName = "ftype";
            this.ftype.HeaderText = "文件类型";
            this.ftype.MinimumWidth = 6;
            this.ftype.Name = "ftype";
            this.ftype.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // fsize
            // 
            this.fsize.DataPropertyName = "fsize";
            this.fsize.HeaderText = "文件大小(单位：KB)";
            this.fsize.MinimumWidth = 6;
            this.fsize.Name = "fsize";
            this.fsize.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // uploadtime
            // 
            this.uploadtime.DataPropertyName = "uploadtime";
            this.uploadtime.HeaderText = "上传时间";
            this.uploadtime.MinimumWidth = 6;
            this.uploadtime.Name = "uploadtime";
            this.uploadtime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ProgressState
            // 
            this.ProgressState.Location = new System.Drawing.Point(12, 416);
            this.ProgressState.Name = "ProgressState";
            this.ProgressState.Size = new System.Drawing.Size(1121, 158);
            this.ProgressState.TabIndex = 17;
            this.ProgressState.Text = "";
            // 
            // fileprogress
            // 
            this.fileprogress.ContainerControl = this;
            this.fileprogress.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(233)))), ((int)(((byte)(0)))));
            this.fileprogress.Location = new System.Drawing.Point(173, 383);
            this.fileprogress.Name = "fileprogress";
            this.fileprogress.Size = new System.Drawing.Size(901, 23);
            this.fileprogress.TabIndex = 16;
            this.fileprogress.Text = "progress1";
            this.fileprogress.ValueRatio = 0.6F;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(189)))), ((int)(((byte)(253)))));
            this.label1.Location = new System.Drawing.Point(499, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "云端文件列表";
            // 
            // uploadDragger3
            // 
            this.uploadDragger3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uploadDragger3.Location = new System.Drawing.Point(640, 580);
            this.uploadDragger3.Name = "uploadDragger3";
            this.uploadDragger3.Size = new System.Drawing.Size(192, 158);
            this.uploadDragger3.TabIndex = 12;
            this.uploadDragger3.Text = "下载文件";
            this.uploadDragger3.Click += new System.EventHandler(this.uploadDragger3_Click);
            // 
            // uploadDragger2
            // 
            this.uploadDragger2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uploadDragger2.Location = new System.Drawing.Point(937, 580);
            this.uploadDragger2.Name = "uploadDragger2";
            this.uploadDragger2.Size = new System.Drawing.Size(184, 158);
            this.uploadDragger2.TabIndex = 13;
            this.uploadDragger2.Text = "删除文件";
            this.uploadDragger2.Click += new System.EventHandler(this.uploadDragger2_Click);
            // 
            // uploadDragger1
            // 
            this.uploadDragger1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uploadDragger1.Location = new System.Drawing.Point(39, 580);
            this.uploadDragger1.Name = "uploadDragger1";
            this.uploadDragger1.Size = new System.Drawing.Size(190, 158);
            this.uploadDragger1.TabIndex = 11;
            this.uploadDragger1.Text = "上传文件";
            this.uploadDragger1.Click += new System.EventHandler(this.uploadDragger1_Click_1);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(63)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(12, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 27);
            this.label2.TabIndex = 15;
            this.label2.Text = "文件处理进度：";
            // 
            // State
            // 
            this.State.Location = new System.Drawing.Point(1080, 383);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(35, 23);
            this.State.TabIndex = 19;
            this.State.Text = "iconState1";
            // 
            // pagelabel
            // 
            this.pagelabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pagelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.pagelabel.Location = new System.Drawing.Point(458, 309);
            this.pagelabel.Name = "pagelabel";
            this.pagelabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pagelabel.ShadowColor = System.Drawing.SystemColors.WindowText;
            this.pagelabel.Size = new System.Drawing.Size(300, 30);
            this.pagelabel.SuffixColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.pagelabel.TabIndex = 20;
            this.pagelabel.Text = "页码";
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(344, 309);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiButton1.RectPressColor = System.Drawing.Color.Yellow;
            this.uiButton1.Size = new System.Drawing.Size(108, 30);
            this.uiButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton1.TabIndex = 22;
            this.uiButton1.Text = "上一页";
            this.uiButton1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(669, 309);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.RectHoverColor = System.Drawing.Color.Lime;
            this.uiButton2.RectPressColor = System.Drawing.Color.Red;
            this.uiButton2.Size = new System.Drawing.Size(108, 30);
            this.uiButton2.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton2.TabIndex = 23;
            this.uiButton2.Text = "下一页";
            this.uiButton2.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // search
            // 
            this.search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.search.ForeColor = System.Drawing.Color.Silver;
            this.search.Location = new System.Drawing.Point(411, 347);
            this.search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search.MinimumSize = new System.Drawing.Size(1, 16);
            this.search.Name = "search";
            this.search.ShowText = false;
            this.search.Size = new System.Drawing.Size(328, 37);
            this.search.Style = Sunny.UI.UIStyle.Custom;
            this.search.TabIndex = 24;
            this.search.Text = "文档太多？试试点我查找吧~";
            this.search.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.search.Watermark = "";
            this.search.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.search_MouseDown);
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // uploadDragger4
            // 
            this.uploadDragger4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uploadDragger4.Location = new System.Drawing.Point(344, 580);
            this.uploadDragger4.Name = "uploadDragger4";
            this.uploadDragger4.Size = new System.Drawing.Size(187, 158);
            this.uploadDragger4.TabIndex = 25;
            this.uploadDragger4.Text = "打开文件";
            this.uploadDragger4.Click += new System.EventHandler(this.uploadDragger4_Click);
            // 
            // uiButton3
            // 
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.uiButton3.FillColor2 = System.Drawing.Color.MintCream;
            this.uiButton3.FillPressColor = System.Drawing.Color.Red;
            this.uiButton3.FillSelectedColor = System.Drawing.Color.Lime;
            this.uiButton3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton3.Location = new System.Drawing.Point(27, 309);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.uiButton3.RectSelectedColor = System.Drawing.Color.Lime;
            this.uiButton3.Size = new System.Drawing.Size(225, 35);
            this.uiButton3.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton3.TabIndex = 26;
            this.uiButton3.TagString = "";
            this.uiButton3.Text = "查看本地文件下载列表            ";
            this.uiButton3.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton3.Click += new System.EventHandler(this.uiButton3_Click);
            // 
            // FileCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 761);
            this.Controls.Add(this.uiButton3);
            this.Controls.Add(this.uploadDragger4);
            this.Controls.Add(this.search);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.pagelabel);
            this.Controls.Add(this.State);
            this.Controls.Add(this.filelist);
            this.Controls.Add(this.ProgressState);
            this.Controls.Add(this.fileprogress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uploadDragger3);
            this.Controls.Add(this.uploadDragger2);
            this.Controls.Add(this.uploadDragger1);
            this.Controls.Add(this.label2);
            this.Name = "FileCenter";
            this.Text = "文件中心";
            this.Load += new System.EventHandler(this.FileCenter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filelist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Sunny.UI.UIDataGridView filelist;
        private System.Windows.Forms.RichTextBox ProgressState;
        private AntdUI.Progress fileprogress;
        private AntdUI.Label label1;
        private AntdUI.UploadDragger uploadDragger3;
        private AntdUI.UploadDragger uploadDragger2;
        private AntdUI.UploadDragger uploadDragger1;
        private AntdUI.Label label2;
        private AntdUI.IconState State;
        private AntdUI.Label pagelabel;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ftype;
        private System.Windows.Forms.DataGridViewTextBoxColumn fsize;
        private System.Windows.Forms.DataGridViewTextBoxColumn uploadtime;
        private Sunny.UI.UITextBox search;
        private AntdUI.UploadDragger uploadDragger4;
        private Sunny.UI.UIButton uiButton3;
    }
}