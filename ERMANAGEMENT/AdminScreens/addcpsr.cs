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
namespace ERMANAGEMENT.AdminScreens
{

    public partial class addcpsr : Form
    {
        private string iddd;
        public addcpsr()
        {
            InitializeComponent();
        }



        private void showdata(string m)
        {
            ConnectData cc = new ConnectData();
            cc.connect();
            DataSet ds = new DataSet();
            string q = "select IDkhachhang 'ID',TEN 'Tên khách hàng',Ngaydangky 'Ngày đăng ký',CP from Khachhang where IDkhachhang like'" + m + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(q, cc.conn);
            adapter.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
            cc.disconnect();

        }

        private void addcpsr_Load(object sender, EventArgs e)
        {
            showdata("");

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            string t = guna2TextBox2.Text;
            showdata(t);
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            guna2TextBox1.Text = guna2DataGridView1.Rows[numrow].Cells[3].Value.ToString();
            iddd= guna2DataGridView1.Rows[numrow].Cells[0].Value.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ConnectData cc = new ConnectData();
            cc.connect();
            DataSet ds = new DataSet();
            string q = "update Khachhang set CP='"+guna2TextBox1.Text+"' where IDkhachhang='" + iddd + "'";
            if (cc.exeSQL(q))
            {
                MessageBox.Show("Success!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showdata("");
            }
            else
            {
                MessageBox.Show("Error!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


            cc.disconnect();
            showdata("");
        }
    }
}
