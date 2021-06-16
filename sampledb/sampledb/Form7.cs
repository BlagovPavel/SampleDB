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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sampleDbDataSet4.Department". При необходимости она может быть перемещена или удалена.
            this.departmentTableAdapter.Fill(this.sampleDbDataSet4.Department);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Products s = new Products();
            s.Show();
        }
    }
}
