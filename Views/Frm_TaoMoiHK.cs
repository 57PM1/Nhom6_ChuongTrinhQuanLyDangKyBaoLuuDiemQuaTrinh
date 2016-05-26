using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiDuAn.Views;
using System.Data.SqlClient;

namespace QuanLiDuAn
{
    public partial class TaoMoiHK : Form
    {
        public TaoMoiHK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GJ9RE6M\\SQLEXPRESS;Initial Catalog=ThuHocPhi;Integrated Security=True");
            con.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("insert into [ThuHocPHi].[dbo].[HocKy] (HocKy,HocPhi) values('" + textBox1.Text + "', '" + textBox2.Text + "')", con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Tao moi thanh cong!!!");
        }
    }
}
