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
namespace ERMANAGEMENT.Staff
{
    public partial class Chef : Form
    {
        public Chef()
        {
            InitializeComponent();
            showdata("");
            guna2Button2.Visible = false;
        }
        private void showdata(string m)
        {
            ConnectData cc = new ConnectData();
            cc.connect();
            string d = "chua";
            DataSet ds = new DataSet();
            string q = "select IDmonan 'ID món ăn',soluong 'Số Lượng' from orders where IDmonan like '" + m + "%' and done like '" + d + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(q, cc.conn);
            adapter.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
            cc.disconnect();

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            label2.Text= "ID món ăn:" + guna2DataGridView1.Rows[numrow].Cells[0].Value.ToString();
            label3.Text = "Số lượng:"+guna2DataGridView1.Rows[numrow].Cells[1].Value.ToString();
            ConnectData c = new ConnectData();
            c.connect();
            DataSet ds = new DataSet();
            string sq = "select anh from Foodanddrink where IDmonan= '" + guna2DataGridView1.Rows[numrow].Cells[0].Value.ToString() + "'";
            SqlDataAdapter k = new SqlDataAdapter(sq, c.conn);
            k.Fill(ds);
            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataRow row in dt.Rows)
                {
                    pictureBox1.Image = ClassDoSomethingWithImage.Base64ToImage(row["anh"].ToString());
                }
            }
            c.disconnect();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            guna2Button2.Visible = true;
            guna2Button1.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            pictureBox1.Image=null;
            label2.Text = "ID món ăn:";
            label3.Text = "Số lượng:";
            guna2Button2.Visible=false;
            ConnectData connectData = new ConnectData();
            connectData.connect();
            string d = "hoan thanh";
            string s = "update orders set done ='" + d + "'";
            connectData.exeSQL(s);
            MessageBox.Show("Món ăn đã hoàn thành", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            showdata("");
            connectData.disconnect();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            showdata(guna2TextBox1.Text);
        }
    }
}
