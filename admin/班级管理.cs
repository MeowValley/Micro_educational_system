using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satelliteeducationsystem.admin
{
    public partial class 班级管理 : Form
    {
        private string cid;//备份
        public 班级管理()
        {
            InitializeComponent();
        }

        private void 班级管理_Load(object sender, EventArgs e)
        {
           DataSet ds= Method.class_admin();
            classlist.DataSource = ds.Tables["class_admin"];
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < classlist.Rows.Count; i++)
            {
                try
                {
                    Method.updateclass(classlist.Rows[i].Cells["ccid"].Value.ToString(), classlist.Rows[i].Cells["cname"].Value.ToString());
                }
                catch
                {

                }
            }
            MessageBox.Show("更新成功！");
        }
    }
}
