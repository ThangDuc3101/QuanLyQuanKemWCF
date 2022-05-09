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
    public partial class ChucNang : Form
    {
        public ChucNang()
        {
            InitializeComponent();
        }
        Service1Client client;
        private void button1_Click(object sender, EventArgs e)
        {
            client = new Service1Client();
            Ice_cream ice = new Ice_cream() {
                Id = Convert.ToInt32(textBox1.Text),
                Name = Convert.ToString(textBox2.Text),
                price = Convert.ToDecimal(textBox3.Text),
                numberorder = Convert.ToInt32(textBox4.Text),
            };
            if (client.addIceCream(ice)!=0)
            {
                MessageBox.Show("Thêm thành công");
                dataGridView1.DataSource = client.getIceCream();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            client = new Service1Client();
            Ice_cream ice = new Ice_cream()
            {
                Id = Convert.ToInt32(textBox1.Text),
                Name = Convert.ToString(textBox2.Text),
                price = Convert.ToDecimal(textBox3.Text),
                numberorder = Convert.ToInt32(textBox4.Text),
            };
            if (client.datKem(ice) != 0)
            {               
                MessageBox.Show(" Đặt thành công");
                dataGridView1.DataSource = client.getIceCream();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client = new Service1Client();
            Ice_cream ice = new Ice_cream()
            {
                Id = Convert.ToInt32(textBox1.Text),
                Name = Convert.ToString(textBox2.Text),
                price = Convert.ToDecimal(textBox3.Text),
                numberorder = Convert.ToInt32(textBox4.Text),
            };
            if (client.editIceCream(ice)!=0)
            {
                MessageBox.Show("Sửa thành công");
                dataGridView1.DataSource = client.getIceCream();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
             client = new Service1Client();
            Ice_cream ice = new Ice_cream()
            {
                Id = Convert.ToInt32(textBox1.Text),
                Name = Convert.ToString(textBox2.Text),
                price = Convert.ToDecimal(textBox3.Text),
                numberorder = Convert.ToInt32(textBox4.Text),
            };
            
            if (client.deleteIceCream(ice) != 0)
            {               
                MessageBox.Show(" Xóa thành côngg");
                dataGridView1.DataSource = client.getIceCream();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure", "warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1[0,e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            textBox4.Text = dataGridView1[2, e.RowIndex].Value.ToString();
        }

        private void ChucNang_Load(object sender, EventArgs e)
        {
            client = new Service1Client();
            dataGridView1.DataSource = client.getIceCream();
        }
    }
}
