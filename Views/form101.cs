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
using QuanLyDuAn.Common;

namespace QuanLiDuAn.Views
{
    public partial class Form101 : Form
    {
        public static SqlConnection CON = new SqlConnection("Data Source=DESKTOP-GJ9RE6M\SQLEXPRESS;Initial Catalog=ThuHocPhi;Integrated Security=True");
        public Form101()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form101_Load(object sender, EventArgs e)
        {
            if (CON.State == ConnectionState.Open)
            {
                CON.Close();
            }
            CON.Open();
            fill_grid();
        }
         public void fill_grid()
        {
            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [ThuHocPHi].[dbo].[HocKy] ";
            cmd.ExecuteNonQuery();
            DataTable DT = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter("select * from [ThuHocPHi].[dbo].[HocKy]", CON);
            SDA.Fill(DT);
            dataGridView1.DataSource = DT;
            CON.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TaoMoiHK t = new TaoMoiHK();
            t.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CON.Open();
            DataTable DT = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter("select * from [ThuHocPHi].[dbo].[HocKy]", CON);
            SDA.Fill(DT);
            dataGridView1.DataSource = DT;
            CON.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             int hockyid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            int hocky = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            double hocphi = double.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            bool trangthai;
            if ((bool)dataGridView1.Rows[e.RowIndex].Cells[3].Value)
            {
                 trangthai = true;
            }
            else
            {
                trangthai = false;
            }
            FormFactory.hocphi = hocphi;
            FormFactory.hockyid = hockyid;
            FormFactory.hocky = hocky;
            FormFactory.trangthai = trangthai;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CapNhatHK c = new CapNhatHK();
            c.ShowDialog();
        }
    }
}
