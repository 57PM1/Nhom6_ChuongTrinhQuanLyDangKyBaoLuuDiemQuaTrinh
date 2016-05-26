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
using QuanLiDuAn.Views;
using QuanLiDuAn.Connect;
using QuanLyDuAn.Common;

namespace QuanLiDuAn
{
    public partial class CapNhatHK : Form
    {
        public static SqlConnection CON = new SqlConnection("Data Source=DESKTOP-GJ9RE6M\\SQLEXPRESS;Initial Catalog=ThuHocPhi;Integrated Security=True");

        public CapNhatHK()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CON.Open();
            int tt;
            if (trangthai.Checked)
            {
                tt = 1;
            }
            else
            {
                tt = 0;
            }
            SqlDataAdapter SDA = new SqlDataAdapter("update HocKy set HocKy='" + hocky.Text + "', HocPhi='" + hocphi.Text + "', TrangThai ='" + tt + "' where HocKyID ='" + hockyID.Text + "'", CON);
            SDA.SelectCommand.ExecuteNonQuery();
            CON.Close();
            MessageBox.Show("Cap nhat thanh cong!!!");
            this.Close();
        }

        private void CapNhatHK_Load(object sender, EventArgs e)
        {
            hocky.Text = FormFactory.hocky.ToString();
            hockyID.Text = FormFactory.hockyid.ToString();
            hocphi.Text = FormFactory.hocphi.ToString();
            if (FormFactory.trangthai)
            {
                trangthai.Checked = true;
            }
            else
            {
                trangthai.Checked = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
