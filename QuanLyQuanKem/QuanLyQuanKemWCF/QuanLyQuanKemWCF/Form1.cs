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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChucNang frm_cn = new ChucNang();
            frm_cn.Show();
            frm_cn.FormClosing += Frm_cn_FormClosing;
        }

        private void Frm_cn_FormClosing(object sender, FormClosingEventArgs e)
        {
           this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TimKiem frm_tk = new TimKiem();
            frm_tk.Show();
            frm_tk.FormClosing += Frm_cn_FormClosing;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongKe frm_thk = new ThongKe();
            frm_thk.Show();
            frm_thk.FormClosing += Frm_cn_FormClosing;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure","warning",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.Tomato;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor= Color.Red;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Violet;
        }
    

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Fuchsia;        
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightYellow;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Yellow;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightGreen;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Lime;
        }
    }
}
