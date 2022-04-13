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
    public partial class StaffmanagementS : Form
    {
        public StaffmanagementS()
        {
            InitializeComponent();
        }
        private ConnectData c;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Formaddstaff a=new Formaddstaff();
            a.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            foreach(Control co in flowLayoutPanel1.Controls)
            {
                if(co.GetType() == typeof(StaffControl))
                {
                    StaffControl okela= (StaffControl)co;
                    if (okela.checky == true)
                    {
                        ConnectData m=new ConnectData();
                        m.connect();
                        if(m.exeSQL("delete from staff where CMND = '"+okela.StaffID+"'"))
                        {
                            
                            
                        }
                        m.disconnect();

                    }
                  
                }
            }
            showdata("");
        }
        private void showdata(string m)
        {
            flowLayoutPanel1.Controls.Clear();
            c = new ConnectData();
            c.connect();
            DataSet ds = new DataSet();
            string sq = "select * from staff where TEN like '" + m + "%'";
            SqlDataAdapter k = new SqlDataAdapter(sq, c.conn);
            k.Fill(ds);
            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataRow row in dt.Rows)
                {
                    var uc = new StaffControl
                    {
                        
                        StaffID = row["CMND"].ToString(),
                        StaffName = row["TEN"].ToString(),
                        Staffposition = row["chucvu"].ToString(),
                        Staffage = row["ngaysinh"].ToString(),
                        Staffstartday = row["ngaybatdaulam"].ToString(),
                        ANH = ClassDoSomethingWithImage.Base64ToImage(row["anh"].ToString())

                    };
                    flowLayoutPanel1.Controls.Add(uc);

                }
            }

        }

        private void StaffmanagementS_Load(object sender, EventArgs e)
        {
            showdata("");
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            showdata(guna2TextBox1.Text);
        }
    }
}
