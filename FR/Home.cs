using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;
using System.IO;
using System.Security.Cryptography;
using System.Reflection;

namespace StoreFront.FR
{
    public partial class Home : Form
    {
        private static string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static string strConnstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename="+directory+"\\resources\\data.mdf;Integrated Security=True";
        private static SqlConnection connection = new SqlConnection(strConnstring);
        private static SqlDataAdapter adapter = new SqlDataAdapter("select * from user", strConnstring);
        private static SqlCommand command;
        private static SqlDataReader reader;
        string fullpath;
        



        public Home()
        {
           
            InitializeComponent();
            load_info();

        }
       
       //Loads some text from login and machine table
        private void load_info() 
        {
            int num = 0;
            string date = "";
            string time = "";

            //A) Gets the last login number from the login table
            connection.Open();
            string sql = "select Number from [login] ";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {


                num = reader.GetInt32(0);

            }
            connection.Close();

            //B) Gets the user, welcome txt and login txt from the machine table
            connection.Open();
            sql = "select ActiveUser,LoginText,WelcomeText from [Machine]";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read()) { lbl_name.Text = reader.GetString(0); lbl_clocked.Text = reader.GetString(1); lbl_welcome.Text = reader.GetString(2); }   
            connection.Close();

            //C)Uses the num(last login number) to get a specific Date-In & Time-In from login
            connection.Open();
            sql = "select DateIn,TimeIn from [login] where Number=" + num + "";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read()) { date = reader.GetString(0); time = reader.GetString(1); }

            connection.Close();

            lbl_date.Text = date; lbl_time.Text = time;
        }

       
       
    }
}
