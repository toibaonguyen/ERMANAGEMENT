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

namespace ERMANAGEMENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Button currentButton;

        private Form activeForm;

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectData c = new ConnectData();
                c.connect();
                string q = "select * from accountad where username='" + guna2TextBox1.Text + "' and pass='" + guna2TextBox2.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(q, c.conn);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read() == true)
                {
                    MessageBox.Show("Login successfully.", "Success!",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OpenChildForm(new AdminScreen());

                }
                else
                {
                    MessageBox.Show("Username or password is incorrect, please try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    guna2TextBox2.Text = "";
                    guna2TextBox2.Focus();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!", ex.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            this.panel2.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Staff.Waiter());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Staff.Chef());
        }
    }
}
