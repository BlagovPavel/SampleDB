using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sampledb
{
    public partial class Projects : Form
    {
        public Projects()
        {
            InitializeComponent();
        }

        private void Projects_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sampleDbDataSet2.Project". При необходимости она может быть перемещена или удалена.
            this.projectTableAdapter.Fill(this.sampleDbDataSet2.Project);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorksOn s = new WorksOn();
            s.Show();
        }
    }
}
