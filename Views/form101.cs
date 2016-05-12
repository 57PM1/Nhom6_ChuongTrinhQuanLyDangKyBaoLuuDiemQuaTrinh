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


namespace QuanLiDuAn
{
    public partial class form101 : Form
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GJ9RE6M\SQLEXPRESS;Initial Catalog=ThuHocPhi;Integrated Security=True");
        public form101()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void form101_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            fill_grid();
        }
        public void fill_grid()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [THUHOCPHI].[dbo].[HocKy]";
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
