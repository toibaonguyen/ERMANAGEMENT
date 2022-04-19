using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERMANAGEMENT.AdminScreens
{
    public partial class FoodManagement : Form
    {
        public FoodManagement()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ConnectData connectData = new ConnectData();
            connectData.connect();
            string s = "insert into Foodanddrink values ('" + id.Text + "','" + ten.Text + "','" + gia.Text + "','" + ClassDoSomethingWithImage.ImageToBase64(pictureBox1.Image, System.Drawing.Imaging.ImageFormat.Png) + "')";
            
            if(connectData.exeSQL(s))
            {
                MessageBox.Show("Success!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connectData.disconnect();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }
    }
}
