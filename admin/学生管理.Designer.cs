namespace Satelliteeducationsystem.admin
{
    partial class 学生管理
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new AntdUI.Button();
            this.studentlist = new Sunny.UI.UIDataGridView();
            this.sid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sidcard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentlist)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(192)))), ((int)(((byte)(254)))));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(255)))), ((int)(((byte)(31)))));
            this.button1.BackHover = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(67)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(48, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1043, 86);
            this.button1.TabIndex = 6;
            this.button1.Text = "完成编辑？点我更新至数据库！";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // studentlist
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.studentlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.studentlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.studentlist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.studentlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.studentlist.ColumnHeadersHeight = 32;
            this.studentlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.studentlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sid,
            this.sname,
            this.spassword,
            this.sidcard,
            this.sex,
            this.semail,
            this.sphone,
            this.sage,
            this.cid,
            this.state});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(216)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentlist.DefaultCellStyle = dataGridViewCellStyle3;
            this.studentlist.EnableHeadersVisualStyles = false;
            this.studentlist.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.studentlist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(85)))), ((int)(((byte)(193)))));
            this.studentlist.Location = new System.Drawing.Point(1, 6);
            this.studentlist.Name = "studentlist";
            this.studentlist.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentlist.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.studentlist.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(216)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.studentlist.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.studentlist.RowTemplate.Height = 27;
            this.studentlist.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.studentlist.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.studentlist.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.studentlist.SelectedIndex = -1;
            this.studentlist.Size = new System.Drawing.Size(1153, 511);
            this.studentlist.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.studentlist.Style = Sunny.UI.UIStyle.Purple;
            this.studentlist.TabIndex = 5;
            this.studentlist.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // sid
            // 
            this.sid.DataPropertyName = "sid";
            this.sid.HeaderText = "学号";
            this.sid.MinimumWidth = 6;
            this.sid.Name = "sid";
            // 
            // sname
            // 
            this.sname.DataPropertyName = "sname";
            this.sname.HeaderText = "姓名";
            this.sname.MinimumWidth = 6;
            this.sname.Name = "sname";
            // 
            // spassword
            // 
            this.spassword.DataPropertyName = "spassword";
            this.spassword.HeaderText = "密码";
            this.spassword.MinimumWidth = 6;
            this.spassword.Name = "spassword";
            // 
            // sidcard
            // 
            this.sidcard.DataPropertyName = "sidcard";
            this.sidcard.HeaderText = "身份证号";
            this.sidcard.MinimumWidth = 6;
            this.sidcard.Name = "sidcard";
            // 
            // sex
            // 
            this.sex.DataPropertyName = "sex";
            this.sex.HeaderText = "性别";
            this.sex.MinimumWidth = 6;
            this.sex.Name = "sex";
            // 
            // semail
            // 
            this.semail.DataPropertyName = "semail";
            this.semail.HeaderText = "电子邮箱";
            this.semail.MinimumWidth = 6;
            this.semail.Name = "semail";
            // 
            // sphone
            // 
            this.sphone.DataPropertyName = "sphone";
            this.sphone.HeaderText = "手机号";
            this.sphone.MinimumWidth = 6;
            this.sphone.Name = "sphone";
            // 
            // sage
            // 
            this.sage.DataPropertyName = "sage";
            this.sage.HeaderText = "年龄";
            this.sage.MinimumWidth = 6;
            this.sage.Name = "sage";
            // 
            // cid
            // 
            this.cid.DataPropertyName = "cid";
            this.cid.HeaderText = "班级编号";
            this.cid.MinimumWidth = 6;
            this.cid.Name = "cid";
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.HeaderText = "状态";
            this.state.MinimumWidth = 6;
            this.state.Name = "state";
            // 
            // 学生管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 614);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.studentlist);
            this.Name = "学生管理";
            this.Text = "学生管理";
            this.Load += new System.EventHandler(this.学生管理_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AntdUI.Button button1;
        private Sunny.UI.UIDataGridView studentlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn sid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sname;
        private System.Windows.Forms.DataGridViewTextBoxColumn spassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidcard;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn semail;
        private System.Windows.Forms.DataGridViewTextBoxColumn sphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn sage;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
    }
}