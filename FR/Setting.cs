using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StoreFront.FR
{
    public partial class Setting : Form
    {
        private static string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static string strConnstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + directory + "\\resources\\data.mdf;Integrated Security=True";
        private static SqlConnection connection = new SqlConnection(strConnstring);

        private static SqlCommand command;
        private static SqlDataReader reader;
        private Form activeForm;
      
        public Setting()
        {
            InitializeComponent();
            loading();
            
            btn_st1_Click(this, EventArgs.Empty);
            access_levels();
        }
        //buttons
        private void btn_st1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new subforms.S1(), sender);
            btn_st1.BackColor = this.BackColor;
            btn_st2.BackColor = panel_minimenu.BackColor;
            cbox_table.BackColor = panel_minimenu.BackColor;

        }

        private void btn_st2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new subforms.S3(), sender);
            btn_st2.BackColor = this.BackColor;
            btn_st1.BackColor = panel_minimenu.BackColor;
            cbox_table.BackColor = panel_minimenu.BackColor;
        }

        private void cbox_table_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbox_table.BackColor = this.BackColor;
            btn_st2.BackColor = panel_minimenu.BackColor;
            btn_st1.BackColor = panel_minimenu.BackColor;
            switch (cbox_table.SelectedItem.ToString().Split(new string[] { ": " }, StringSplitOptions.None).Last())
            {
                case "-Users-":
                    OpenChildForm(new subforms.S2(), sender);

                    break;
                case "-Logins-":
                    OpenChildForm(new subforms.S4(), sender);
                 
                    break;
                case "-Colors-":
                    OpenChildForm(new subforms.S5(), sender);
                   
                    break;
                case "-Reports-":
                    OpenChildForm(new subforms.S6(), sender);
                    
                    break;
                case "-Machine-":
                    OpenChildForm(new subforms.S7(), sender);
                   
                    break;
                case "-Taxes & Discounts-":
                    OpenChildForm(new subforms.S8(), sender);
                   
                    break;
                case "-Sales-":
                    OpenChildForm(new subforms.S9(), sender);
                  
                    break;
            }


            btn_st2.BackColor = panel_minimenu.BackColor;
            btn_st1.BackColor = panel_minimenu.BackColor;
        }
        
        //methods
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

        private void loading()
        {
            
            string name = "PlaceHolder";
            int [] codearray = new int[6];
            
           
            connection.Open();
            string sql = "select Theme from [Machine]";


            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                name = reader.GetString(0);



            }

            connection.Close();

            connection.Open();
            sql = "select BackGroundOne, BackGroundTwo, BackGroundThree, SideBarOne, SideBarTwo, SideBarThree from [theme] where ThemeName ='" + name + "'";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                codearray[0] = reader.GetInt32(0);
                codearray[1] = reader.GetInt32(1);
                codearray[2] = reader.GetInt32(2);

                codearray[3] = reader.GetInt32(3);
                codearray[4] = reader.GetInt32(4);
                codearray[5] = reader.GetInt32(5);





            }

            connection.Close();
            this.BackColor = Color.FromArgb(codearray[0], codearray[1], codearray[2]);
            panel_minimenu.BackColor = Color.FromArgb(codearray[3], codearray[4], codearray[5]);
            cbox_table.BackColor = panel_minimenu.BackColor;
            



        }

        private void access_levels()
        {
            //Don't know it just works
            string lvl = "None";
            string sql = "select ActiveUser from [Machine]";
            connection.Open ();
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read()) { lvl = reader.GetString(0); }
            connection.Close();

           
            sql = "select Position from [user] where Name ='" + lvl + "'";
            connection.Open();
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read()) { lvl = reader.GetString(0); }
            connection.Close();
            //-Users-
            //-Logins -
            //-Machine -
            //-Colors -
            //-Reports -
            //-Taxes & Discounts -
            //-Sales -


            if (lvl == "Admin") 
            {
               
                cbox_table.Items.Add("-Users-"); 
                cbox_table.Items.Add("-Logins-"); 
                cbox_table.Items.Add("-Machine-"); 
                cbox_table.Items.Add("-Colors-"); 
                cbox_table.Items.Add("-Reports-"); 
                cbox_table.Items.Add("-Taxes & Discounts-"); 
                cbox_table.Items.Add("-Sales-"); 
            }
            if (lvl=="Manager") 
            {
                cbox_table.Items.Add("-Users-");
                cbox_table.Items.Add("-Logins-");
                cbox_table.Items.Add("-Colors-");
                cbox_table.Items.Add("-Reports-");
                cbox_table.Items.Add("-Taxes & Discounts-");
                cbox_table.Items.Add("-Sales-");
            }
            if (lvl=="TeamLeader") 
            {
                cbox_table.Items.Add("-Users-");
                cbox_table.Items.Add("-Logins-");
                cbox_table.Items.Add("-Colors-");
                cbox_table.Items.Add("-Reports-");           
                cbox_table.Items.Add("-Sales-");
            }
            if (lvl=="Trainer") 
            {
                cbox_table.Items.Add("-Logins-");
                cbox_table.Items.Add("-Sales-");

            }
            if (lvl=="Employee") { cbox_table.Visible = false; }

        }
    }
}
