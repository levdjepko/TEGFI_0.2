using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace TEGFI_3
{
    public static class DBConnection
    {
        public static void CheckConnection(string id, string password)
        {
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = $"Server=3.227.166.251; database=U053QS; UID={id}; password={password}";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        public static bool ConnectToDatabase(string id, string password)
        {
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = $"Server=3.227.166.251; database=U053QS; UID={id}; password={password}";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Successful login!");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                return false;
            }
        }

    }
}
