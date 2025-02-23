using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satelliteeducationsystem.student
{
    
    public partial class MyCourse : Form
    {
        private string cid;
        public MyCourse(string cid)
        {
            InitializeComponent();
            this.cid = cid;
        }

        private void MyCourse_Load(object sender, EventArgs e)
        {
            DataSet ds=Method.Mycourse(cid);
            DataSet ds1 = Method.bz(cid);
                num11.Text = ds.Tables["course"].Rows[0][0].ToString();
                num12.Text = ds.Tables["course"].Rows[1][0].ToString();
                num13.Text = ds.Tables["course"].Rows[2][0].ToString();
                num14.Text = ds.Tables["course"].Rows[3][0].ToString();
                num15.Text = ds.Tables["course"].Rows[4][0].ToString();
                num16.Text = ds.Tables["course"].Rows[5][0].ToString();

                num21.Text = ds.Tables["course"].Rows[0][1].ToString();
                num22.Text = ds.Tables["course"].Rows[1][1].ToString();
                num23.Text = ds.Tables["course"].Rows[2][1].ToString();
                num24.Text = ds.Tables["course"].Rows[3][1].ToString();
                num25.Text = ds.Tables["course"].Rows[4][1].ToString();
                num26.Text = ds.Tables["course"].Rows[5][1].ToString();

                num31.Text = ds.Tables["course"].Rows[0][2].ToString();
                num32.Text = ds.Tables["course"].Rows[1][2].ToString();
                num33.Text = ds.Tables["course"].Rows[2][2].ToString();
                num34.Text = ds.Tables["course"].Rows[3][2].ToString();
                num35.Text = ds.Tables["course"].Rows[4][2].ToString();
                num36.Text = ds.Tables["course"].Rows[5][2].ToString();

                num41.Text = ds.Tables["course"].Rows[0][3].ToString();
                num42.Text = ds.Tables["course"].Rows[1][3].ToString();
                num43.Text = ds.Tables["course"].Rows[2][3].ToString();
                num44.Text = ds.Tables["course"].Rows[3][3].ToString();
                num45.Text = ds.Tables["course"].Rows[4][3].ToString();
                num46.Text = ds.Tables["course"].Rows[5][3].ToString();

                num51.Text = ds.Tables["course"].Rows[0][4].ToString();
                num52.Text = ds.Tables["course"].Rows[1][4].ToString();
                num53.Text = ds.Tables["course"].Rows[2][4].ToString();
                num54.Text = ds.Tables["course"].Rows[3][4].ToString();
                num55.Text = ds.Tables["course"].Rows[4][4].ToString();
                num56.Text = ds.Tables["course"].Rows[5][4].ToString();

                num61.Text = ds.Tables["course"].Rows[0][5].ToString();
                num62.Text = ds.Tables["course"].Rows[1][5].ToString();
                num63.Text = ds.Tables["course"].Rows[2][5].ToString();
                num64.Text = ds.Tables["course"].Rows[3][5].ToString();
                num65.Text = ds.Tables["course"].Rows[4][5].ToString();
                num66.Text = ds.Tables["course"].Rows[5][5].ToString();

                num71.Text = ds.Tables["course"].Rows[0][6].ToString();
                num72.Text = ds.Tables["course"].Rows[1][6].ToString();
                num73.Text = ds.Tables["course"].Rows[2][6].ToString();
                num74.Text = ds.Tables["course"].Rows[3][6].ToString();
                num75.Text = ds.Tables["course"].Rows[4][6].ToString();
                num76.Text = ds.Tables["course"].Rows[5][6].ToString();

                label8.Text = ds1.Tables["bz"].Rows[0][0].ToString();
            
            
           
        }
        //public static class Course
        //{
            
        //    //星期1
        //    public static string num11 = "";
        //    public static string num12 = "";
        //    public static string num13 = "";
        //    public static string num14 = "";
        //    public static string num15 = "";
        //    public static string num16 = "";
        //    //星期2

        //    public static string num21 = "";
        //    public static string num22 = "";
        //    public static string num23 = "";
        //    public static string num24 = "";
        //    public static string num25 = "";
        //    public static string num26 = "";
        //    //星期3

        //    public static string num31 = "";
        //    public static string num32 = "";
        //    public static string num33 = "";
        //    public static string num34 = "";
        //    public static string num35 = "";
        //    public static string num36 = "";
        //    //星期4

        //    public static string num41 = "";
        //    public static string num42 = "";
        //    public static string num43 = "";
        //    public static string num44 = "";
        //    public static string num45 = "";
        //    public static string num46 = "";
        //    //星期5

        //    public static string num51 = "";
        //    public static string num52 = "";
        //    public static string num53 = "";
        //    public static string num54 = "";
        //    public static string num55 = "";
        //    public static string num56 = "";
        //    //星期6
        //    public static string num61 = "";
        //    public static string num62 = "";
        //    public static string num63 = "";
        //    public static string num64 = "";
        //    public static string num65 = "";
        //    public static string num66 = "";
        //    //星期7
        //    public static string num71 = "";
        //    public static string num72 = "";
        //    public static string num73 = "";
        //    public static string num74 = "";
        //    public static string num75 = "";
        //    public static string num76 = "";

        //    public static string remark = "暂无";
        //}
    }
}
