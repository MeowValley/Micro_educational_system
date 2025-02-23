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
    public partial class classroom : Form
    {
        public classroom()
        {
            InitializeComponent();
        }

        private void classroom_Load(object sender, EventArgs e)
        {
            DataSet ds=Method.query_state_classroom();
            classroomlist.DataSource = ds.Tables["classroom"];
        }
    }
}
