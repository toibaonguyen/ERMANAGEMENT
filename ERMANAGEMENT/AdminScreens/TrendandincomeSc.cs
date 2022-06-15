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
    public partial class TrendandincomeSc : Form
    {
        public TrendandincomeSc()
        {
            InitializeComponent();
        }
        private void fillchar()
        {



            ConnectData cc = new ConnectData();
            cc.connect();
            DataSet ds = new DataSet();
            string s = "SELECT MONTH(NGAY)'Thang',SUM(COST*soluong)'Doanh so' FROM orders inner join Foodanddrink on orders.IDmonan=Foodanddrink.IDmonan inner join bill on orders.IDbill= bill.IDbill GROUP BY MONTH(NGAY)";

            SqlDataAdapter adapter = new SqlDataAdapter(s,cc.conn);
            adapter.Fill(ds);
            chart1.DataSource = ds;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "ID món ăn";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Giá món ăn";


            chart1.Series["COST"].XValueMember = "Thang";
            chart1.Series["COST"].YValueMembers = "Doanh so";
            cc.disconnect();

        }
        private void fillchar2()
        {



            ConnectData cc = new ConnectData();
            cc.connect();
            DataSet ds = new DataSet();
            string s = "SELECT TOP 10 IDmonan,SOLUONG , RANK() OVER (ORDER BY SOLUONG DESC) AS DS_RANK FROM (SELECT IDmonan, COUNT(IDmonan) as SOLUONG FROM orders GROUP BY IDmonan) a";

            SqlDataAdapter adapter = new SqlDataAdapter(s, cc.conn);
            adapter.Fill(ds);
            chart2.DataSource = ds;
            chart2.ChartAreas["ChartArea1"].AxisX.Title = "ID món ăn";
            chart2.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng";


            chart2.Series["Số lượng"].XValueMember = "IDmonan";
            chart2.Series["Số lượng"].YValueMembers = "SOLUONG";
            cc.disconnect();

        }
        private void TrendandincomeSc_Load(object sender, EventArgs e)
        {
            fillchar();
            fillchar2();
        }
    }
}
