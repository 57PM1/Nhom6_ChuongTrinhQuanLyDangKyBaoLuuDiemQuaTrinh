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
        string id;
        int id1;
        int delete_id;
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
            cmd.CommandText = "select * from [ThuHocPhi].[dbo].[HocKy]";
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells["HocKyID"].Value.ToString();
            if (id == "")
            {
                id1 = 0;
            }
            else
            {
                id1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["HocKyID"].Value.ToString());
            }
            if (id1 == 0)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [ThuHocPhi].[dbo].[HocKy] value('" + dataGridView1.Rows.[e.RowIndex].Cells["HocKyID"].Value.ToString() + "', '" +dataGridView1.Rows.[e.RowIndex].Cells.["HocKy"].Value.ToString()+"','" +dataGridView1.Rows.[e.RowIndex].Cells.["HocPhi"].Value.ToString()+"','" +dataGridView1.Rows.[e.RowIndex].Cells.["TrangThai"].Value.ToString()+"')";
                cmd.ExecuteNonQuery();
                fill_grid();
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText= "update [ThuHocPhi].[dbo].[HocKy] set name('" + dataGridView1.Rows.[e.RowIndex].Cells["HocKyID"].Value.ToString() + "', '" +dataGridView1.Rows.[e.RowIndex].Cells.["HocKy"].Value.ToString()+"','" +dataGridView1.Rows.[e.RowIndex].Cells.["HocPhi"].Value.ToString()+"','" +dataGridView1.Rows.[e.RowIndex].Cells.["TrangThai"].Value.ToString()+"')";
                cmd.ExecuteNonQuery();
                fill_grid();

            }
        }

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [ThuHocPhi].[dbo].[HocKy]  where id= " + delete_id + "";
            cmd.ExecuteNonQuery();
            fill_grid();

        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                delete_id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["HocKyID"].Value.ToString());
                this.contextMenuStrip1.Show(this.dataGridView1, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }
    }
}
