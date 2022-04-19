using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERMANAGEMENT
{
    public partial class AdminScreen : Form
    {
        private Button currentButton;
    
        private Form activeForm;
        public AdminScreen()
        {
            InitializeComponent();
            OpenChildForm(new AdminScreens.StaffmanagementS(), button1);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.Red;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel2.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(26, 32, 40);
                    
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminScreens.StaffmanagementS(),sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminScreens.FoodManagement(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminScreens.TrendandincomeSc(), sender);
        }
    }
}
