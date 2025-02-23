using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using Sunny.UI.Win32;

namespace Satelliteeducationsystem.student
{
    public partial class homework : Form
    {
        private Sunny.UI.UIButton uiButton20;
        private Sunny.UI.UILabel uiLabel25;
        private string sid;
        private string cid;
        private DataTable dt;
        public homework(string cid,string sid)
        {
            #region 表格样式处理
            InitializeComponent();
            b1.Visible = false;
            b2.Visible = false;
            b3.Visible = false;
            b4.Visible = false;
            b5.Visible = false;
            b6.Visible = false;
            b7.Visible = false;
            b8.Visible = false;
            b9.Visible = false;
            b10.Visible = false;
            b11.Visible = false;
            b12.Visible = false;
            b13.Visible = false;
            b14.Visible = false;
            b15.Visible = false;
            b16.Visible = false;
            b17.Visible = false;
            b18.Visible = false;
            b19.Visible = false;
            b20.Visible = false;

            l1.Visible = false;
            l2.Visible = false;
            l3.Visible = false;
            l4.Visible = false;
            l5.Visible = false;
            l6.Visible = false;
            l7.Visible = false;
            l8.Visible = false;
            l9.Visible = false;
            l10.Visible = false;
            l11.Visible = false;
            l12.Visible = false;
            l13.Visible = false;
            l14.Visible = false;
            l15.Visible = false;
            l16.Visible = false;
            l17.Visible = false;
            l18.Visible = false;
            l19.Visible = false;
            l20.Visible = false;

            t1.Visible = false;
            t2.Visible = false;
            t3.Visible = false;
            t4.Visible = false;
            t5.Visible = false;
            t6.Visible = false;
            t7.Visible = false;
            t8.Visible = false;
            t9.Visible = false;
            t10.Visible = false;
            t11.Visible = false;
            t12.Visible = false;
            t13.Visible = false;
            t14.Visible = false;
            t15.Visible = false;
            t16.Visible = false;
            t17.Visible = false;
            t18.Visible = false;
            t19.Visible = false;
            t20.Visible = false;

            bz1.Visible = false;
            bz2.Visible = false;
            bz3.Visible = false;
            bz4.Visible = false;
            bz5.Visible = false;
            bz6.Visible = false;
            bz7.Visible = false;
            bz8.Visible = false;
            bz9.Visible = false;
            bz10.Visible = false;
            bz11.Visible = false;
            bz12.Visible = false;
            bz13.Visible = false;
            bz14.Visible = false;
            bz15.Visible = false;
            bz16.Visible = false;
            bz17.Visible = false;
            bz18.Visible = false;
            bz19.Visible = false;
            bz20.Visible = false;
             
            h1.Visible = false;
            h2.Visible = false;
            h3.Visible = false;
            h4.Visible = false;
            h5.Visible = false;
            h6.Visible = false;
            h7.Visible = false;
            h8.Visible = false;
            h9.Visible = false;
            h10.Visible = false;
            h11.Visible = false;
            h12.Visible = false;
            h13.Visible = false;
            h14.Visible = false;
            h15.Visible = false;
            h16.Visible = false;
            h17.Visible = false;
            h18.Visible = false;
            h19.Visible = false;
            h20.Visible = false;
            #endregion
            this.cid = cid;
            this.sid = sid;
            DataSet ds = Method.query_homework(cid);
            dt = ds.Tables["homework"];
        }
        public homework()
        {
            InitializeComponent();

        }

