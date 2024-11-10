using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreFront.FR.subforms
{
    public partial class S4 : Form
    {
        private static string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static string strConnstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + directory + "\\resources\\data.mdf;Integrated Security=True";
        private static SqlConnection connection = new SqlConnection(strConnstring);
        private static SqlDataAdapter adapter = new SqlDataAdapter("select * from login", strConnstring);
        private static SqlCommand command;
        private static SqlDataReader reader;
        public S4()
        {
            InitializeComponent();
            load_color();
            reload();
            access_levels();
        }
        //buttons
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_di.Text.Length != 0 && txt_ti.Text.Length != 0 && txt_do.Text.Length != 0 && txt_to.Text.Length != 0 && lbl_id.Text.Length != 0)
            {

                string sql = "update [login] set DateIn=@di, TimeIn=@ti ,DateOut=@do,TimeOut=@to where Number='" + lbl_num.Text.ToString() + "'";

                SqlCommand cmd = new SqlCommand(sql, connection);
                connection.Open();

                cmd.Parameters.AddWithValue("@di", txt_di.Text.ToString());
                cmd.Parameters.AddWithValue("@ti", txt_ti.Text.ToString());
                cmd.Parameters.AddWithValue("@do", txt_do.Text.ToString());
                cmd.Parameters.AddWithValue("@to", txt_to.Text.ToString());

                cmd.ExecuteNonQuery();


                connection.Close();

                reload();

                MessageBox.Show("Update has been successful", "Update");

            }
            else { MessageBox.Show("Something is missing please check", "Empty fields"); }
        }

        private void dv_logs_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow row = this.dv_logs.Rows[e.RowIndex];
                lbl_num.Text = row.Cells["num"].Value.ToString();
                lbl_id.Text = row.Cells["idof"].Value.ToString();
                lbl_name.Text = row.Cells["nombre"].Value.ToString();
                txt_di.Text = row.Cells["Datein"].Value.ToString();
                txt_ti.Text = row.Cells["Timein"].Value.ToString();
                txt_do.Text = row.Cells["Dateout"].Value.ToString();
                txt_to.Text = row.Cells["Timeout"].Value.ToString();
               

            }
            catch
            {
               
            }
        }
       
        //methods
        private void reload()
        {
            lbl_id.Text = "";
            lbl_name.Text = "";
            lbl_num.Text = "";
            txt_di.Clear();
            txt_do.Clear();
            txt_ti.Clear(); 
            txt_to.Clear();
            connection.Open();
            string sql = "select * from [login]";
            adapter = new SqlDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dv_logs.DataSource = dt;
            connection.Close();
        }

        private void load_color()
        {
            
            string name = "PlaceHolder";
            int tableone = 0;
            int tabletwo = 0;
            int tablethree = 0;

            //theme
            string sql = "select Theme from [Machine]";
            connection.Open();
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                name = reader.GetString(0);



            }
            connection.Close();

            //table colors
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

            dv_logs.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(tableone, tabletwo, tablethree);
            dv_logs.BackgroundColor = this.BackColor;

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
            //-Users-
            //-Logins -
            //-Machine -
            //-Colors -
            //-Reports -
            //-Taxes & Discounts -
            //-Sales -


          
            if (lvl == "Team Leader"|| lvl == "Trainer" || lvl=="Employee")
            {
               txt_ti.Enabled=false;
               txt_to.Enabled = false;
               txt_do.Enabled = false;
               txt_di.Enabled=false;
               btn_update.Enabled = false;
            }
           
            

        }
        //print
        private void btn_print_Click(object sender, EventArgs e)
        {
            

            DialogResult dialogResult = MessageBox.Show("Is everything ready to go?", " Ready to print ? ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                PPD.Document = PD;
                PPD.ShowDialog();
            }


        }
        private void PD_PrintPage(object sender, PrintPageEventArgs e)
        {

            //date grid view variables
            string val_1 = "1";
            string val_2 = "";
            string val_3 = "";
            string val_4 = "";
            string val_5 = "";
            string val_6 = "";
            string val_7 = "";


            //id & name of the user with the current date
            string date = DateTime.Now.ToLongDateString(); ;
            string id = "id";
            string name = "name";

            //function only variables
            int space = 10;
            string dashes = "--------------------------------------------------------------------------------------------------";

            string sql = "select ActiveUser from [Machine] ";
            connection.Open();
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read()) { name = reader.GetString(0); }
            connection.Close();

            sql = "select Id from [user] where Name = '" + name + "' ";
            connection.Open();
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read()) { id = reader.GetInt32(0).ToString(); }
            connection.Close();


            e.Graphics.DrawString("Id: " + id, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(0, space));
            e.Graphics.DrawString("Date: " + date, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(450, space));
            space += 30;
            e.Graphics.DrawString(name, new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(0, space));
            e.Graphics.DrawString("Login Table", new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(450, space));

            space += 50;
            e.Graphics.DrawString(dashes, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(0, space));
            space += 30;

            for (int i = 0; i < dv_logs.Rows.Count; i++)
            {
                space += 40;
                val_1 = dv_logs.Rows[i].Cells[0].Value.ToString();
                val_2 = dv_logs.Rows[i].Cells[1].Value.ToString();
                val_3 = dv_logs.Rows[i].Cells[2].Value.ToString();
                val_4 = dv_logs.Rows[i].Cells[3].Value.ToString();
                val_5 = dv_logs.Rows[i].Cells[4].Value.ToString();
                val_6 = dv_logs.Rows[i].Cells[5].Value.ToString();
                val_7 = dv_logs.Rows[i].Cells[6].Value.ToString();
            

                e.Graphics.DrawString(val_1.Trim() + " | " + val_2.Trim() + " | " + val_3.Trim() + " | " + val_4.Trim() + " | " + val_5.Trim() + " | " + val_6.Trim() + " | " + val_7.Trim() + " | " , new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(0, space));

            }
            space += 20;

            e.Graphics.DrawString(dashes, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(0, space));

        }
    }

}
