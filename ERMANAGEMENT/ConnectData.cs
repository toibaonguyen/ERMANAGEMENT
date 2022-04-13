using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ERMANAGEMENT
{
    internal class ConnectData
    {
        public SqlConnection conn;
        public void connect()
        {
            string strCon = QueueOF.conn;
            try
            {
                conn = new SqlConnection(strCon);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void disconnect()
        {
            conn.Close();
            conn.Dispose();
            conn = null;
        }
        public bool exeSQL(string cmd)
        {
            try
            {
                SqlCommand sc = new SqlCommand(cmd, conn);
                sc.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
    }
}
