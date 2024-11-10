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

namespace StoreFront.FR.subforms
{
    public partial class S1 : Form
    {
        private static string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static string strConnstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + directory + "\\resources\\data.mdf;Integrated Security=True";
        private static SqlConnection connection = new SqlConnection(strConnstring);

        private static SqlCommand command;
        private static SqlDataReader reader;
        public S1()
        {
            InitializeComponent();
        }

       

        //buttons
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (cbox_theme.Text.ToString() == "Custom    ") { if (cbox_tc.Text.Length != 0 && cbox_sc.Text.Length != 0 && cbox_bc.Text.Length != 0 && cbox_hc.Text.Length != 0) { update_custom(); MessageBox.Show("Update has been successful restart the program to see results", "Update successful"); } else { MessageBox.Show("please select a color"); } }
            if (cbox_theme.Text.Length != 0) { update_theme(); MessageBox.Show("Update has been successful, restart the program to see results", "Update successful"); }
        }

        private void cbox_theme_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_theme(cbox_theme.Text.ToString());
            if (cbox_theme.Text.ToString() == "Custom    ") { cbox_hc.Enabled = true; cbox_bc.Enabled = true; cbox_tc.Enabled = true; cbox_sc.Enabled = true; }
            else { cbox_hc.Enabled = false; cbox_bc.Enabled = false; cbox_tc.Enabled = false; cbox_sc.Enabled = false; }
        }
        //methods :

        //loads
        private void S1_Load(object sender, EventArgs e)
        {
            loading();
            load_items();
            access_levels();
            string name = "PlaceHolder";
            connection.Open();
            string sql = "select Theme from machine";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {

                name = reader.GetString(0);



            }

            connection.Close();
            cbox_theme.SelectedIndex = cbox_theme.FindStringExact(name);
        }

        private void loading()
        {

            string name = "PlaceHolder";
            string position = "PlaceHolder";
            string id = "PlaceHolder";
            string time = "PlaceHolder";
            //Active user info
            connection.Open();
            string sql = "select ActiveUser,UserPosition from [Machine]";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                name = reader.GetString(0);
                position = reader.GetString(1);



            }
            connection.Close();
            //more user info
            connection.Open();
            sql = "select Id from [user] where Name='" + name + "' and Position='" + position + "'";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(0).ToString();

            }
            connection.Close();

            //clocked in
            connection.Open();
            sql = "select DateIn,TimeIn from [login] where Name='" + name + "'";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                time = reader.GetString(0)+","+ reader.GetString(1);

            }
            connection.Close();

            lbl_id.Text = id;
            lbl_name.Text = name;
            lbl_position.Text = position;
            lbl_clocked.Text = time;
        }

        private void load_items()
        {
            if (gb_appercance.Visible)
            {
                string name = "PlaceHolder";

                connection.Open();
                string sql = "select ThemeName from [theme]";


                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbox_theme.Items.Add(reader.GetString(0));



                }

                connection.Close();

                connection.Open();
                sql = "select Name from color";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {

                    cbox_hc.Items.Add(reader.GetString(0));
                    cbox_bc.Items.Add(reader.GetString(0));
                    cbox_sc.Items.Add(reader.GetString(0));
                    cbox_tc.Items.Add(reader.GetString(0));



                }

                connection.Close();



            }


        }
        //searcher
        private void search_theme(string name)
        {


            int[] codearray = new int[12];
            int i = 0;
            cbox_theme.SelectedIndex = cbox_theme.FindStringExact(name);
            connection.Open();
            string sql = "select HeaderOne,HeaderTwo,HeaderThree, BackGroundOne, BackGroundTwo, BackGroundThree, TableOne,TableTwo,TableThree,SideBarOne,SideBarTwo,SideBarThree from [theme] where ThemeName='" + name + "'";
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

                codearray[6] = reader.GetInt32(6);
                codearray[7] = reader.GetInt32(7);
                codearray[8] = reader.GetInt32(8);

                codearray[9] = reader.GetInt32(9);
                codearray[10] = reader.GetInt32(10);
                codearray[11] = reader.GetInt32(11);


            }

            connection.Close();
            while (true)
            {
                string color = "placeholder";
                int codeeone = 0;
                int codetwo = 0;
                int codethree = 0;
                if (i == 0) { codeeone = codearray[0]; codetwo = codearray[1]; codethree = codearray[2]; }
                if (i == 1) { codeeone = codearray[3]; codetwo = codearray[4]; codethree = codearray[5]; }
                if (i == 2) { codeeone = codearray[6]; codetwo = codearray[7]; codethree = codearray[8]; }
                if (i == 3) { codeeone = codearray[9]; codetwo = codearray[10]; codethree = codearray[11]; }
                connection.Open();
                sql = "select Name from color where CodeOne='" + codeeone + "' and CodeTwo='" + codetwo + "' and CodeThree='" + codethree + "'";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {

                    color = reader.GetString(0);




                }

                if (i == 0) { cbox_hc.SelectedIndex = cbox_hc.FindStringExact(color); }
                if (i == 1) { cbox_bc.SelectedIndex = cbox_bc.FindStringExact(color); }
                if (i == 2) { cbox_tc.SelectedIndex = cbox_tc.FindStringExact(color); }
                if (i == 3) { cbox_sc.SelectedIndex = cbox_sc.FindStringExact(color); connection.Close(); break; }
                connection.Close();
                i++;
            }

        }
        //updates
        private void update_custom() 
        {
            int[] codearray = new int[12];
            int i = 0;
            string name = cbox_hc.Text.ToString();
            while (true)
            {
                if (i == 3) { name = cbox_bc.Text.ToString(); }
                if (i == 6) { name = cbox_tc.Text.ToString(); }
                if (i == 9) { name = cbox_sc.Text.ToString(); }
                connection.Open();
                string sql = "select CodeOne, CodeTwo, codeThree from color where Name='" + name + "'";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {

                    codearray[i] = reader.GetInt32(0);

                    i++;
                    codearray[i] = reader.GetInt32(1);

                    i++;
                    codearray[i] = reader.GetInt32(2);

                    i++;




                }
                connection.Close();
                if (i == 12) { break; }

            }


            SqlCommand cmd = new SqlCommand("update Theme set HeaderOne=@ho,HeaderTwo=@ht,HeaderThree=@htr, BackGroundOne=@bo, BackGroundTwo=@bt, BackGroundThree=@btr, TableOne=@to,TableTwo=@tt,TableThree=@ttr,SideBarOne=@so,SideBarTwo=@st,SideBarThree=@str where ThemeName = '" + cbox_theme.Text.ToString() + "'", connection);
            connection.Open();

            cmd.Parameters.AddWithValue("@ho", codearray[0]);
            cmd.Parameters.AddWithValue("@ht", codearray[1]);
            cmd.Parameters.AddWithValue("@htr", codearray[2]);

            cmd.Parameters.AddWithValue("@bo", codearray[3]);
            cmd.Parameters.AddWithValue("@bt", codearray[4]);
            cmd.Parameters.AddWithValue("@btr", codearray[5]);

            cmd.Parameters.AddWithValue("@to", codearray[6]);
            cmd.Parameters.AddWithValue("@tt", codearray[7]);
            cmd.Parameters.AddWithValue("@ttr", codearray[8]);

            cmd.Parameters.AddWithValue("@so", codearray[9]);
            cmd.Parameters.AddWithValue("@st", codearray[10]);
            cmd.Parameters.AddWithValue("@str", codearray[11]);

            cmd.ExecuteNonQuery();


            connection.Close();

        }

        private void update_theme() 
        {
            string theme = cbox_theme.Text.ToString();

            
            SqlCommand cmd = new SqlCommand("update Machine set Theme=@t where IdofMachine='" + 1+ "'", connection);
            connection.Open();

            cmd.Parameters.AddWithValue("@t", theme);

            cmd.ExecuteNonQuery();
            

            connection.Close();

        }

        private void access_levels()
        {
            //Don't know it just works
            string lvl = "None";
            string sql = "select ActiveUser from [Machine]";
            connection.Open();
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

            if (lvl == "Admin" || lvl == "Manager" || lvl == "Team Leader") { gb_appercance.Visible = true; }
            else { gb_appercance.Visible = false; }

        }
    }
}
