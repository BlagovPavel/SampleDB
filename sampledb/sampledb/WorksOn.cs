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
    public partial class WorksOn : Form
    {
        public WorksOn()
        {
            InitializeComponent();
        }

        private void WorksOn_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sampleDbDataSet3.Works_on". При необходимости она может быть перемещена или удалена.
            this.works_onTableAdapter.Fill(this.sampleDbDataSet3.Works_on);

        }
    }
}
