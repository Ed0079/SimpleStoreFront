using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Xml.Linq;

namespace StoreFront
{

    public partial class Login : Form
    {

        private static string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static string strConnstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + directory + "\\resources\\data.mdf;Integrated Security=True";
        private static SqlConnection connection = new SqlConnection(strConnstring);

        private static SqlCommand command;
        private static SqlDataReader reader;
        Thread th;
        public Login()
        {
            InitializeComponent();
            load_color();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Length != 0 && txt_pw.Text.Length != 0)
            {
                if (checking_user(txt_name.Text.ToString(), txt_pw.Text.ToString()))
                {

                    set_login();
                    this.Close();
                    th = new Thread(Open_Form);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else { MessageBox.Show("Sorry, your login credentials are incorrect. Please try again."); }
            }
            else { MessageBox.Show("Please fill it in the required field."); }


        }

        private void Open_Form()
        {
            Application.Run(new MainForm());
        }

        //checks if user & pw are valid
        private Boolean checking_user(string name, string pw)
        {
            Boolean checking = false;
            connection.Open();
            string sql = "select Name, Password from [user] ";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {


                if (name == reader.GetString(0) && pw == reader.GetString(1)) { checking = true; }

            }
            connection.Close();
            return checking;

        }
        //sets the active user in the machine table and starts a login report
        private void set_login()
        {
            int id = 0;
            int number = 0;
            string ps = "";
            string name = txt_name.Text;
            string date = DateTime.Now.ToLongDateString();
            string time = DateTime.Now.ToLongTimeString();
            connection.Open();
            string sql = "select Id,Position from [user] where Name ='" + name + "'";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {

                id = reader.GetInt32(0);

                ps = reader.GetString(1);


            }
            connection.Close();




            SqlCommand cmd = new SqlCommand("update Machine set ActiveUser=@au,UserPosition=@up where id = '" + 0 + "'", connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@au", txt_name.Text.ToString());
            cmd.Parameters.AddWithValue("@up", ps);
            cmd.ExecuteNonQuery();
            connection.Close();


            connection.Open();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT login ( IdOfUser, Name, DateIn, TimeIn) VALUES (" + id + ",'" + txt_name.Text.ToString() + "','" + date + "','" + time + "')";
            command.ExecuteNonQuery();
            connection.Close();


        }

        private void load_color()
        {

            string name = "PlaceHolder";
            string pname = "PlaceHolder";
            int headerone = 0;
            int headertwo = 0;
            int headerthree = 0;
            int backgroundone = 0;
            int backgroundtwo = 0;
            int backgroundthree = 0;
            //First) Machine Table
            connection.Open();
            string sql = "select Theme,ProgramName from [Machine]";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                name = reader.GetString(0);
                pname = reader.GetString(1);

            }
            connection.Close();

            //Seconde Theme Table
            connection.Open();
            sql = "select BackGroundOne, BackGroundTwo, BackGroundThree from [theme] where ThemeName ='" + name + "'";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
               
                backgroundone = reader.GetInt32(0);
                backgroundtwo = reader.GetInt32(1);
                backgroundthree = reader.GetInt32(2);




            }
            connection.Close();

           
            this.BackColor = Color.FromArgb(backgroundone, backgroundtwo, backgroundthree);
           
            this.Text = pname;
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (txt_pw.Text.Length == 0) { txt_pw.Focus(); }
                else { btn_enter_Click(sender, e); }
            }
        }

        private void txt_pw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (txt_name.Text.Length == 0) { txt_name.Focus(); }
                else { btn_enter_Click(sender, e); }
            }
        }
    }
}
