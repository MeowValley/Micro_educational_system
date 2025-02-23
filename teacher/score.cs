using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satelliteeducationsystem.teacher
{
    public partial class score : Form
    {
        public string cid;
        public score(string cid)
        {
            InitializeComponent();
            this.cid = cid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < scorelist.Rows.Count; i++)
            {
                try
                {
                    Method.updatescore(scorelist.Rows[i].Cells["学号"].Value.ToString(), scorelist.Rows[i].Cells["课程名称"].Value.ToString(), scorelist.Rows[i].Cells["成绩"].Value.ToString(),cid,scorelist.Rows[i].Cells["姓名"].Value.ToString());

                }
                catch
                {

                }

            }
            MessageBox.Show("更新成功");
        }

        private void score_Load(object sender, EventArgs e)
        {
            DataSet ds = Method.teacher_score(cid);
            scorelist.DataSource = ds.Tables["score"];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Method.changestate("1", cid))
            {
                MessageBox.Show("已开放成绩查询！");
            }
            else
            {
                MessageBox.Show("开启失败");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Method.changestate("0", cid))
            {
                MessageBox.Show("已关闭成绩查询！");
            }
            else
            {
                MessageBox.Show("关闭失败");
            }
        }
    }
}
