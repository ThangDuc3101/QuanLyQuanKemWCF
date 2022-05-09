using QuanLyQuanKemWCF.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanKemWCF
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        Service1Client client;
        private void button1_Click(object sender, EventArgs e)
        {
            client = new Service1Client();
            dataGridView1.DataSource = client.banduoc();
        }

       


        private void button2_Click(object sender, EventArgs e)
        {
            client = new Service1Client();
            dataGridView1.DataSource = client.tonlai();
        }
    

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure", "warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Thang\OneDrive\Desktop\QuanLyQuanKem\QuanLyQuanKemWCF\QuanLyQuanKemWCF\iceCream.mdf;Integrated Security=True");
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter("Select name,numberOrder from tbl_IceCream", con);
            con.Open();
            dap.Fill(dt);
            con.Close();

            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Ten";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng đặt";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chart1.Series["Series1"].Points.AddXY(dt.Rows[i]["name"], dt.Rows[i]["numberOrder"]);

            }

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
