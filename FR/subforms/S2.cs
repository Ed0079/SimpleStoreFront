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

namespace StoreFront.FR.subforms
{
    public partial class S2 : Form
    {
        private static string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static string strConnstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + directory + "\\resources\\data.mdf;Integrated Security=True";
        private static SqlConnection connection = new SqlConnection(strConnstring);
        private static SqlDataAdapter adapter = new SqlDataAdapter("select * from user", strConnstring);
        private static SqlCommand command;
        private static SqlDataReader reader;
        public S2()
        {
           
            InitializeComponent();
            reload(access_levels());
            load_color();
            
        }
        //buttons
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Length!=0 && txt_position.Text.Length != 0&& txt_password.Text.Length != 0) 
            {
                if (check_name())
                {

                    connection.Open();

                    command.CommandType = System.Data.CommandType.Text;
                    string p = txt_password.Text.ToString();
                    string n = txt_name.Text.ToString();
                    string ps = txt_position.Text.ToString();
                    command.CommandText = "INSERT [user] (Name, Password,Position) VALUES ('" + n + "','" + p + "','" + ps + "')";
                    command.ExecuteNonQuery();
                    connection.Close();
                    reload(access_levels());


                }
                else { MessageBox.Show("That name already exists","Try again"); }

            }
            else { MessageBox.Show("Something is missing please check","Empty fields"); }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Length != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure about deleting this user", "Deleting User", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    connection.Open();
                    string sql = "delete from [user] where Name='" + txt_name.Text.ToString() + "'";
                    command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    connection.Close();

                    reload(access_levels());
                }
               

               



            }
            else { MessageBox.Show("Something is missing please check", "Empty fields"); }
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Length != 0 && txt_position.Text.Length != 0 && txt_password.Text.Length != 0)
            {
                if (check_name() == true)
                {

                    string sql = "update [user] set Name=@n, Password=@p ,Position=@ps where Id='" + lbl_id.Text.ToString() + "'";
                   
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    connection.Open();

                    cmd.Parameters.AddWithValue("@n", txt_name.Text.ToString());
                    cmd.Parameters.AddWithValue("@p", txt_password.Text.ToString());
                    cmd.Parameters.AddWithValue("@ps", txt_position.Text.ToString());

                    cmd.ExecuteNonQuery();


                    connection.Close();
                    reload(access_levels());
                    MessageBox.Show("Update has been successful", "Update");
                }
                else { MessageBox.Show("That name already exists", "Try again"); }

            }
            else { MessageBox.Show("Something is missing please check", "Empty fields"); }

        }


        private void dv_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dv_user.Rows[e.RowIndex];
                lbl_id.Text = row.Cells["id"].Value.ToString();
                txt_name.Text = row.Cells["name"].Value.ToString();
                txt_position.Text = row.Cells["Position"].Value.ToString();
                txt_password.Text = row.Cells["Password"].Value.ToString();
               
            }
            catch
            {
             
            }
        }

        //methods
        private Boolean check_name() 
        {
            Boolean c = true;
            string name = "";
            string sql = "select Name from [user]";

            connection.Open();
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                name = reader.GetString(0).ToString();
                if (name==txt_name.Text.ToString()) { c = false; }
            }

            connection.Close();
           
            return c; 
 
        }

        
        private void reload(int i)
        {
           
            lbl_id.Text = "";
            txt_name.Clear();
            txt_password.Clear();
            txt_position.Text="";
            //dv_user.Rows.Clear();

            if (i == 0)
            {
                string sql = "select * from [user]";
                adapter = new SqlDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dv_user.DataSource = dt;
                connection.Close();
            }
            if (i == 1) 
            {
                string mock_password="***********";
                connection.Open();
                string sql = "select Id, Name, Position from [user] ";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                   
                    this.dv_user.Rows.Add(reader.GetInt32(0), reader.GetString(1), mock_password, reader.GetString(2));



                }
                connection.Close();




            }
        }


        private void load_color()
        {
           
            string name = "PlaceHolder";
            int tableone = 0;
            int tabletwo = 0;
            int tablethree = 0;
          //theme
            connection.Open();
            string sql = "select Theme from [Machine]";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                name = reader.GetString(0);



            }
            connection.Close();

            //table color
            connection.Open();
            sql = "select TableOne,TableTwo, TableThree from [theme] where ThemeName ='" + name + "'";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                tableone = reader.GetInt32(0);
                tabletwo = reader.GetInt32(1);
                tablethree = reader.GetInt32(2);




            }
            connection.Close();

            dv_user.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(tableone, tabletwo, tablethree);
            dv_user.BackgroundColor = this.BackColor;

        }

        private int access_levels()
        {

            //Don't know it just works
            string lvl = "None";
            string sql = "select ActiveUser from [Machine]";
            int i = 0;
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

            if (lvl == "TeamLeader" ) { txt_name.Enabled = false; txt_password.Enabled = false; btn_add.Enabled = false; btn_delete.Enabled = false; txt_position.Enabled = false; btn_update.Enabled = false; i = 1; }

            return i;

        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
                e.Handled = (e.KeyChar == (char)Keys.Space);
            else
                e.Handled = false;
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
                e.Handled = (e.KeyChar == (char)Keys.Space);
            else
                e.Handled = false;
        }

      
    }
}
