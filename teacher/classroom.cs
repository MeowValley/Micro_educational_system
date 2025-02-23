using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satelliteeducationsystem.teacher
{
    public partial class classroom : Form
    {
        public classroom()
        {
            InitializeComponent();
        }

        private void classroom_Load(object sender, EventArgs e)
        {
            DataSet ds=Method.query_classroom();
            classroomlist.DataSource = ds.Tables["classroom"];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < classroomlist.Rows.Count; i++)
            {
                try
                {
                    Method.updateclassroom_teacher( classroomlist.Rows[i].Cells["crid"].Value.ToString(), classroomlist.Rows[i].Cells["roomnumber"].Value.ToString(), classroomlist.Rows[i].Cells["state"].Value.ToString());

                }
                catch
                {

                }

            }
            MessageBox.Show("更新成功");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text.Equals("显示空闲教室"))
            {
                DataSet ds1 = Method.query_state_classroom();
                classroomlist.DataSource = ds1.Tables["classroom"];
                button2.Text = "显示全部教室";
            }
            else if (button2.Text.Equals("显示全部教室"))
            {
                DataSet ds = Method.query_classroom();
                classroomlist.DataSource = ds.Tables["classroom"];
                button2.Text = "显示空闲教室";
            }
        }

        private void classroomlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
