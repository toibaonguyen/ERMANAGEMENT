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
    public partial class StaffControl : UserControl
    {
        public StaffControl()
        {
            InitializeComponent();
        }
        private string SN;
        public string StaffName 
        { get { return SN; }
          set { SN = value; name.Text = value; } 
        }
        private string SI;
        public string StaffID
        {
            get { return SI; }
            set { SI = value; cmnd.Text = value; }
        }
        private string SP;
        public string Staffposition
        {
            get { return SP; }
            set { SP = value; position.Text = value; }
        }

        private string SA;
        public string Staffage
        {
            get { return SA; }
            set { SA = value; age.Text = value; }
        }
        private string SS;
        public string Staffstartday
        {
            get { return SS; }
            set { SS = value; startdatee.Text = value; }
        }




        private Image anh;
        public Image ANH
        {
            get { return anh; }
            set { anh = value; anh1.Image = value; }
        }
        public bool checky;


        private void StaffControl_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void StaffControl_Load(object sender, EventArgs e)
        {

        }

        private void StaffControl_Click(object sender, EventArgs e)
        {
            checkradiobutton.Checked = !checkradiobutton.Checked;
            if (checkradiobutton.Checked==true)
            {
                checky = true;
            }
            else
            {
                checky = false;
            }
        }



        private void checkradiobutton_CheckedChanged(object sender, EventArgs e)
        {
            if (checkradiobutton.Checked == true)
            {
                checky = true;
            }
            else
            {
                checky = false;
            }
        }

        private void StaffControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

        }
    }
}