        private void homework_Load(object sender, EventArgs e)
        {

            //自主绘制测试（放弃）
            //uiButton20=new Sunny.UI.UIButton();
            //uiLabel25=new Sunny.UI.UILabel();
            //this.uiTableLayoutPanel1.Controls.Add(this.uiLabel25, 0,20);
            //uiLabel25.Anchor= AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            //uiLabel25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            //uiLabel25.Text = "20";
            //uiLabel25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            
            #region 数据库列表读取（最笨的办法）
            if (dt.Rows.Count==1)
            if (dt.Rows[0] != null)
            {
                    
              h1.Text = dt.Rows[0][0].ToString();
               t1.Text = dt.Rows [0][1].ToString();
                bz1.Text = dt.Rows [0][2].ToString();
                h1.Visible=true;
                t1.Visible=true;
                 bz1.Visible=true;
                    b1.Visible=true;
                    l1.Visible = true;
                }
            if (dt.Rows.Count == 2)
                if (dt.Rows[1] != null)
            {
                    h1.Text = dt.Rows[0][0].ToString();
                    t1.Text = dt.Rows[0][1].ToString();
                    bz1.Text = dt.Rows[0][2].ToString();
                    h2.Text = dt.Rows[1][0].ToString();
                    t2.Text = dt.Rows[1][1].ToString();
                    bz2.Text = dt.Rows[1][2].ToString();
                    h2.Visible = true;
                    t2.Visible = true;
                    bz2.Visible = true;
                    b2.Visible = true;
                    h1.Visible = true;
                    t1.Visible = true;
                    bz1.Visible = true;
                    b1.Visible = true;
                    l1.Visible = true;
                    l2.Visible = true;
                }
            if (dt.Rows.Count == 3)
                if (dt.Rows[2] != null)
            {
                    h1.Text = dt.Rows[0][0].ToString();
                    t1.Text = dt.Rows[0][1].ToString();
                    bz1.Text = dt.Rows[0][2].ToString();
                    h2.Text = dt.Rows[1][0].ToString();
                    t2.Text = dt.Rows[1][1].ToString();
                    bz2.Text = dt.Rows[1][2].ToString();
                    h3.Text = dt.Rows[2][0].ToString();
                    t3.Text = dt.Rows[2][1].ToString();
                    bz3.Text = dt.Rows[2][2].ToString();
                    h3.Visible = true;
                    t3.Visible = true;
                    l3.Visible = true;
                    bz3.Visible = true;
                    b3.Visible = true;
                    h2.Visible = true;
                    t2.Visible = true;
                    bz2.Visible = true;
                    b2.Visible = true;
                    h1.Visible = true;
                    t1.Visible = true;
                    bz1.Visible = true;
                    b1.Visible = true;
                    l1.Visible = true;
                    l2.Visible = true;
                }
            if (dt.Rows.Count == 4)
                if (dt.Rows[3] != null)
            {
                    h1.Text = dt.Rows[0][0].ToString();
                    t1.Text = dt.Rows[0][1].ToString();
                    bz1.Text = dt.Rows[0][2].ToString();
                    h2.Text = dt.Rows[1][0].ToString();
                    t2.Text = dt.Rows[1][1].ToString();
                    bz2.Text = dt.Rows[1][2].ToString();
                    h3.Text = dt.Rows[2][0].ToString();
                    t3.Text = dt.Rows[2][1].ToString();
                    bz3.Text = dt.Rows[2][2].ToString();
                    h4.Text = dt.Rows[3][0].ToString();
                    t4.Text = dt.Rows[3][1].ToString();
                    bz4.Text = dt.Rows[3][2].ToString();
                    h4.Visible = true;
                    t4.Visible = true;
                    bz4.Visible = true;
                    b4.Visible = true;
                    l4.Visible = true;
                    h3.Visible = true;
                    t3.Visible = true;
                    l3.Visible = true;
                    bz3.Visible = true;
                    b3.Visible = true;
                    h2.Visible = true;
                    t2.Visible = true;
                    bz2.Visible = true;
                    b2.Visible = true;
                    h1.Visible = true;
                    t1.Visible = true;
                    bz1.Visible = true;
                    b1.Visible = true;
                    l1.Visible = true;
                    l2.Visible = true;
                }
            if (dt.Rows.Count == 5)
                if (dt.Rows[4] != null)
            {
                    h1.Text = dt.Rows[0][0].ToString();
                    t1.Text = dt.Rows[0][1].ToString();
                    bz1.Text = dt.Rows[0][2].ToString();
                    h2.Text = dt.Rows[1][0].ToString();
                    t2.Text = dt.Rows[1][1].ToString();
                    bz2.Text = dt.Rows[1][2].ToString();
                    h3.Text = dt.Rows[2][0].ToString();
                    t3.Text = dt.Rows[2][1].ToString();
                    bz3.Text = dt.Rows[2][2].ToString();
                    h4.Text = dt.Rows[3][0].ToString();
                    t4.Text = dt.Rows[3][1].ToString();
                    bz4.Text = dt.Rows[3][2].ToString();
                    h5.Text = dt.Rows[4][0].ToString();
                    t5.Text = dt.Rows[4][1].ToString();
                    bz5.Text = dt.Rows[4][2].ToString();
                    h5.Visible = true;
                    t5.Visible = true;
                    bz5.Visible = true;
                    b5.Visible = true;
                    h4.Visible = true;
                    t4.Visible = true;
                    bz4.Visible = true;
                    b4.Visible = true;
                    l4.Visible = true;
                    h3.Visible = true;
                    t3.Visible = true;
                    l3.Visible = true;
                    bz3.Visible = true;
                    b3.Visible = true;
                    h2.Visible = true;
                    t2.Visible = true;
                    bz2.Visible = true;
                    b2.Visible = true;
                    h1.Visible = true;
                    t1.Visible = true;
                    bz1.Visible = true;
                    b1.Visible = true;
                    l1.Visible = true;
                    l5.Visible = true;
                    l2.Visible = true;
                }
            if (dt.Rows.Count == 6)
                if (dt.Rows[5] != null)
            {
                    h1.Text = dt.Rows[0][0].ToString();
                    t1.Text = dt.Rows[0][1].ToString();
                    bz1.Text = dt.Rows[0][2].ToString();
                    h2.Text = dt.Rows[1][0].ToString();
                    t2.Text = dt.Rows[1][1].ToString();
                    bz2.Text = dt.Rows[1][2].ToString();
                    h3.Text = dt.Rows[2][0].ToString();
                    t3.Text = dt.Rows[2][1].ToString();
                    bz3.Text = dt.Rows[2][2].ToString();
                    h4.Text = dt.Rows[3][0].ToString();
                    t4.Text = dt.Rows[3][1].ToString();
                    bz4.Text = dt.Rows[3][2].ToString();
                    h5.Text = dt.Rows[4][0].ToString();
                    t5.Text = dt.Rows[4][1].ToString();
                    bz5.Text = dt.Rows[4][2].ToString();
                    h6.Text = dt.Rows[5][0].ToString();
                    t6.Text = dt.Rows[5][1].ToString();
                    bz6.Text = dt.Rows[5][2].ToString();
                    h6.Visible = true;
                    t6.Visible = true;
                    bz6.Visible = true;
                    b6.Visible = true;
                    h5.Visible = true;
                    t5.Visible = true;
                    bz5.Visible = true;
                    b5.Visible = true;
                    h4.Visible = true;
                    t4.Visible = true;
                    bz4.Visible = true;
                    b4.Visible = true;
                    l4.Visible = true;
                    h3.Visible = true;
                    t3.Visible = true;
                    l3.Visible = true;
                    bz3.Visible = true;
                    b3.Visible = true;
                    h2.Visible = true;
                    t2.Visible = true;
                    bz2.Visible = true;
                    b2.Visible = true;
                    h1.Visible = true;
                    t1.Visible = true;
                    bz1.Visible = true;
                    l6.Visible = true;
                    b1.Visible = true;
                    l1.Visible = true;
                    l5.Visible = true;
                    l2.Visible = true;
                }
            if (dt.Rows.Count == 7)
                if (dt.Rows[6] != null)
            {
                    h1.Text = dt.Rows[0][0].ToString();
                    t1.Text = dt.Rows[0][1].ToString();
                    bz1.Text = dt.Rows[0][2].ToString();
                    h2.Text = dt.Rows[1][0].ToString();
                    t2.Text = dt.Rows[1][1].ToString();
                    bz2.Text = dt.Rows[1][2].ToString();
                    h3.Text = dt.Rows[2][0].ToString();
                    t3.Text = dt.Rows[2][1].ToString();
                    bz3.Text = dt.Rows[2][2].ToString();
                    h4.Text = dt.Rows[3][0].ToString();
                    t4.Text = dt.Rows[3][1].ToString();
                    bz4.Text = dt.Rows[3][2].ToString();
                    h5.Text = dt.Rows[4][0].ToString();
                    t5.Text = dt.Rows[4][1].ToString();
                    bz5.Text = dt.Rows[4][2].ToString();
                    h6.Text = dt.Rows[5][0].ToString();
                    t6.Text = dt.Rows[5][1].ToString();
                    bz6.Text = dt.Rows[5][2].ToString();
                    h7.Text = dt.Rows[6][0].ToString();
                    t7.Text = dt.Rows[6][1].ToString();
                    bz7.Text = dt.Rows[6][2].ToString();
                    h7.Visible = true;
                    t7.Visible = true;
                    bz7.Visible = true;
                    b7.Visible = true;
                    h6.Visible = true;
                    l7.Visible = true;
                    t6.Visible = true;
                    bz6.Visible = true;
                    b6.Visible = true;
                    h5.Visible = true;
                    t5.Visible = true;
                    bz5.Visible = true;
                    b5.Visible = true;
                    h4.Visible = true;
                    t4.Visible = true;
                    bz4.Visible = true;
                    b4.Visible = true;
                    l4.Visible = true;
                    h3.Visible = true;
                    t3.Visible = true;
                    l3.Visible = true;
                    bz3.Visible = true;
                    b3.Visible = true;
                    h2.Visible = true;
                    t2.Visible = true;
                    bz2.Visible = true;
                    b2.Visible = true;
                    h1.Visible = true;
                    t1.Visible = true;
                    bz1.Visible = true;
                    l6.Visible = true;
                    b1.Visible = true;
                    l1.Visible = true;
                    l5.Visible = true;
                    l2.Visible = true;
                }
            if (dt.Rows.Count == 8)
                if (dt.Rows[7] != null)
            {
                    h1.Text = dt.Rows[0][0].ToString();
                    t1.Text = dt.Rows[0][1].ToString();
                    bz1.Text = dt.Rows[0][2].ToString();
                    h2.Text = dt.Rows[1][0].ToString();
                    t2.Text = dt.Rows[1][1].ToString();
                    bz2.Text = dt.Rows[1][2].ToString();
                    h3.Text = dt.Rows[2][0].ToString();
                    t3.Text = dt.Rows[2][1].ToString();
                    bz3.Text = dt.Rows[2][2].ToString();
                    h4.Text = dt.Rows[3][0].ToString();
                    t4.Text = dt.Rows[3][1].ToString();
                    bz4.Text = dt.Rows[3][2].ToString();
                    h5.Text = dt.Rows[4][0].ToString();
                    t5.Text = dt.Rows[4][1].ToString();
                    bz5.Text = dt.Rows[4][2].ToString();
                    h6.Text = dt.Rows[5][0].ToString();
                    t6.Text = dt.Rows[5][1].ToString();
                    bz6.Text = dt.Rows[5][2].ToString();
                    h7.Text = dt.Rows[6][0].ToString();
                    t7.Text = dt.Rows[6][1].ToString();
                    bz7.Text = dt.Rows[6][2].ToString();
                    h8.Text = dt.Rows[7][0].ToString();
                    t8.Text = dt.Rows[7][1].ToString();
                    bz8.Text = dt.Rows[7][2].ToString();
                    h8.Visible = true;
                    t8.Visible = true;
                    bz8.Visible = true;
                    b8.Visible = true;
                    h7.Visible = true;
                    t7.Visible = true;
                    bz7.Visible = true;
                    l8.Visible = true;
                    b7.Visible = true;
                    h6.Visible = true;
                    l7.Visible = true;
                    t6.Visible = true;
                    bz6.Visible = true;
                    b6.Visible = true;
                    h5.Visible = true;
                    t5.Visible = true;
                    bz5.Visible = true;
                    b5.Visible = true;
                    h4.Visible = true;
                    t4.Visible = true;
                    bz4.Visible = true;
                    b4.Visible = true;
                    l4.Visible = true;
                    h3.Visible = true;
                    t3.Visible = true;
                    l3.Visible = true;
                    bz3.Visible = true;
                    b3.Visible = true;
                    h2.Visible = true;
                    t2.Visible = true;
                    bz2.Visible = true;
                    b2.Visible = true;
                    h1.Visible = true;
                    t1.Visible = true;
                    bz1.Visible = true;
                    l6.Visible = true;
                    b1.Visible = true;
                    l1.Visible = true;
                    l5.Visible = true;
                    l2.Visible = true;
                }
            if (dt.Rows.Count == 9)
                if (dt.Rows[8] != null)
            {
                    h1.Text = dt.Rows[0][0].ToString();
                    t1.Text = dt.Rows[0][1].ToString();
                    bz1.Text = dt.Rows[0][2].ToString();
                    h2.Text = dt.Rows[1][0].ToString();
                    t2.Text = dt.Rows[1][1].ToString();
                    bz2.Text = dt.Rows[1][2].ToString();
                    h3.Text = dt.Rows[2][0].ToString();
                    t3.Text = dt.Rows[2][1].ToString();
                    bz3.Text = dt.Rows[2][2].ToString();
                    h4.Text = dt.Rows[3][0].ToString();
                    t4.Text = dt.Rows[3][1].ToString();
                    bz4.Text = dt.Rows[3][2].ToString();
                    h5.Text = dt.Rows[4][0].ToString();
                    t5.Text = dt.Rows[4][1].ToString();
                    bz5.Text = dt.Rows[4][2].ToString();
                    h6.Text = dt.Rows[5][0].ToString();
                    t6.Text = dt.Rows[5][1].ToString();
                    bz6.Text = dt.Rows[5][2].ToString();
                    h7.Text = dt.Rows[6][0].ToString();
                    t7.Text = dt.Rows[6][1].ToString();
                    bz7.Text = dt.Rows[6][2].ToString();
                    h8.Text = dt.Rows[7][0].ToString();
                    t8.Text = dt.Rows[7][1].ToString();
                    bz8.Text = dt.Rows[7][2].ToString();
                    h9.Text = dt.Rows[8][0].ToString();
                    t9.Text = dt.Rows[8][1].ToString();
                    bz9.Text = dt.Rows[8][2].ToString();
                    h9.Visible = true;
                    t9.Visible = true;
                    bz9.Visible = true;
                    b9.Visible = true;
                    h8.Visible = true;
                    t8.Visible = true;
                    bz8.Visible = true;
                    b8.Visible = true;
                    l9.Visible = true;
                    h7.Visible = true;
                    t7.Visible = true;
                    bz7.Visible = true;
                    l8.Visible = true;
                    b7.Visible = true;
                    h6.Visible = true;
                    l7.Visible = true;
                    t6.Visible = true;
                    bz6.Visible = true;
                    b6.Visible = true;
                    h5.Visible = true;
                    t5.Visible = true;
                    bz5.Visible = true;
                    b5.Visible = true;
                    h4.Visible = true;
                    t4.Visible = true;
                    bz4.Visible = true;
                    b4.Visible = true;
                    l4.Visible = true;
                    h3.Visible = true;
                    t3.Visible = true;
                    l3.Visible = true;
                    bz3.Visible = true;
                    b3.Visible = true;
                    h2.Visible = true;
                    t2.Visible = true;
                    bz2.Visible = true;
                    b2.Visible = true;
                    h1.Visible = true;
                    t1.Visible = true;
                    bz1.Visible = true;
                    l6.Visible = true;
                    b1.Visible = true;
                    l1.Visible = true;
                    l5.Visible = true;
                    l2.Visible = true;
                }
            if (dt.Rows.Count == 10)
                if (dt.Rows[9] != null)
            {
                    h1.Text = dt.Rows[0][0].ToString();
                    t1.Text = dt.Rows[0][1].ToString();
                    bz1.Text = dt.Rows[0][2].ToString();
                    h2.Text = dt.Rows[1][0].ToString();
                    t2.Text = dt.Rows[1][1].ToString();
                    bz2.Text = dt.Rows[1][2].ToString();
                    h3.Text = dt.Rows[2][0].ToString();
                    t3.Text = dt.Rows[2][1].ToString();
                    bz3.Text = dt.Rows[2][2].ToString();
                    h4.Text = dt.Rows[3][0].ToString();
                    t4.Text = dt.Rows[3][1].ToString();
                    bz4.Text = dt.Rows[3][2].ToString();
                    h5.Text = dt.Rows[4][0].ToString();
                    t5.Text = dt.Rows[4][1].ToString();
                    bz5.Text = dt.Rows[4][2].ToString();
                    h6.Text = dt.Rows[5][0].ToString();
                    t6.Text = dt.Rows[5][1].ToString();
                    bz6.Text = dt.Rows[5][2].ToString();
                    h7.Text = dt.Rows[6][0].ToString();
                    t7.Text = dt.Rows[6][1].ToString();
                    bz7.Text = dt.Rows[6][2].ToString();
                    h8.Text = dt.Rows[7][0].ToString();
                    t8.Text = dt.Rows[7][1].ToString();
                    bz8.Text = dt.Rows[7][2].ToString();
                    h9.Text = dt.Rows[8][0].ToString();
                    t9.Text = dt.Rows[8][1].ToString();
                    bz9.Text = dt.Rows[8][2].ToString();
                    h10.Text = dt.Rows[9][0].ToString();
                    t10.Text = dt.Rows[9][1].ToString();
                    bz10.Text = dt.Rows[9][2].ToString();
                    h10.Visible = true;
                    t10.Visible = true;
                    bz10.Visible = true;
                    b10.Visible = true;
                    h9.Visible = true;
                    t9.Visible = true;
                    bz9.Visible = true;
                    b9.Visible = true;
                    l10.Visible = true;
                    h8.Visible = true;
                    t8.Visible = true;
                    bz8.Visible = true;
                    b8.Visible = true;
                    l9.Visible = true;
                    h7.Visible = true;
                    t7.Visible = true;
                    bz7.Visible = true;
                    l8.Visible = true;
                    b7.Visible = true;
                    h6.Visible = true;
                    l7.Visible = true;
                    t6.Visible = true;
                    bz6.Visible = true;
                    b6.Visible = true;
                    h5.Visible = true;
                    t5.Visible = true;
                    bz5.Visible = true;
                    b5.Visible = true;
                    h4.Visible = true;
                    t4.Visible = true;
                    bz4.Visible = true;
                    b4.Visible = true;
                    l4.Visible = true;
                    h3.Visible = true;
                    t3.Visible = true;
                    l3.Visible = true;
                    bz3.Visible = true;
                    b3.Visible = true;
                    h2.Visible = true;
                    t2.Visible = true;
                    bz2.Visible = true;
                    b2.Visible = true;
                    h1.Visible = true;
                    t1.Visible = true;
                    bz1.Visible = true;
                    l6.Visible = true;
                    b1.Visible = true;
                    l1.Visible = true;
                    l5.Visible = true;
                    l2.Visible = true;
                }
            if (dt.Rows.Count == 11)
                if (dt.Rows[10] != null)
            {
                    h1.Text = dt.Rows[0][0].ToString();
                    t1.Text = dt.Rows[0][1].ToString();
                    bz1.Text = dt.Rows[0][2].ToString();
                    h2.Text = dt.Rows[1][0].ToString();
                    t2.Text = dt.Rows[1][1].ToString();
                    bz2.Text = dt.Rows[1][2].ToString();
                    h3.Text = dt.Rows[2][0].ToString();
                    t3.Text = dt.Rows[2][1].ToString();
                    bz3.Text = dt.Rows[2][2].ToString();
                    h4.Text = dt.Rows[3][0].ToString();
                    t4.Text = dt.Rows[3][1].ToString();
                    bz4.Text = dt.Rows[3][2].ToString();
                    h5.Text = dt.Rows[4][0].ToString();
                    t5.Text = dt.Rows[4][1].ToString();
                    bz5.Text = dt.Rows[4][2].ToString();
                    h6.Text = dt.Rows[5][0].ToString();
                    t6.Text = dt.Rows[5][1].ToString();
                    bz6.Text = dt.Rows[5][2].ToString();
                    h7.Text = dt.Rows[6][0].ToString();
                    t7.Text = dt.Rows[6][1].ToString();
                    bz7.Text = dt.Rows[6][2].ToString();
                    h8.Text = dt.Rows[7][0].ToString();
                    t8.Text = dt.Rows[7][1].ToString();
                    bz8.Text = dt.Rows[7][2].ToString();
                    h9.Text = dt.Rows[8][0].ToString();
                    t9.Text = dt.Rows[8][1].ToString();
                    bz9.Text = dt.Rows[8][2].ToString();
                    h10.Text = dt.Rows[9][0].ToString();
                    t10.Text = dt.Rows[9][1].ToString();
                    bz10.Text = dt.Rows[9][2].ToString();
                    h11.Text = dt.Rows[10][0].ToString();
                    t11.Text = dt.Rows[10][1].ToString();
                    bz11.Text = dt.Rows[10][2].ToString();
                    h11.Visible = true;
                    t11.Visible = true;
                    bz11.Visible = true;
                    h10.Visible = true;
                    t10.Visible = true;
                    bz10.Visible = true;
                    b10.Visible = true;
                    h9.Visible = true;
                    t9.Visible = true;
                    l11.Visible = true;
                    bz9.Visible = true;
                    b9.Visible = true;
                    l10.Visible = true;
                    h8.Visible = true;
                    t8.Visible = true;
                    bz8.Visible = true;
                    b8.Visible = true;
                    l9.Visible = true;
                    h7.Visible = true;
                    t7.Visible = true;
                    bz7.Visible = true;
                    l8.Visible = true;
                    b7.Visible = true;
                    h6.Visible = true;
                    l7.Visible = true;
                    t6.Visible = true;
                    bz6.Visible = true;
                    b6.Visible = true;
                    h5.Visible = true;
                    t5.Visible = true;
                    bz5.Visible = true;
                    b5.Visible = true;
                    h4.Visible = true;
                    t4.Visible = true;
                    bz4.Visible = true;
                    b4.Visible = true;
                    l4.Visible = true;
                    h3.Visible = true;
                    t3.Visible = true;
                    l3.Visible = true;
                    bz3.Visible = true;
                    b3.Visible = true;
                    h2.Visible = true;
                    t2.Visible = true;
                    bz2.Visible = true;
                    b2.Visible = true;
                    h1.Visible = true;
                    t1.Visible = true;
                    bz1.Visible = true;
                    l6.Visible = true;
                    b1.Visible = true;
                    l1.Visible = true;
                    l5.Visible = true;
                    l2.Visible = true;
                    b11.Visible = true;
                }
            if (dt.Rows.Count == 12)
                if (dt.Rows[11] != null)
            {
                    h1.Text = dt.Rows[0][0].ToString();
                    t1.Text = dt.Rows[0][1].ToString();
                    bz1.Text = dt.Rows[0][2].ToString();
                    h2.Text = dt.Rows[1][0].ToString();
                    t2.Text = dt.Rows[1][1].ToString();
                    bz2.Text = dt.Rows[1][2].ToString();
                    h3.Text = dt.Rows[2][0].ToString();
                    t3.Text = dt.Rows[2][1].ToString();
                    bz3.Text = dt.Rows[2][2].ToString();
                    h4.Text = dt.Rows[3][0].ToString();
                    t4.Text = dt.Rows[3][1].ToString();
                    bz4.Text = dt.Rows[3][2].ToString();
                    h5.Text = dt.Rows[4][0].ToString();
                    t5.Text = dt.Rows[4][1].ToString();
                    bz5.Text = dt.Rows[4][2].ToString();
                    h6.Text = dt.Rows[5][0].ToString();
                    t6.Text = dt.Rows[5][1].ToString();
                    bz6.Text = dt.Rows[5][2].ToString();
                    h7.Text = dt.Rows[6][0].ToString();
                    t7.Text = dt.Rows[6][1].ToString();
                    bz7.Text = dt.Rows[6][2].ToString();
                    h8.Text = dt.Rows[7][0].ToString();
                    t8.Text = dt.Rows[7][1].ToString();
                    bz8.Text = dt.Rows[7][2].ToString();
                    h9.Text = dt.Rows[8][0].ToString();
                    t9.Text = dt.Rows[8][1].ToString();
                    bz9.Text = dt.Rows[8][2].ToString();
                    h10.Text = dt.Rows[9][0].ToString();
                    t10.Text = dt.Rows[9][1].ToString();
                    bz10.Text = dt.Rows[9][2].ToString();
                    h11.Text = dt.Rows[10][0].ToString();
                    t11.Text = dt.Rows[10][1].ToString();
                    bz11.Text = dt.Rows[10][2].ToString();
                    h12.Text = dt.Rows[11][0].ToString();
                    t12.Text = dt.Rows[11][1].ToString();
                    bz12.Text = dt.Rows[11][2].ToString();
                    h12.Visible = true;
                    t12.Visible = true;
                    bz12.Visible = true;
                    h11.Visible = true;
                    t11.Visible = true;
                    bz11.Visible = true;
                    h10.Visible = true;
                    l12.Visible = true;
                    t10.Visible = true;
                    bz10.Visible = true;
                    b10.Visible = true;
                    h9.Visible = true;
                    t9.Visible = true;
                    l11.Visible = true;
                    bz9.Visible = true;
                    b9.Visible = true;
                    l10.Visible = true;
                    h8.Visible = true;
                    t8.Visible = true;
                    bz8.Visible = true;
                    b8.Visible = true;
                    l9.Visible = true;
                    h7.Visible = true;
                    t7.Visible = true;
                    bz7.Visible = true;
                    l8.Visible = true;
                    b7.Visible = true;
                    h6.Visible = true;
                    l7.Visible = true;
                    t6.Visible = true;
                    bz6.Visible = true;
                    b6.Visible = true;
                    h5.Visible = true;
                    t5.Visible = true;
                    bz5.Visible = true;
                    b5.Visible = true;
                    h4.Visible = true;
                    t4.Visible = true;
                    bz4.Visible = true;
                    b4.Visible = true;
                    l4.Visible = true;
                    h3.Visible = true;
                    t3.Visible = true;
                    l3.Visible = true;
                    bz3.Visible = true;
                    b3.Visible = true;
                    h2.Visible = true;
                    t2.Visible = true;
                    bz2.Visible = true;
                    b2.Visible = true;
                    h1.Visible = true;
                    t1.Visible = true;
                    bz1.Visible = true;
                    l6.Visible = true;
                    b1.Visible = true;
                    l1.Visible = true;
                    l5.Visible = true;
                    l2.Visible = true;
                    b11.Visible = true;
                    b12.Visible = true;
                }
            if (dt.Rows.Count == 13)
                if (dt.Rows[12] != null)
            {
                    h1.Text = dt.Rows[0][0].ToString();
                    t1.Text = dt.Rows[0][1].ToString();
                    bz1.Text = dt.Rows[0][2].ToString();
                    h2.Text = dt.Rows[1][0].ToString();
                    t2.Text = dt.Rows[1][1].ToString();
                    bz2.Text = dt.Rows[1][2].ToString();
                    h3.Text = dt.Rows[2][0].ToString();
                    t3.Text = dt.Rows[2][1].ToString();
                    bz3.Text = dt.Rows[2][2].ToString();
                    h4.Text = dt.Rows[3][0].ToString();
                    t4.Text = dt.Rows[3][1].ToString();
                    bz4.Text = dt.Rows[3][2].ToString();
                    h5.Text = dt.Rows[4][0].ToString();
                    t5.Text = dt.Rows[4][1].ToString();
                    bz5.Text = dt.Rows[4][2].ToString();
                    h6.Text = dt.Rows[5][0].ToString();
                    t6.Text = dt.Rows[5][1].ToString();
                    bz6.Text = dt.Rows[5][2].ToString();
                    h7.Text = dt.Rows[6][0].ToString();
                    t7.Text = dt.Rows[6][1].ToString();
                    bz7.Text = dt.Rows[6][2].ToString();
                    h8.Text = dt.Rows[7][0].ToString();
                    t8.Text = dt.Rows[7][1].ToString();
                    bz8.Text = dt.Rows[7][2].ToString();
                    h9.Text = dt.Rows[8][0].ToString();
                    t9.Text = dt.Rows[8][1].ToString();
                    bz9.Text = dt.Rows[8][2].ToString();
                    h10.Text = dt.Rows[9][0].ToString();
                    t10.Text = dt.Rows[9][1].ToString();
                    bz10.Text = dt.Rows[9][2].ToString();
                    h11.Text = dt.Rows[10][0].ToString();
                    t11.Text = dt.Rows[10][1].ToString();
                    bz11.Text = dt.Rows[10][2].ToString();
                    h12.Text = dt.Rows[11][0].ToString();
                    t12.Text = dt.Rows[11][1].ToString();
                    bz12.Text = dt.Rows[11][2].ToString();
                    h13.Text = dt.Rows[12][0].ToString();
                    t13.Text = dt.Rows[12][1].ToString();
                    bz13.Text = dt.Rows[12][2].ToString();
                    h13.Visible = true;
                    t13.Visible = true;
                    h12.Visible = true;
                    t12.Visible = true;
                    l13.Visible = true;
                    bz12.Visible = true;
                    h11.Visible = true;
                    t11.Visible = true;
                    bz11.Visible = true;
                    h10.Visible = true;
                    l12.Visible = true;
                    t10.Visible = true;
                    bz10.Visible = true;
                    b10.Visible = true;
                    h9.Visible = true;
                    t9.Visible = true;
                    l11.Visible = true;
                    bz9.Visible = true;
                    b9.Visible = true;
                    l10.Visible = true;
                    h8.Visible = true;
                    t8.Visible = true;
                    bz8.Visible = true;
                    b8.Visible = true;
                    l9.Visible = true;
                    h7.Visible = true;
                    t7.Visible = true;
                    bz7.Visible = true;
                    l8.Visible = true;
                    b7.Visible = true;
                    h6.Visible = true;
                    l7.Visible = true;
                    t6.Visible = true;
                    bz6.Visible = true;
                    b6.Visible = true;
                    h5.Visible = true;
                    t5.Visible = true;
                    bz5.Visible = true;
                    b5.Visible = true;
                    h4.Visible = true;
                    t4.Visible = true;
                    bz4.Visible = true;
                    b4.Visible = true;
                    l4.Visible = true;
                    h3.Visible = true;
                    t3.Visible = true;
                    l3.Visible = true;
                    bz3.Visible = true;
                    b3.Visible = true;
                    h2.Visible = true;
                    t2.Visible = true;
                    bz2.Visible = true;
                    b2.Visible = true;
                    h1.Visible = true;
                    t1.Visible = true;
                    bz1.Visible = true;
                    l6.Visible = true;
                    b1.Visible = true;
                    l1.Visible = true;
                    l5.Visible = true;
                    l2.Visible = true;
                    b11.Visible = true;
                    b12.Visible = true;
                    bz13.Visible = true;
                    b13.Visible = true;
                }
            if (dt.Rows.Count == 14)
                if (dt.Rows[13] != null)
            {
                    h1.Text = dt.Rows[0][0].ToString();
                    t1.Text = dt.Rows[0][1].ToString();
                    bz1.Text = dt.Rows[0][2].ToString();
                    h2.Text = dt.Rows[1][0].ToString();
                    t2.Text = dt.Rows[1][1].ToString();
                    bz2.Text = dt.Rows[1][2].ToString();
                    h3.Text = dt.Rows[2][0].ToString();
                    t3.Text = dt.Rows[2][1].ToString();
                    bz3.Text = dt.Rows[2][2].ToString();
                    h4.Text = dt.Rows[3][0].ToString();
                    t4.Text = dt.Rows[3][1].ToString();
                    bz4.Text = dt.Rows[3][2].ToString();
                    h5.Text = dt.Rows[4][0].ToString();
                    t5.Text = dt.Rows[4][1].ToString();
                    bz5.Text = dt.Rows[4][2].ToString();
                    h6.Text = dt.Rows[5][0].ToString();
                    t6.Text = dt.Rows[5][1].ToString();
                    bz6.Text = dt.Rows[5][2].ToString();
                    h7.Text = dt.Rows[6][0].ToString();
                    t7.Text = dt.Rows[6][1].ToString();
                    bz7.Text = dt.Rows[6][2].ToString();
                    h8.Text = dt.Rows[7][0].ToString();
                    t8.Text = dt.Rows[7][1].ToString();
                    bz8.Text = dt.Rows[7][2].ToString();
                    h9.Text = dt.Rows[8][0].ToString();
                    t9.Text = dt.Rows[8][1].ToString();
                    bz9.Text = dt.Rows[8][2].ToString();
                    h10.Text = dt.Rows[9][0].ToString();
                    t10.Text = dt.Rows[9][1].ToString();
                    bz10.Text = dt.Rows[9][2].ToString();
                    h11.Text = dt.Rows[10][0].ToString();
                    t11.Text = dt.Rows[10][1].ToString();
                    bz11.Text = dt.Rows[10][2].ToString();
                    h12.Text = dt.Rows[11][0].ToString();
                    t12.Text = dt.Rows[11][1].ToString();
                    bz12.Text = dt.Rows[11][2].ToString();
                    h13.Text = dt.Rows[12][0].ToString();
                    t13.Text = dt.Rows[12][1].ToString();
                    bz13.Text = dt.Rows[12][2].ToString();
                    h14.Text = dt.Rows[13][0].ToString();
                    t14.Text = dt.Rows[13][1].ToString();
                    bz14.Text = dt.Rows[13][2].ToString();
                    h14.Visible = true;
                    t14.Visible = true;
                    bz14.Visible = true;
                    b14.Visible = true;
                    h13.Visible = true;
                    t13.Visible = true;
                    h12.Visible = true;
                    t12.Visible = true;
                    l14.Visible = true;
                    l13.Visible = true;
                    bz12.Visible = true;
                    h11.Visible = true;
                    t11.Visible = true;
                    bz11.Visible = true;
                    h10.Visible = true;
                    l12.Visible = true;
                    t10.Visible = true;
                    bz10.Visible = true;
                    b10.Visible = true;
                    h9.Visible = true;
                    t9.Visible = true;
                    l11.Visible = true;
                    bz9.Visible = true;
                    b9.Visible = true;
                    l10.Visible = true;
                    h8.Visible = true;
                    t8.Visible = true;
                    bz8.Visible = true;
                    b8.Visible = true;
                    l9.Visible = true;
                    h7.Visible = true;
                    t7.Visible = true;
                    bz7.Visible = true;
                    l8.Visible = true;
                    b7.Visible = true;
                    h6.Visible = true;
                    l7.Visible = true;
                    t6.Visible = true;
                    bz6.Visible = true;
                    b6.Visible = true;
                    h5.Visible = true;
                    t5.Visible = true;
                    bz5.Visible = true;
                    b5.Visible = true;
                    h4.Visible = true;
                    t4.Visible = true;
                    bz4.Visible = true;
                    b4.Visible = true;
                    l4.Visible = true;
                    h3.Visible = true;
                    t3.Visible = true;
                    l3.Visible = true;
                    bz3.Visible = true;
                    b3.Visible = true;
                    h2.Visible = true;
                    t2.Visible = true;
                    bz2.Visible = true;
                    b2.Visible = true;
                    h1.Visible = true;
                    t1.Visible = true;
                    bz1.Visible = true;
                    l6.Visible = true;
                    b1.Visible = true;
                    l1.Visible = true;
                    l5.Visible = true;
                    l2.Visible = true;
                    b11.Visible = true;
                    b12.Visible = true;
                    bz13.Visible = true;
                    b13.Visible = true;
                }
            if (dt.Rows.Count == 15)
                if (dt.Rows[14] != null)
            {
                    h1.Text = dt.Rows[0][0].ToString();
                    t1.Text = dt.Rows[0][1].ToString();
                    bz1.Text = dt.Rows[0][2].ToString();
                    h2.Text = dt.Rows[1][0].ToString();
                    t2.Text = dt.Rows[1][1].ToString();
                    bz2.Text = dt.Rows[1][2].ToString();
                    h3.Text = dt.Rows[2][0].ToString();
                    t3.Text = dt.Rows[2][1].ToString();
                    bz3.Text = dt.Rows[2][2].ToString();
                    h4.Text = dt.Rows[3][0].ToString();
                    t4.Text = dt.Rows[3][1].ToString();
                    bz4.Text = dt.Rows[3][2].ToString();
                    h5.Text = dt.Rows[4][0].ToString();
                    t5.Text = dt.Rows[4][1].ToString();
                    bz5.Text = dt.Rows[4][2].ToString();
                    h6.Text = dt.Rows[5][0].ToString();
                    t6.Text = dt.Rows[5][1].ToString();
                    bz6.Text = dt.Rows[5][2].ToString();
                    h7.Text = dt.Rows[6][0].ToString();
                    t7.Text = dt.Rows[6][1].ToString();
                    bz7.Text = dt.Rows[6][2].ToString();
                    h8.Text = dt.Rows[7][0].ToString();
                    t8.Text = dt.Rows[7][1].ToString();
                    bz8.Text = dt.Rows[7][2].ToString();
                    h9.Text = dt.Rows[8][0].ToString();
                    t9.Text = dt.Rows[8][1].ToString();
                    bz9.Text = dt.Rows[8][2].ToString();
                    h10.Text = dt.Rows[9][0].ToString();
                    t10.Text = dt.Rows[9][1].ToString();
                    bz10.Text = dt.Rows[9][2].ToString();
                    h11.Text = dt.Rows[10][0].ToString();
                    t11.Text = dt.Rows[10][1].ToString();
                    bz11.Text = dt.Rows[10][2].ToString();
                    h12.Text = dt.Rows[11][0].ToString();
                    t12.Text = dt.Rows[11][1].ToString();
                    bz12.Text = dt.Rows[11][2].ToString();
                    h13.Text = dt.Rows[12][0].ToString();
                    t13.Text = dt.Rows[12][1].ToString();
                    bz13.Text = dt.Rows[12][2].ToString();
                    h14.Text = dt.Rows[13][0].ToString();
                    t14.Text = dt.Rows[13][1].ToString();
                    bz14.Text = dt.Rows[13][2].ToString();
                    h15.Text = dt.Rows[14][0].ToString();
                    t15.Text = dt.Rows[14][1].ToString();
                    bz15.Text = dt.Rows[14][2].ToString();
                    h15.Visible = true;
                    t15.Visible = true;
                    bz15.Visible = true;
                    b15.Visible = true;
                    h14.Visible = true;
                    t14.Visible = true;
                    bz14.Visible = true;
                    l15.Visible = true;
                    b14.Visible = true;
                    h13.Visible = true;
                    t13.Visible = true;
                    h12.Visible = true;
                    t12.Visible = true;
                    l14.Visible = true;
                    l13.Visible = true;
                    bz12.Visible = true;
                    h11.Visible = true;
                    t11.Visible = true;
                    bz11.Visible = true;
                    h10.Visible = true;
                    l12.Visible = true;
                    t10.Visible = true;
                    bz10.Visible = true;
                    b10.Visible = true;
                    h9.Visible = true;
                    t9.Visible = true;
                    l11.Visible = true;
                    bz9.Visible = true;
                    b9.Visible = true;
                    l10.Visible = true;
                    h8.Visible = true;
                    t8.Visible = true;
                    bz8.Visible = true;
                    b8.Visible = true;
                    l9.Visible = true;
                    h7.Visible = true;
                    t7.Visible = true;
                    bz7.Visible = true;
                    l8.Visible = true;
                    b7.Visible = true;
                    h6.Visible = true;
                    l7.Visible = true;
                    t6.Visible = true;
                    bz6.Visible = true;
                    b6.Visible = true;
                    h5.Visible = true;
                    t5.Visible = true;
                    bz5.Visible = true;
                    b5.Visible = true;
                    h4.Visible = true;
                    t4.Visible = true;
                    bz4.Visible = true;
                    b4.Visible = true;
                    l4.Visible = true;
                    h3.Visible = true;
                    t3.Visible = true;
                    l3.Visible = true;
                    bz3.Visible = true;
                    b3.Visible = true;
                    h2.Visible = true;
                    t2.Visible = true;
                    bz2.Visible = true;
                    b2.Visible = true;
                    h1.Visible = true;
                    t1.Visible = true;
                    bz1.Visible = true;
                    l6.Visible = true;
                    b1.Visible = true;
                    l1.Visible = true;
                    l5.Visible = true;
                    l2.Visible = true;
                    b11.Visible = true;
                    b12.Visible = true;
                    bz13.Visible = true;
                    b13.Visible = true;
                }
            if (dt.Rows.Count == 16)
                if (dt.Rows[15] != null)
            {
                    h1.Text = dt.Rows[0][0].ToString();
                    t1.Text = dt.Rows[0][1].ToString();
                    bz1.Text = dt.Rows[0][2].ToString();
                    h2.Text = dt.Rows[1][0].ToString();
                    t2.Text = dt.Rows[1][1].ToString();
                    bz2.Text = dt.Rows[1][2].ToString();
                    h3.Text = dt.Rows[2][0].ToString();
                    t3.Text = dt.Rows[2][1].ToString();
                    bz3.Text = dt.Rows[2][2].ToString();
                    h4.Text = dt.Rows[3][0].ToString();
                    t4.Text = dt.Rows[3][1].ToString();
                    bz4.Text = dt.Rows[3][2].ToString();
                    h5.Text = dt.Rows[4][0].ToString();
                    t5.Text = dt.Rows[4][1].ToString();
                    bz5.Text = dt.Rows[4][2].ToString();
                    h6.Text = dt.Rows[5][0].ToString();
                    t6.Text = dt.Rows[5][1].ToString();
                    bz6.Text = dt.Rows[5][2].ToString();
                    h7.Text = dt.Rows[6][0].ToString();
                    t7.Text = dt.Rows[6][1].ToString();
                    bz7.Text = dt.Rows[6][2].ToString();
                    h8.Text = dt.Rows[7][0].ToString();
                    t8.Text = dt.Rows[7][1].ToString();
                    bz8.Text = dt.Rows[7][2].ToString();
                    h9.Text = dt.Rows[8][0].ToString();
                    t9.Text = dt.Rows[8][1].ToString();
                    bz9.Text = dt.Rows[8][2].ToString();
                    h10.Text = dt.Rows[9][0].ToString();
                    t10.Text = dt.Rows[9][1].ToString();
                    bz10.Text = dt.Rows[9][2].ToString();
                    h11.Text = dt.Rows[10][0].ToString();
                    t11.Text = dt.Rows[10][1].ToString();
                    bz11.Text = dt.Rows[10][2].ToString();
                    h12.Text = dt.Rows[11][0].ToString();
                    t12.Text = dt.Rows[11][1].ToString();
                    bz12.Text = dt.Rows[11][2].ToString();
                    h13.Text = dt.Rows[12][0].ToString();
                    t13.Text = dt.Rows[12][1].ToString();
                    bz13.Text = dt.Rows[12][2].ToString();
                    h14.Text = dt.Rows[13][0].ToString();
                    t14.Text = dt.Rows[13][1].ToString();
                    bz14.Text = dt.Rows[13][2].ToString();
                    h15.Text = dt.Rows[14][0].ToString();
                    t15.Text = dt.Rows[14][1].ToString();
                    bz15.Text = dt.Rows[14][2].ToString();
                    h16.Text = dt.Rows[15][0].ToString();
                    t16.Text = dt.Rows[15][1].ToString();
                    bz16.Text = dt.Rows[15][2].ToString();
                    h16.Visible = true;
                    t16.Visible = true;
                    bz16.Visible = true;
                    b16.Visible = true;
                    h15.Visible = true;
                    t15.Visible = true;
                    bz15.Visible = true;
                    b15.Visible = true;
                    h14.Visible = true;
                    t14.Visible = true;
                    l16.Visible = true;
                    bz14.Visible = true;
                    l15.Visible = true;
                    b14.Visible = true;
                    h13.Visible = true;
                    t13.Visible = true;
                    h12.Visible = true;
                    t12.Visible = true;
                    l14.Visible = true;
                    l13.Visible = true;
                    bz12.Visible = true;
                    h11.Visible = true;
                    t11.Visible = true;
                    bz11.Visible = true;
                    h10.Visible = true;
                    l12.Visible = true;
                    t10.Visible = true;
                    bz10.Visible = true;
                    b10.Visible = true;
                    h9.Visible = true;
                    t9.Visible = true;
                    l11.Visible = true;
                    bz9.Visible = true;
                    b9.Visible = true;
                    l10.Visible = true;
                    h8.Visible = true;
                    t8.Visible = true;
                    bz8.Visible = true;
                    b8.Visible = true;
                    l9.Visible = true;
                    h7.Visible = true;
                    t7.Visible = true;
                    bz7.Visible = true;
                    l8.Visible = true;
                    b7.Visible = true;
                    h6.Visible = true;
                    l7.Visible = true;
                    t6.Visible = true;
                    bz6.Visible = true;
                    b6.Visible = true;
                    h5.Visible = true;
                    t5.Visible = true;
                    bz5.Visible = true;
                    b5.Visible = true;
                    h4.Visible = true;
                    t4.Visible = true;
                    bz4.Visible = true;
                    b4.Visible = true;
                    l4.Visible = true;
                    h3.Visible = true;
                    t3.Visible = true;
                    l3.Visible = true;
                    bz3.Visible = true;
                    b3.Visible = true;
                    h2.Visible = true;
                    t2.Visible = true;
                    bz2.Visible = true;
                    b2.Visible = true;
                    h1.Visible = true;
                    t1.Visible = true;
                    bz1.Visible = true;
                    l6.Visible = true;
                    b1.Visible = true;
                    l1.Visible = true;
                    l5.Visible = true;
                    l2.Visible = true;
                    b11.Visible = true;
                    b12.Visible = true;
                    bz13.Visible = true;
                    b13.Visible = true;
                }
            if (dt.Rows.Count == 17)
                if (dt.Rows[16] != null)
            {
                    h1.Text = dt.Rows[0][0].ToString();
                    t1.Text = dt.Rows[0][1].ToString();
                    bz1.Text = dt.Rows[0][2].ToString();
                    h2.Text = dt.Rows[1][0].ToString();
                    t2.Text = dt.Rows[1][1].ToString();
                    bz2.Text = dt.Rows[1][2].ToString();
                    h3.Text = dt.Rows[2][0].ToString();
                    t3.Text = dt.Rows[2][1].ToString();
                    bz3.Text = dt.Rows[2][2].ToString();
                    h4.Text = dt.Rows[3][0].ToString();
                    t4.Text = dt.Rows[3][1].ToString();
                    bz4.Text = dt.Rows[3][2].ToString();
                    h5.Text = dt.Rows[4][0].ToString();
                    t5.Text = dt.Rows[4][1].ToString();
                    bz5.Text = dt.Rows[4][2].ToString();
                    h6.Text = dt.Rows[5][0].ToString();
                    t6.Text = dt.Rows[5][1].ToString();
                    bz6.Text = dt.Rows[5][2].ToString();
                    h7.Text = dt.Rows[6][0].ToString();
                    t7.Text = dt.Rows[6][1].ToString();
                    bz7.Text = dt.Rows[6][2].ToString();
                    h8.Text = dt.Rows[7][0].ToString();
                    t8.Text = dt.Rows[7][1].ToString();
                    bz8.Text = dt.Rows[7][2].ToString();
                    h9.Text = dt.Rows[8][0].ToString();
                    t9.Text = dt.Rows[8][1].ToString();
                    bz9.Text = dt.Rows[8][2].ToString();
                    h10.Text = dt.Rows[9][0].ToString();
                    t10.Text = dt.Rows[9][1].ToString();
                    bz10.Text = dt.Rows[9][2].ToString();
                    h11.Text = dt.Rows[10][0].ToString();
                    t11.Text = dt.Rows[10][1].ToString();
                    bz11.Text = dt.Rows[10][2].ToString();
                    h12.Text = dt.Rows[11][0].ToString();
                    t12.Text = dt.Rows[11][1].ToString();
                    bz12.Text = dt.Rows[11][2].ToString();
                    h13.Text = dt.Rows[12][0].ToString();
                    t13.Text = dt.Rows[12][1].ToString();
                    bz13.Text = dt.Rows[12][2].ToString();
                    h14.Text = dt.Rows[13][0].ToString();
                    t14.Text = dt.Rows[13][1].ToString();
                    bz14.Text = dt.Rows[13][2].ToString();
                    h15.Text = dt.Rows[14][0].ToString();
                    t15.Text = dt.Rows[14][1].ToString();
                    bz15.Text = dt.Rows[14][2].ToString();
                    h16.Text = dt.Rows[15][0].ToString();
                    t16.Text = dt.Rows[15][1].ToString();
                    bz16.Text = dt.Rows[15][2].ToString();
                    h17.Text = dt.Rows[16][0].ToString();
                    t17.Text = dt.Rows[16][1].ToString();
                    bz17.Text = dt.Rows[16][2].ToString();
                    h17.Visible = true;
                    t17.Visible = true;
                    bz17.Visible = true;
                    h16.Visible = true;
                    t16.Visible = true;
                    bz16.Visible = true;
                    b16.Visible = true;
                    l17.Visible = true;
                    h15.Visible = true;
                    t15.Visible = true;
                    bz15.Visible = true;
                    b15.Visible = true;
                    h14.Visible = true;
                    t14.Visible = true;
                    l16.Visible = true;
                    bz14.Visible = true;
                    l15.Visible = true;
                    b14.Visible = true;
                    h13.Visible = true;
                    t13.Visible = true;
                    h12.Visible = true;
                    t12.Visible = true;
                    l14.Visible = true;
                    l13.Visible = true;
                    bz12.Visible = true;
                    h11.Visible = true;
                    t11.Visible = true;
                    bz11.Visible = true;
                    h10.Visible = true;
                    l12.Visible = true;
                    t10.Visible = true;
                    bz10.Visible = true;
                    b10.Visible = true;
                    h9.Visible = true;
                    t9.Visible = true;
                    l11.Visible = true;
                    bz9.Visible = true;
                    b9.Visible = true;
                    l10.Visible = true;
                    h8.Visible = true;
                    t8.Visible = true;
                    bz8.Visible = true;
                    b8.Visible = true;
                    l9.Visible = true;
                    h7.Visible = true;
                    t7.Visible = true;
                    bz7.Visible = true;
                    l8.Visible = true;
                    b7.Visible = true;
                    h6.Visible = true;
                    l7.Visible = true;
                    t6.Visible = true;
                    bz6.Visible = true;
                    b6.Visible = true;
                    h5.Visible = true;
                    t5.Visible = true;
                    bz5.Visible = true;
                    b5.Visible = true;
                    h4.Visible = true;
                    t4.Visible = true;
                    bz4.Visible = true;
                    b4.Visible = true;
                    l4.Visible = true;
                    h3.Visible = true;
                    t3.Visible = true;
                    l3.Visible = true;
                    bz3.Visible = true;
                    b3.Visible = true;
                    h2.Visible = true;
                    t2.Visible = true;
                    bz2.Visible = true;
                    b2.Visible = true;
                    h1.Visible = true;
                    t1.Visible = true;
                    bz1.Visible = true;
                    l6.Visible = true;
                    b1.Visible = true;
                    l1.Visible = true;
                    l5.Visible = true;
                    l2.Visible = true;
                    b11.Visible = true;
                    b12.Visible = true;
                    bz13.Visible = true;
                    b13.Visible = true;
                    b17.Visible = true;
                }
            if (dt.Rows.Count == 18)
                if (dt.Rows[17] != null)
            {
                    h1.Text = dt.Rows[0][0].ToString();
                    t1.Text = dt.Rows[0][1].ToString();
                    bz1.Text = dt.Rows[0][2].ToString();
                    h2.Text = dt.Rows[1][0].ToString();
                    t2.Text = dt.Rows[1][1].ToString();
                    bz2.Text = dt.Rows[1][2].ToString();
                    h3.Text = dt.Rows[2][0].ToString();
                    t3.Text = dt.Rows[2][1].ToString();
                    bz3.Text = dt.Rows[2][2].ToString();
                    h4.Text = dt.Rows[3][0].ToString();
                    t4.Text = dt.Rows[3][1].ToString();
                    bz4.Text = dt.Rows[3][2].ToString();
                    h5.Text = dt.Rows[4][0].ToString();
                    t5.Text = dt.Rows[4][1].ToString();
                    bz5.Text = dt.Rows[4][2].ToString();
                    h6.Text = dt.Rows[5][0].ToString();
                    t6.Text = dt.Rows[5][1].ToString();
                    bz6.Text = dt.Rows[5][2].ToString();
                    h7.Text = dt.Rows[6][0].ToString();
                    t7.Text = dt.Rows[6][1].ToString();
                    bz7.Text = dt.Rows[6][2].ToString();
                    h8.Text = dt.Rows[7][0].ToString();
                    t8.Text = dt.Rows[7][1].ToString();
                    bz8.Text = dt.Rows[7][2].ToString();
                    h9.Text = dt.Rows[8][0].ToString();
                    t9.Text = dt.Rows[8][1].ToString();
                    bz9.Text = dt.Rows[8][2].ToString();
                    h10.Text = dt.Rows[9][0].ToString();
                    t10.Text = dt.Rows[9][1].ToString();
                    bz10.Text = dt.Rows[9][2].ToString();
                    h11.Text = dt.Rows[10][0].ToString();
                    t11.Text = dt.Rows[10][1].ToString();
                    bz11.Text = dt.Rows[10][2].ToString();
                    h12.Text = dt.Rows[11][0].ToString();
                    t12.Text = dt.Rows[11][1].ToString();
                    bz12.Text = dt.Rows[11][2].ToString();
                    h13.Text = dt.Rows[12][0].ToString();
                    t13.Text = dt.Rows[12][1].ToString();
                    bz13.Text = dt.Rows[12][2].ToString();
                    h14.Text = dt.Rows[13][0].ToString();
                    t14.Text = dt.Rows[13][1].ToString();
                    bz14.Text = dt.Rows[13][2].ToString();
                    h15.Text = dt.Rows[14][0].ToString();
                    t15.Text = dt.Rows[14][1].ToString();
                    bz15.Text = dt.Rows[14][2].ToString();
                    h16.Text = dt.Rows[15][0].ToString();
                    t16.Text = dt.Rows[15][1].ToString();
                    bz16.Text = dt.Rows[15][2].ToString();
                    h17.Text = dt.Rows[16][0].ToString();
                    t17.Text = dt.Rows[16][1].ToString();
                    bz17.Text = dt.Rows[16][2].ToString();
                    h18.Text = dt.Rows[177][0].ToString();
                    t18.Text = dt.Rows[17][1].ToString();
                    bz18.Text = dt.Rows[17][2].ToString();
                    h18.Visible = true;
                    t18.Visible = true;
                    bz18.Visible = true;
                    b18.Visible = true;
                    h17.Visible = true;
                    t17.Visible = true;
                    bz17.Visible = true;
                    h16.Visible = true;
                    t16.Visible = true;
                    l18.Visible = true;
                    bz16.Visible = true;
                    b16.Visible = true;
                    l17.Visible = true;
                    h15.Visible = true;
                    t15.Visible = true;
                    bz15.Visible = true;
                    b15.Visible = true;
                    h14.Visible = true;
                    t14.Visible = true;
                    l16.Visible = true;
                    bz14.Visible = true;
                    l15.Visible = true;
                    b14.Visible = true;
                    h13.Visible = true;
                    t13.Visible = true;
                    h12.Visible = true;
                    t12.Visible = true;
                    l14.Visible = true;
                    l13.Visible = true;
                    bz12.Visible = true;
                    h11.Visible = true;
                    t11.Visible = true;
                    bz11.Visible = true;
                    h10.Visible = true;
                    l12.Visible = true;
                    t10.Visible = true;
                    bz10.Visible = true;
                    b10.Visible = true;
                    h9.Visible = true;
                    t9.Visible = true;
                    l11.Visible = true;
                    bz9.Visible = true;
                    b9.Visible = true;
                    l10.Visible = true;
                    h8.Visible = true;
                    t8.Visible = true;
                    bz8.Visible = true;
                    b8.Visible = true;
                    l9.Visible = true;
                    h7.Visible = true;
                    t7.Visible = true;
                    bz7.Visible = true;
                    l8.Visible = true;
                    b7.Visible = true;
                    h6.Visible = true;
                    l7.Visible = true;
                    t6.Visible = true;
                    bz6.Visible = true;
                    b6.Visible = true;
                    h5.Visible = true;
                    t5.Visible = true;
                    bz5.Visible = true;
                    b5.Visible = true;
                    h4.Visible = true;
                    t4.Visible = true;
                    bz4.Visible = true;
                    b4.Visible = true;
                    l4.Visible = true;
                    h3.Visible = true;
                    t3.Visible = true;
                    l3.Visible = true;
                    bz3.Visible = true;
                    b3.Visible = true;
                    h2.Visible = true;
                    t2.Visible = true;
                    bz2.Visible = true;
                    b2.Visible = true;
                    h1.Visible = true;
                    t1.Visible = true;
                    bz1.Visible = true;
                    l6.Visible = true;
                    b1.Visible = true;
                    l1.Visible = true;
                    l5.Visible = true;
                    l2.Visible = true;
                    b11.Visible = true;
                    b12.Visible = true;
                    bz13.Visible = true;
                    b13.Visible = true;
                    b17.Visible = true;
                }
            if (dt.Rows.Count == 19)
                if (dt.Rows[18] != null)
                {
                    h1.Text = dt.Rows[0][0].ToString();
                    t1.Text = dt.Rows[0][1].ToString();
                    bz1.Text = dt.Rows[0][2].ToString();
                    h2.Text = dt.Rows[1][0].ToString();
                    t2.Text = dt.Rows[1][1].ToString();
                    bz2.Text = dt.Rows[1][2].ToString();
                    h3.Text = dt.Rows[2][0].ToString();
                    t3.Text = dt.Rows[2][1].ToString();
                    bz3.Text = dt.Rows[2][2].ToString();
                    h4.Text = dt.Rows[3][0].ToString();
                    t4.Text = dt.Rows[3][1].ToString();
                    bz4.Text = dt.Rows[3][2].ToString();
                    h5.Text = dt.Rows[4][0].ToString();
                    t5.Text = dt.Rows[4][1].ToString();
                    bz5.Text = dt.Rows[4][2].ToString();
                    h6.Text = dt.Rows[5][0].ToString();
                    t6.Text = dt.Rows[5][1].ToString();
                    bz6.Text = dt.Rows[5][2].ToString();
                    h7.Text = dt.Rows[6][0].ToString();
                    t7.Text = dt.Rows[6][1].ToString();
                    bz7.Text = dt.Rows[6][2].ToString();
                    h8.Text = dt.Rows[7][0].ToString();
                    t8.Text = dt.Rows[7][1].ToString();
                    bz8.Text = dt.Rows[7][2].ToString();
                    h9.Text = dt.Rows[8][0].ToString();
                    t9.Text = dt.Rows[8][1].ToString();
                    bz9.Text = dt.Rows[8][2].ToString();
                    h10.Text = dt.Rows[9][0].ToString();
                    t10.Text = dt.Rows[9][1].ToString();
                    bz10.Text = dt.Rows[9][2].ToString();
                    h11.Text = dt.Rows[10][0].ToString();
                    t11.Text = dt.Rows[10][1].ToString();
                    bz11.Text = dt.Rows[10][2].ToString();
                    h12.Text = dt.Rows[11][0].ToString();
                    t12.Text = dt.Rows[11][1].ToString();
                    bz12.Text = dt.Rows[11][2].ToString();
                    h13.Text = dt.Rows[12][0].ToString();
                    t13.Text = dt.Rows[12][1].ToString();
                    bz13.Text = dt.Rows[12][2].ToString();
                    h14.Text = dt.Rows[13][0].ToString();
                    t14.Text = dt.Rows[13][1].ToString();
                    bz14.Text = dt.Rows[13][2].ToString();
                    h15.Text = dt.Rows[14][0].ToString();
                    t15.Text = dt.Rows[14][1].ToString();
                    bz15.Text = dt.Rows[14][2].ToString();
                    h16.Text = dt.Rows[15][0].ToString();
                    t16.Text = dt.Rows[15][1].ToString();
                    bz16.Text = dt.Rows[15][2].ToString();
                    h17.Text = dt.Rows[16][0].ToString();
                    t17.Text = dt.Rows[16][1].ToString();
                    bz17.Text = dt.Rows[16][2].ToString();
                    h18.Text = dt.Rows[177][0].ToString();
                    t18.Text = dt.Rows[17][1].ToString();
                    bz18.Text = dt.Rows[17][2].ToString();
                    h19.Text = dt.Rows[18][0].ToString();
                    t19.Text = dt.Rows[18][1].ToString();
                    bz19.Text = dt.Rows[18][2].ToString();
                    h19.Visible = true;
                    t19.Visible = true;
                    bz19.Visible = true;
                    b19.Visible = true;
                    h18.Visible = true;
                    t18.Visible = true;
                    bz18.Visible = true;
                    b18.Visible = true;
                    h17.Visible = true;
                    t17.Visible = true;
                    bz17.Visible = true;
                    h16.Visible = true;
                    t16.Visible = true;
                    l18.Visible = true;
                    l19.Visible = true;
                    bz16.Visible = true;
                    b16.Visible = true;
                    l17.Visible = true;
                    h15.Visible = true;
                    t15.Visible = true;
                    bz15.Visible = true;
                    b15.Visible = true;
                    h14.Visible = true;
                    t14.Visible = true;
                    l16.Visible = true;
                    bz14.Visible = true;
                    l15.Visible = true;
                    b14.Visible = true;
                    h13.Visible = true;
                    t13.Visible = true;
                    h12.Visible = true;
                    t12.Visible = true;
                    l14.Visible = true;
                    l13.Visible = true;
                    bz12.Visible = true;
                    h11.Visible = true;
                    t11.Visible = true;
                    bz11.Visible = true;
                    h10.Visible = true;
                    l12.Visible = true;
                    t10.Visible = true;
                    bz10.Visible = true;
                    b10.Visible = true;
                    h9.Visible = true;
                    t9.Visible = true;
                    l11.Visible = true;
                    bz9.Visible = true;
                    b9.Visible = true;
                    l10.Visible = true;
                    h8.Visible = true;
                    t8.Visible = true;
                    bz8.Visible = true;
                    b8.Visible = true;
                    l9.Visible = true;
                    h7.Visible = true;
                    t7.Visible = true;
                    bz7.Visible = true;
                    l8.Visible = true;
                    b7.Visible = true;
                    h6.Visible = true;
                    l7.Visible = true;
                    t6.Visible = true;
                    bz6.Visible = true;
                    b6.Visible = true;
                    h5.Visible = true;
                    t5.Visible = true;
                    bz5.Visible = true;
                    b5.Visible = true;
                    h4.Visible = true;
                    t4.Visible = true;
                    bz4.Visible = true;
                    b4.Visible = true;
                    l4.Visible = true;
                    h3.Visible = true;
                    t3.Visible = true;
                    l3.Visible = true;
                    bz3.Visible = true;
                    b3.Visible = true;
                    h2.Visible = true;
                    t2.Visible = true;
                    bz2.Visible = true;
                    b2.Visible = true;
                    h1.Visible = true;
                    t1.Visible = true;
                    bz1.Visible = true;
                    l6.Visible = true;
                    b1.Visible = true;
                    l1.Visible = true;
                    l5.Visible = true;
                    l2.Visible = true;
                    b11.Visible = true;
                    b12.Visible = true;
                    bz13.Visible = true;
                    b13.Visible = true;
                    b17.Visible = true;
                }
            if (dt.Rows.Count == 20)
                if (dt.Rows[19] != null)
                {
                    l20.Visible = true;
                    h1.Text = dt.Rows[0][0].ToString();
                    t1.Text = dt.Rows[0][1].ToString();
                    bz1.Text = dt.Rows[0][2].ToString();
                    h2.Text = dt.Rows[1][0].ToString();
                    t2.Text = dt.Rows[1][1].ToString();
                    bz2.Text = dt.Rows[1][2].ToString();
                    h3.Text = dt.Rows[2][0].ToString();
                    t3.Text = dt.Rows[2][1].ToString();
                    bz3.Text = dt.Rows[2][2].ToString();
                    h4.Text = dt.Rows[3][0].ToString();
                    t4.Text = dt.Rows[3][1].ToString();
                    bz4.Text = dt.Rows[3][2].ToString();
                    h5.Text = dt.Rows[4][0].ToString();
                    t5.Text = dt.Rows[4][1].ToString();
                    bz5.Text = dt.Rows[4][2].ToString();
                    h6.Text = dt.Rows[5][0].ToString();
                    t6.Text = dt.Rows[5][1].ToString();
                    bz6.Text = dt.Rows[5][2].ToString();
                    h7.Text = dt.Rows[6][0].ToString();
                    t7.Text = dt.Rows[6][1].ToString();
                    bz7.Text = dt.Rows[6][2].ToString();
                    h8.Text = dt.Rows[7][0].ToString();
                    t8.Text = dt.Rows[7][1].ToString();
                    bz8.Text = dt.Rows[7][2].ToString();
                    h9.Text = dt.Rows[8][0].ToString();
                    t9.Text = dt.Rows[8][1].ToString();
                    bz9.Text = dt.Rows[8][2].ToString();
                    h10.Text = dt.Rows[9][0].ToString();
                    t10.Text = dt.Rows[9][1].ToString();
                    bz10.Text = dt.Rows[9][2].ToString();
                    h11.Text = dt.Rows[10][0].ToString();
                    t11.Text = dt.Rows[10][1].ToString();
                    bz11.Text = dt.Rows[10][2].ToString();
                    h12.Text = dt.Rows[11][0].ToString();
                    t12.Text = dt.Rows[11][1].ToString();
                    bz12.Text = dt.Rows[11][2].ToString();
                    h13.Text = dt.Rows[12][0].ToString();
                    t13.Text = dt.Rows[12][1].ToString();
                    bz13.Text = dt.Rows[12][2].ToString();
                    h14.Text = dt.Rows[13][0].ToString();
                    t14.Text = dt.Rows[13][1].ToString();
                    bz14.Text = dt.Rows[13][2].ToString();
                    h15.Text = dt.Rows[14][0].ToString();
                    t15.Text = dt.Rows[14][1].ToString();
                    bz15.Text = dt.Rows[14][2].ToString();
                    h16.Text = dt.Rows[15][0].ToString();
                    t16.Text = dt.Rows[15][1].ToString();
                    bz16.Text = dt.Rows[15][2].ToString();
                    h17.Text = dt.Rows[16][0].ToString();
                    t17.Text = dt.Rows[16][1].ToString();
                    bz17.Text = dt.Rows[16][2].ToString();
                    h18.Text = dt.Rows[177][0].ToString();
                    t18.Text = dt.Rows[17][1].ToString();
                    bz18.Text = dt.Rows[17][2].ToString();
                    h19.Text = dt.Rows[18][0].ToString();
                    t19.Text = dt.Rows[18][1].ToString();
                    bz19.Text = dt.Rows[18][2].ToString();
                    h20.Text = dt.Rows[19][0].ToString();
                    t20.Text = dt.Rows[19][1].ToString();
                    bz20.Text = dt.Rows[19][2].ToString();
                    h20.Visible = true;
                    t20.Visible = true;
                    bz20.Visible = true;
                    b20.Visible = true;
                    h19.Visible = true;
                    t19.Visible = true;
                    bz19.Visible = true;
                    b19.Visible = true;
                    h18.Visible = true;
                    t18.Visible = true;
                    bz18.Visible = true;
                    b18.Visible = true;
                    h17.Visible = true;
                    t17.Visible = true;
                    bz17.Visible = true;
                    h16.Visible = true;
                    t16.Visible = true;
                    l18.Visible = true;
                    l19.Visible = true;
                    bz16.Visible = true;
                    b16.Visible = true;
                    l17.Visible = true;
                    h15.Visible = true;
                    t15.Visible = true;
                    bz15.Visible = true;
                    b15.Visible = true;
                    h14.Visible = true;
                    t14.Visible = true;
                    l16.Visible = true;
                    bz14.Visible = true;
                    l15.Visible = true;
                    b14.Visible = true;
                    h13.Visible = true;
                    t13.Visible = true;
                    h12.Visible = true;
                    t12.Visible = true;
                    l14.Visible = true;
                    l13.Visible = true;
                    bz12.Visible = true;
                    h11.Visible = true;
                    t11.Visible = true;
                    bz11.Visible = true;
                    h10.Visible = true;
                    l12.Visible = true;
                    t10.Visible = true;
                    bz10.Visible = true;
                    b10.Visible = true;
                    h9.Visible = true;
                    t9.Visible = true;
                    l11.Visible = true;
                    bz9.Visible = true;
                    b9.Visible = true;
                    l10.Visible = true;
                    h8.Visible = true;
                    t8.Visible = true;
                    bz8.Visible = true;
                    b8.Visible = true;
                    l9.Visible = true;
                    h7.Visible = true;
                    t7.Visible = true;
                    bz7.Visible = true;
                    l8.Visible = true;
                    b7.Visible = true;
                    h6.Visible = true;
                    l7.Visible = true;
                    t6.Visible = true;
                    bz6.Visible = true;
                    b6.Visible = true;
                    h5.Visible = true;
                    t5.Visible = true;
                    bz5.Visible = true;
                    b5.Visible = true;
                    h4.Visible = true;
                    t4.Visible = true;
                    bz4.Visible = true;
                    b4.Visible = true;
                    l4.Visible = true;
                    h3.Visible = true;
                    t3.Visible = true;
                    l3.Visible = true;
                    bz3.Visible = true;
                    b3.Visible = true;
                    h2.Visible = true;
                    t2.Visible = true;
                    bz2.Visible = true;
                    b2.Visible = true;
                    h1.Visible = true;
                    t1.Visible = true;
                    bz1.Visible = true;
                    l6.Visible = true;
                    b1.Visible = true;
                    l1.Visible = true;
                    l5.Visible = true;
                    l2.Visible = true;
                    b11.Visible = true;
                    b12.Visible = true;
                    bz13.Visible = true;
                    b13.Visible = true;
                    b17.Visible = true;
                }

        }
        #endregion
        #region 对列表数据进行操作



