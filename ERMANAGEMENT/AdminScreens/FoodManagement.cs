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
    public partial class FoodManagement : Form
    {
        public FoodManagement()
        {
            InitializeComponent();
            showdata("");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ConnectData connectData = new ConnectData();
            connectData.connect();
            string s = "insert into Foodanddrink values ('" + id.Text + "','" + ten.Text + "','" + gia.Text + "','" + ClassDoSomethingWithImage.ImageToBase64(pictureBox1.Image, System.Drawing.Imaging.ImageFormat.Png) + "')";
            
            if(connectData.exeSQL(s))
            {
                MessageBox.Show("Success!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showdata("");
            }
            else
            {
                MessageBox.Show("Error!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connectData.disconnect();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ConnectData connectData = new ConnectData();
            connectData.connect();
            string s = "update Foodanddrink SET TEN ='" + ten.Text + "',COST='" + gia.Text + "',anh='" + ClassDoSomethingWithImage.ImageToBase64(pictureBox1.Image, System.Drawing.Imaging.ImageFormat.Png) + "' where IDmonan = '"+id.Text+"'";

            if (connectData.exeSQL(s))
            {
                MessageBox.Show("Success!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showdata("");
            }
            else
            {
                MessageBox.Show("Error!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connectData.disconnect();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image ula = new Bitmap(ofd.FileName);
                pictureBox1.Image = new Bitmap(ula, new Size(138, 138));

            }
        }
       
        private void showdata(string m)
        {
            ConnectData cc = new ConnectData();
            cc.connect();
            DataSet ds = new DataSet();
            string q = "select IDmonan 'ID',TEN 'Tên món ăn',COST 'Giá' from Foodanddrink where IDmonan like'" + m + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(q, cc.conn);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            cc.disconnect();
            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            showdata(guna2TextBox1.Text);

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            ConnectData connectData = new ConnectData();
            connectData.connect();
            string s = "delete from Foodanddrink" + " where IDmonan = '" + id.Text + "'";

            if (connectData.exeSQL(s))
            {
                MessageBox.Show("Success!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showdata("");
            }
            else
            {
                MessageBox.Show("Error!", "Đã xảy ra va chạm trong csdl, không thể xóa dữ liệu này!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connectData.disconnect();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow=e.RowIndex;
            id.Text = dataGridView1.Rows[numrow].Cells[0].Value.ToString();
            ten.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
            gia.Text = dataGridView1.Rows[numrow].Cells[2].Value.ToString();
            ConnectData c = new ConnectData();
            c.connect();
            DataSet ds = new DataSet();
            string sq = "select anh from Foodanddrink where IDmonan= '" + dataGridView1.Rows[numrow].Cells[0].Value.ToString() + "'";
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
    }
}
