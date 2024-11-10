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
    public partial class S7 : Form
    {
        private static string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static string strConnstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + directory + "\\resources\\data.mdf;Integrated Security=True";
        private static SqlConnection connection = new SqlConnection(strConnstring);
        private static SqlDataAdapter adapter = new SqlDataAdapter("select * from login", strConnstring);
        private static SqlCommand command;
        private static SqlDataReader reader;
        public S7()
        {
            InitializeComponent();
            load_table();
            load_color();
            load_combobox();

        }

      
        //buttons
        private void dv_local_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dv_local.Rows[e.RowIndex];
                txt_id.Text = row.Cells["m"].Value.ToString();
                txt_name.Text = row.Cells["np"].Value.ToString();
                txt_welcome_text.Text = row.Cells["wt"].Value.ToString();
                txt_login_text.Text = row.Cells["lt"].Value.ToString();
                txt_section.Text = row.Cells["s"].Value.ToString();
                cbox_theme_name.Text = row.Cells["t"].Value.ToString();

            }
            catch
            {
               
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_id.Text.Length != 0 && txt_id.Text.Length != 0 && txt_name.Text.Length != 0 && txt_section.Text.Length != 0 &&
                txt_login_text.Text.Length != 0 && txt_welcome_text.Text.Length != 0 && cbox_theme_name.Text.Length != 0)
            { update_machine(); load_table(); }
            else { MessageBox.Show("Something is missing please check", "Empty fields"); }
           
        }  

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
       
        //methods
        private void load_table()
        {
            dv_local.Rows.Clear();
            connection.Open();
            string sql = "select IdofMachine, ActiveUser, UserPosition, Theme, ProgramName, WelcomeText, LoginText, Section from Machine where id='" + 0 + "'";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.dv_local.Rows.Add(reader.GetInt32(0), reader.GetString(4), reader.GetString(1), reader.GetString(2), reader.GetString(7), reader.GetString(3), reader.GetString(5), reader.GetString(6));



            }
            connection.Close();
            txt_id.Clear();
            txt_name.Clear();
            txt_section.Clear();
            txt_login_text.Clear();
            txt_welcome_text.Clear();
            cbox_theme_name.Text = "";

        }

        private void load_combobox()
        {

            connection.Open();
            string sql = "select ThemeName from Theme";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {

                cbox_theme_name.Items.Add(reader.GetString(0));





            }
            connection.Close();

        }

        private void update_machine() 
        {
            SqlCommand cmd = new SqlCommand("update Machine set IdofMachine=@im,Theme=@t,ProgramName=@pn, WelcomeText=@wt, LoginText=@lt, Section=@s where id = '" + 0 + "'", connection);
            connection.Open();

            cmd.Parameters.AddWithValue("@im", int.Parse(txt_id.Text.ToString()));
            cmd.Parameters.AddWithValue("@pn", txt_name.Text.ToString());
            cmd.Parameters.AddWithValue("@s", txt_section.Text.ToString());

            cmd.Parameters.AddWithValue("@t", cbox_theme_name.Text.ToString());
            cmd.Parameters.AddWithValue("@lt", txt_login_text.Text.ToString());
            cmd.Parameters.AddWithValue("@wt", txt_welcome_text.Text.ToString());


            cmd.ExecuteNonQuery();


            connection.Close();

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

            dv_local.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(tableone, tabletwo, tablethree);
            dv_local.BackgroundColor = this.BackColor;

        }

        
    }
    }
