namespace Satelliteeducationsystem.teacher
{
    partial class classroom
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
            this.classroomlist = new Sunny.UI.UIDataGridView();
            this.button1 = new AntdUI.Button();
            this.button2 = new AntdUI.Button();
            this.crid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.classroomlist)).BeginInit();
            this.SuspendLayout();
            // 
            // classroomlist
            // 
            this.classroomlist.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.classroomlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.classroomlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.classroomlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.classroomlist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.classroomlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classroomlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.classroomlist.ColumnHeadersHeight = 32;
            this.classroomlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.classroomlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.crid,
            this.roomnumber,
            this.state});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.classroomlist.DefaultCellStyle = dataGridViewCellStyle3;
            this.classroomlist.EnableHeadersVisualStyles = false;
            this.classroomlist.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.classroomlist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(199)))), ((int)(((byte)(69)))));
            this.classroomlist.Location = new System.Drawing.Point(1, 1);
            this.classroomlist.Name = "classroomlist";
            this.classroomlist.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classroomlist.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.classroomlist.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.classroomlist.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.classroomlist.RowTemplate.Height = 27;
            this.classroomlist.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.classroomlist.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.classroomlist.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.classroomlist.SelectedIndex = -1;
            this.classroomlist.Size = new System.Drawing.Size(1127, 534);
            this.classroomlist.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.classroomlist.Style = Sunny.UI.UIStyle.Green;
            this.classroomlist.TabIndex = 0;
            this.classroomlist.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.classroomlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.classroomlist_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(192)))), ((int)(((byte)(254)))));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(255)))), ((int)(((byte)(31)))));
            this.button1.BackHover = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(67)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(40, 541);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(483, 86);
            this.button1.TabIndex = 2;
            this.button1.Text = "完成编辑？点我更新至数据库！";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackActive = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(192)))), ((int)(((byte)(254)))));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(255)))), ((int)(((byte)(31)))));
            this.button2.BackHover = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(67)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(614, 541);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(472, 86);
            this.button2.TabIndex = 3;
            this.button2.Text = "显示空闲教室";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // crid
            // 
            this.crid.DataPropertyName = "crid";
            this.crid.HeaderText = "编号";
            this.crid.MinimumWidth = 6;
            this.crid.Name = "crid";
            // 
            // roomnumber
            // 
            this.roomnumber.DataPropertyName = "roomnumber";
            this.roomnumber.HeaderText = "教室位置";
            this.roomnumber.MinimumWidth = 6;
            this.roomnumber.Name = "roomnumber";
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.HeaderText = "状态";
            this.state.MinimumWidth = 6;
            this.state.Name = "state";
            // 
            // classroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 639);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.classroomlist);
            this.Name = "classroom";
            this.Text = "教室列表";
            this.Load += new System.EventHandler(this.classroom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classroomlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView classroomlist;
        private AntdUI.Button button1;
        private AntdUI.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn crid;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
    }
}