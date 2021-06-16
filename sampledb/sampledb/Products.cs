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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sampleDbDataSet1.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.sampleDbDataSet1.Product);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Projects s = new Projects();
            s.Show();
        }
    }
}
