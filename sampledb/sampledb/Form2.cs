using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace sampledb
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CKVO6I1\SQLEXPRESS;Initial Catalog=SampleDb;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("Select Count (*) id From [Employee] Where id ='" + textBox1.Text + "'and FirstName = '" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")

            {
                Form7 f = new Form7();
                f.Show();
                this.Hide();
              
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }
        }
    }
