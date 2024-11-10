using StoreFront.FR;
using StoreFront.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace StoreFront
{
    public partial class MainForm : Form
    {
        private static string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static string strConnstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + directory + "\\resources\\data.mdf;Integrated Security=True";
        private static SqlConnection connection = new SqlConnection(strConnstring);

        private static SqlCommand command;
        private static SqlDataReader reader;

        private Form activeForm;
        public MainForm()
        {
            
           
            
            InitializeComponent();
            loading();

            btn_home_Click(this, EventArgs.Empty);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
          
            


        }
        
  
       
     //Buttons
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cr_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FR.Cash_Register(), sender);
            btn_cr.BackColor = this.BackColor;
            btn_storage.BackColor = Panel_Menu.BackColor;
            btn_ir.BackColor = Panel_Menu.BackColor;
            btn_setting.BackColor = Panel_Menu.BackColor;

        }

        private void btn_storage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FR.Storage(), sender);
            btn_cr.BackColor = Panel_Menu.BackColor;
            btn_storage.BackColor = this.BackColor;
            btn_ir.BackColor = Panel_Menu.BackColor;
            btn_setting.BackColor = Panel_Menu.BackColor;
        }
        private void btn_ir_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FR.Incident_Report(), sender);
            btn_cr.BackColor = Panel_Menu.BackColor;
            btn_storage.BackColor = Panel_Menu.BackColor;
            btn_ir.BackColor = this.BackColor;
            btn_setting.BackColor = Panel_Menu.BackColor;

        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FR.Setting(), sender);
            btn_cr.BackColor = Panel_Menu.BackColor;
            btn_storage.BackColor = Panel_Menu.BackColor;
            btn_ir.BackColor = Panel_Menu.BackColor;
            btn_setting.BackColor = this.BackColor;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FR.Home(), sender);
            btn_cr.BackColor = Panel_Menu.BackColor;
            btn_storage.BackColor = Panel_Menu.BackColor;
            btn_ir.BackColor = Panel_Menu.BackColor;
            btn_cr.BackColor = Panel_Menu.BackColor;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            int num = 0;
            connection.Open();
            string sql = "select Number from [login] ";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {


                num = reader.GetInt32(0);

            }

            connection.Close();
            string date = DateTime.Now.ToLongDateString();
            string time = DateTime.Now.ToLongTimeString();
            SqlCommand cmd = new SqlCommand("update login set DateOut =@do , TimeOut =@to where Number=" + num + "", connection);
            connection.Open();

            cmd.Parameters.AddWithValue("@do", date);
            cmd.Parameters.AddWithValue("@to", time);



            cmd.ExecuteNonQuery();


            connection.Close();
        }


        
        //It Loads the color for the background & the menu
        private void loading() 
        {
           
            string name ="PlaceHolder";
            string pname ="PlaceHolder";
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
            sql = "select HeaderOne, HeaderTwo, HeaderThree, BackGroundOne, BackGroundTwo, BackGroundThree from [theme] where ThemeName ='" + name+ "'";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                headerone = reader.GetInt32(0);
                headertwo = reader.GetInt32(1);
                headerthree = reader.GetInt32(2);
                backgroundone = reader.GetInt32(3);
                backgroundtwo = reader.GetInt32(4);
                backgroundthree = reader.GetInt32(5);




            }
            connection.Close();

            //setting color 
            Panel_Menu.BackColor = Color.FromArgb(headerone,headertwo,headerthree);
            this.BackColor = Color.FromArgb(backgroundone, backgroundtwo, backgroundthree);
            panel_desktop.BackColor = Color.FromArgb(backgroundone, backgroundtwo, backgroundthree);
            
            btn_home.BackColor = Panel_Menu.BackColor;
            btn_cr.BackColor = Panel_Menu.BackColor;
            btn_storage.BackColor = Panel_Menu.BackColor;
            btn_ir.BackColor = Panel_Menu.BackColor;
            btn_setting.BackColor = Panel_Menu.BackColor;
            this.Text = pname;

        }

        //finishes the login report
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_desktop.Controls.Add(childForm);
            this.panel_desktop.Tag = childForm;
            childForm.BackColor = this.BackColor;
            childForm.BringToFront();
            childForm.Show();


        }


    }
}
