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
    public partial class 密钥管理 : Form
    {
        public 密钥管理()
        {
            InitializeComponent();
        }

        private void 密钥管理_Load(object sender, EventArgs e)
        {
            DataSet ds = Method.code_admin();
            codelist.DataSource = ds.Tables["key"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <codelist.Rows.Count; i++)
            {
                try
                {
                    Method.updatekey(codelist.Rows[i].Cells["code"].Value.ToString(), codelist.Rows[i].Cells["state"].Value.ToString(), codelist.Rows[i].Cells["type"].Value.ToString());
                }
                catch
                {

                }
            }
            MessageBox.Show("更新成功！");
        }
    }
}
