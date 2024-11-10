using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StoreFront.FR
{
    public partial class Confirm : Form
    {
        private static string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static string strConnstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + directory + "\\resources\\data.mdf;Integrated Security=True";
        private static SqlConnection connection = new SqlConnection(strConnstring);

        private static SqlCommand command;
        private static SqlDataReader reader;
        int fuckthis=1;
        public Confirm()
        {
            InitializeComponent();
        }

        private void Confirm_Load(object sender, EventArgs e)
        {
            loading();
            fuckthis = Int32.Parse(lbl_id.Text.ToString());

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {



            //switch case
            //if there is more development for this project this part is going to be used for the payment confirmation code for each option  
            switch (get_payment(fuckthis))
            { 
                case "PayPal":
                    update();
                    break;
                case "Credit":
                    update();
                    break;
                case "Debit":
                    update();
                    break;

                case "Cash":
                    update();
                    break;

            }
           


        }

        private void loading()
        {
            string name = "PlaceHolder";
            string user = "PlaceHolder";
            string d = DateTime.Now.ToLongDateString();
            int backgroundone = 0;
            int backgroundtwo = 0;
            int backgroundthree = 0;
            //machine
            connection.Open();
            string sql = "select ActiveUser,Theme from [Machine]";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                user = reader.GetString(0);
                name = reader.GetString(1);



            }
            connection.Close();
            //theme
            connection.Open();
            sql = "select BackGroundOne, BackGroundTwo,BackGroundThree from [theme] where ThemeName ='" + name + "'";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                backgroundone = reader.GetInt32(0);
                backgroundtwo = reader.GetInt32(1);
                backgroundthree = reader.GetInt32(2);
            }
            connection.Close();

            //sales
            connection.Open();
            sql = "select Id, Payment, Total from [sales] where UserName='"+user+"' and Date = '"+d+"'";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                lbl_id.Text = reader.GetInt32(0).ToString();
                fuckthis = reader.GetInt32(0);
                lbl_payment.Text = reader.GetString(1);
                lbl_total.Text = reader.GetDouble(2).ToString();



            }
            connection.Close();


            this.BackColor = Color.FromArgb(backgroundone, backgroundtwo, backgroundthree);
           


        }

        private string get_payment(int id) 
        {
            string r = "placeholder";
            connection.Open();
            string sql = "select Payment from [sales] where Id="+id+"";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                r=reader.GetString(0);



            }
            connection.Close();
            return r;
        }

        private void update() 
        {
          
            SqlCommand cmd = new SqlCommand("update sales set Confirm=@c where Id=" +fuckthis + "", connection);
            connection.Open();

            cmd.Parameters.AddWithValue("@c", "Yes");

            cmd.ExecuteNonQuery();

            connection.Close();
            this.Close();

        }
       
    }
}