        private void h19_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
         
      
        private void b1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"您即将下载作业文件名为\n{dt.Rows[0][0].ToString()}\n的文件，请确认无误！", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                fileoperation.creat_directory(sid);
                string filename = dt.Rows[0][0].ToString();
                fileoperation.homeworkoperation(cid, filename, sid);
            }
            else
            {
                MessageBox.Show("您取消了下载！");
            }
        }

        private void h1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filename = dt.Rows[0][0].ToString();
            fileoperation.clicklink(cid, filename);
        }

        private void h2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filename = dt.Rows[1][0].ToString();
            fileoperation.clicklink(cid, filename);
        }

        private void h3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filename = dt.Rows[2][0].ToString();
            fileoperation.clicklink(cid, filename);
        }

        private void h4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filename = dt.Rows[3][0].ToString();
            fileoperation.clicklink(cid, filename);
        }

        private void h5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filename = dt.Rows[4][0].ToString();
            fileoperation.clicklink(cid, filename);
        }

        private void h6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filename = dt.Rows[5][0].ToString();
            fileoperation.clicklink(cid, filename);
        }

        private void h7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filename = dt.Rows[6][0].ToString();
            fileoperation.clicklink(cid, filename);
        }

        private void h8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filename = dt.Rows[7][0].ToString();
            fileoperation.clicklink(cid, filename);
        }

        private void h9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filename = dt.Rows[8][0].ToString();
            fileoperation.clicklink(cid, filename);
        }

        private void h10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filename = dt.Rows[9][0].ToString();
            fileoperation.clicklink(cid, filename);
        }

        private void h11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filename = dt.Rows[10][0].ToString();
            fileoperation.clicklink(cid, filename);
        }

        private void h12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filename = dt.Rows[11][0].ToString();
            fileoperation.clicklink(cid, filename);
        }

        private void h13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filename = dt.Rows[12][0].ToString();
            fileoperation.clicklink(cid, filename);
        }

        private void h14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filename = dt.Rows[14][0].ToString();
            fileoperation.clicklink(cid, filename);
        }

        private void h15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filename = dt.Rows[15][0].ToString();
            fileoperation.clicklink(cid, filename);
        }

        private void h16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filename = dt.Rows[16][0].ToString();
            fileoperation.clicklink(cid, filename);
        }

        private void h17_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filename = dt.Rows[17][0].ToString();
            fileoperation.clicklink(cid, filename);
        }

        private void h18_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filename = dt.Rows[18][0].ToString();
            fileoperation.clicklink(cid, filename);
        }

        private void h20_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             string filename = dt.Rows[19][0].ToString();
            fileoperation.clicklink(cid, filename);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"您即将下载作业文件名为\n{dt.Rows[1][0].ToString()}\n的文件，请确认无误！", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                fileoperation.creat_directory(sid);
                string filename = dt.Rows[1][0].ToString();
                fileoperation.homeworkoperation(cid, filename, sid);
            }
            else
            {
                MessageBox.Show("您取消了下载！");
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"您即将下载作业文件名为\n{dt.Rows[2][0].ToString()}\n的文件，请确认无误！", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                fileoperation.creat_directory(sid);
                string filename = dt.Rows[2][0].ToString();
                fileoperation.homeworkoperation(cid, filename, sid);
            }
            else
            {
                MessageBox.Show("您取消了下载！");
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"您即将下载作业文件名为\n{dt.Rows[3][0].ToString()}\n的文件，请确认无误！", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                fileoperation.creat_directory(sid);
                string filename = dt.Rows[3][0].ToString();
                fileoperation.homeworkoperation(cid, filename, sid);
            }
            else
            {
                MessageBox.Show("您取消了下载！");
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"您即将下载作业文件名为\n{dt.Rows[4][0].ToString()}\n的文件，请确认无误！", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                fileoperation.creat_directory(sid);
                string filename = dt.Rows[4][0].ToString();
                fileoperation.homeworkoperation(cid, filename, sid);
            }
            else
            {
                MessageBox.Show("您取消了下载！");
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"您即将下载作业文件名为\n{dt.Rows[5][0].ToString()}\n的文件，请确认无误！", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                fileoperation.creat_directory(sid);
                string filename = dt.Rows[5][0].ToString();
                fileoperation.homeworkoperation(cid, filename, sid);
            }
            else
            {
                MessageBox.Show("您取消了下载！");
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"您即将下载作业文件名为\n{dt.Rows[6][0].ToString()}\n的文件，请确认无误！", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                fileoperation.creat_directory(sid);
                string filename = dt.Rows[6][0].ToString();
                fileoperation.homeworkoperation(cid, filename, sid);
            }
            else
            {
                MessageBox.Show("您取消了下载！");
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"您即将下载作业文件名为\n{dt.Rows[7][0].ToString()}\n的文件，请确认无误！", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                fileoperation.creat_directory(sid);
                string filename = dt.Rows[7][0].ToString();
                fileoperation.homeworkoperation(cid, filename, sid);
            }
            else
            {
                MessageBox.Show("您取消了下载！");
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"您即将下载作业文件名为\n{dt.Rows[8][0].ToString()}\n的文件，请确认无误！", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                fileoperation.creat_directory(sid);
                string filename = dt.Rows[8][0].ToString();
                fileoperation.homeworkoperation(cid, filename, sid);
            }
            else
            {
                MessageBox.Show("您取消了下载！");
            }
        }

        private void b10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"您即将下载作业文件名为\n{dt.Rows[9][0].ToString()}\n的文件，请确认无误！", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                fileoperation.creat_directory(sid);
                string filename = dt.Rows[9][0].ToString();
                fileoperation.homeworkoperation(cid, filename, sid);
            }
            else
            {
                MessageBox.Show("您取消了下载！");
            }
        }

        private void b11_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"您即将下载作业文件名为\n{dt.Rows[10][0].ToString()}\n的文件，请确认无误！", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                fileoperation.creat_directory(sid);
                string filename = dt.Rows[10][0].ToString();
                fileoperation.homeworkoperation(cid, filename, sid);
            }
            else
            {
                MessageBox.Show("您取消了下载！");
            }
        }

        private void b12_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"您即将下载作业文件名为\n{dt.Rows[11][0].ToString()}\n的文件，请确认无误！", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                fileoperation.creat_directory(sid);
                string filename = dt.Rows[11][0].ToString();
                fileoperation.homeworkoperation(cid, filename, sid);
            }
            else
            {
                MessageBox.Show("您取消了下载！");
            }
        }

        private void b13_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"您即将下载作业文件名为\n{dt.Rows[12][0].ToString()}\n的文件，请确认无误！", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                fileoperation.creat_directory(sid);
                string filename = dt.Rows[12][0].ToString();
                fileoperation.homeworkoperation(cid, filename, sid);
            }
            else
            {
                MessageBox.Show("您取消了下载！");
            }
        }

        private void b14_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"您即将下载作业文件名为\n{dt.Rows[13][0].ToString()}\n的文件，请确认无误！", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                fileoperation.creat_directory(sid);
                string filename = dt.Rows[13][0].ToString();
                fileoperation.homeworkoperation(cid, filename, sid);
            }
            else
            {
                MessageBox.Show("您取消了下载！");
            }
        }

        private void b15_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"您即将下载作业文件名为\n{dt.Rows[14][0].ToString()}\n的文件，请确认无误！", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                fileoperation.creat_directory(sid);
                string filename = dt.Rows[14][0].ToString();
                fileoperation.homeworkoperation(cid, filename, sid);
            }
            else
            {
                MessageBox.Show("您取消了下载！");
            }
        }

        private void b16_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"您即将下载作业文件名为\n{dt.Rows[15][0].ToString()}\n的文件，请确认无误！", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                fileoperation.creat_directory(sid);
                string filename = dt.Rows[15][0].ToString();
                fileoperation.homeworkoperation(cid, filename, sid);
            }
            else
            {
                MessageBox.Show("您取消了下载！");
            }
        }

        private void b17_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"您即将下载作业文件名为\n{dt.Rows[16][0].ToString()}\n的文件，请确认无误！", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                fileoperation.creat_directory(sid);
                string filename = dt.Rows[16][0].ToString();
                fileoperation.homeworkoperation(cid, filename, sid);
            }
            else
            {
                MessageBox.Show("您取消了下载！");
            }
        }

        private void b18_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"您即将下载作业文件名为\n{dt.Rows[17][0].ToString()}\n的文件，请确认无误！", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                fileoperation.creat_directory(sid);
                string filename = dt.Rows[17][0].ToString();
                fileoperation.homeworkoperation(cid, filename, sid);
            }
            else
            {
                MessageBox.Show("您取消了下载！");
            }
        }

        private void b19_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"您即将下载作业文件名为\n{dt.Rows[18][0].ToString()}\n的文件，请确认无误！", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                fileoperation.creat_directory(sid);
                string filename = dt.Rows[18][0].ToString();
                fileoperation.homeworkoperation(cid, filename, sid);
            }
            else
            {
                MessageBox.Show("您取消了下载！");
            }
        }

        private void b20_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"您即将下载作业文件名为\n{dt.Rows[19][0].ToString()}\n的文件，请确认无误！", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                fileoperation.creat_directory(sid);
                string filename = dt.Rows[19][0].ToString();
                fileoperation.homeworkoperation(cid, filename, sid);
            }
            else
            {
                MessageBox.Show("您取消了下载！");
            }
        }
        #endregion
    }
}
