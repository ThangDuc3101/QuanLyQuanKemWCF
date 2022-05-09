using QuanLyQuanKemWCF.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanKemWCF
{
    public partial class TimKiem : Form
    {
        public TimKiem()
        {
            InitializeComponent();
        }
        Service1Client client;
        private void button1_Click(object sender, EventArgs e)
        {
            client = new Service1Client();
            Ice_cream ice = new Ice_cream() {Id = Convert.ToInt32(textBox1.Text)};
            dataGridView1.DataSource = client.findIceCream(ice);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure", "warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
