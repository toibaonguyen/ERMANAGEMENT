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
    public partial class Formaddstaff : Form
    {
        public Formaddstaff()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
               Image ula= new Bitmap(ofd.FileName);
                anh.Image=new Bitmap(ula,new Size(151, 151));
                
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ConnectData cd = new ConnectData();

            cd.connect();
            bool check = cd.exeSQL("insert into staff values ('"+cmnd.Text+"','"+ten.Text+"','"+startdate.Text+"','"+birthday.Text+"','"+position.Text+"','"+ClassDoSomethingWithImage.ImageToBase64(anh.Image, System.Drawing.Imaging.ImageFormat.Png)+"')");
            if(check)
            {
                MessageBox.Show("Success !");
                
                
            }
            else
            {
                MessageBox.Show("Error !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            cd.disconnect();

        }

        private void Formaddstaff_Load(object sender, EventArgs e)
        {

        }

        private void Formaddstaff_FormClosing(object sender, FormClosingEventArgs e)
        {
      
        }
    }
}
