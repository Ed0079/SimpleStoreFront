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
    public partial class S8 : Form
    {
        private static string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static string strConnstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + directory + "\\resources\\data.mdf;Integrated Security=True";
        private static SqlConnection connection = new SqlConnection(strConnstring);
        private static SqlDataAdapter adapter = new SqlDataAdapter("select * from login", strConnstring);
        private static SqlCommand command;
        private static SqlDataReader reader;
        public S8()
        {
            InitializeComponent();
            load_discounts_table();
            load_taxes_table();
            load_color();
        }
        //buttons
        private void btn_t_add_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Length != 0 && txt_percent.Text.Length != 0)
            {
                if (check_name_taxes(txt_name.Text.ToString()) == false)
                {
                    connection.Open();

                    command.CommandType = System.Data.CommandType.Text;

                    string n = txt_name.Text.ToString();
                    double p = double.Parse(txt_percent.Text.ToString());


                
                    command.CommandText = "INSERT [taxes] (Name, [Percent]) VALUES ('" + n + "', " + p + ")";
                    command.ExecuteNonQuery();
                    connection.Close();
                    load_taxes_table();
                }
                else { }
            }
            else { MessageBox.Show("Something is missing please check", "Empty fields"); }
        }

        private void btn_t_update_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Length != 0)
            {
                    string n = txt_name.Text.ToString();
                    double p = double.Parse(txt_percent.Text.ToString());
                    string sql = "update [taxes] set Name=@n, [Percent]=@p where Name='" + txt_name.Text.ToString() + "'";

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    connection.Open();
                    cmd.Parameters.AddWithValue("@n", txt_name.Text.ToString());
                    cmd.Parameters.AddWithValue("@p", txt_percent.Text.ToString());



                    cmd.ExecuteNonQuery();


                    connection.Close();
                    load_taxes_table();
                
               
            }
            else { MessageBox.Show("Something is missing please check", "Empty fields"); }
        }

        private void btn_t_delete_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Length != 0)
            {
                if (check_name_taxes(txt_name.Text.ToString()))
                {
                    connection.Open();
                    string sql = "delete from [taxes] where Name='" + txt_name.Text.ToString() + "'";
                    command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    load_taxes_table();
                }
                else { MessageBox.Show("This name doesn't exists", "Try again"); }

            }
            else { MessageBox.Show("Something is missing please check", "Empty fields"); }
        }

        private void btn_d_add_Click(object sender, EventArgs e)
        {
            if (txt_code.Text.Length != 0 && txt_percent_d.Text.Length != 0 && txt_usage.Text.Length != 0)
            {
                if (check_name_discount(txt_code.Text.ToString()) == false)
                {
                    connection.Open();

                    command.CommandType = System.Data.CommandType.Text;

                    string c = txt_code.Text.ToString();
                    double p = double.Parse(txt_percent_d.Text.ToString());
                    int u = Int32.Parse(txt_usage.Text.ToString());

                    command.CommandText = "INSERT [discounts] (Code , [Percent] , Usage) VALUES ('" + c + "'," + p + "," + u + ")";
                    command.ExecuteNonQuery();
                    connection.Close();
                    load_discounts_table();

                }
                else { MessageBox.Show("That name already exists", "Try again"); }
            }
            else { MessageBox.Show("Something is missing please check", "Empty fields"); }
        }

        private void btn_d_update_Click(object sender, EventArgs e)
        {
            if (txt_code.Text.Length != 0)
            {
                    string sql = "update discounts set Code=@c, [Percent] = @p , Usage=@u where Code='" + txt_code.Text.ToString() + "'";

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    connection.Open();
                    cmd.Parameters.AddWithValue("@c", txt_code.Text.ToString());
                    cmd.Parameters.AddWithValue("@p", double.Parse(txt_percent_d.Text.ToString()));
                    cmd.Parameters.AddWithValue("@u", int.Parse( txt_usage.Text.ToString()));



                    cmd.ExecuteNonQuery();


                    connection.Close();

                    load_discounts_table();


                
              
            }
            else { MessageBox.Show("Something is missing please check", "Empty fields"); }
        }

        private void btn_d_delete_Click(object sender, EventArgs e)
        {
            if (txt_code.Text.Length != 0)
            {

                if (check_name_discount(txt_code.Text.ToString()))
                {
                    connection.Open();
                    string sql = "delete from [discounts] where Code='" + txt_code.Text.ToString() + "'";
                    command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    load_discounts_table();
                }
                else { MessageBox.Show("This name doesn't exists", "Try again"); }

            }
            else { MessageBox.Show("Something is missing please check", "Empty fields"); }
        }

        private void txt_percent_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
     
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void txt_usage_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_percent_d_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
 
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void dv_taxes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dv_taxes.Rows[e.RowIndex];
               
                txt_name.Text = row.Cells["n"].Value.ToString();
                txt_percent.Text = row.Cells["p"].Value.ToString();
                

            }
            catch
            {
              
            }
        }

        private void dv_discount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dv_discount.Rows[e.RowIndex];

                txt_code.Text = row.Cells["c"].Value.ToString();
                txt_percent_d.Text = row.Cells["percent"].Value.ToString();
                txt_usage.Text = row.Cells["u"].Value.ToString();




            }
            catch
            {
              
            }
        }

        //methods
        private void load_taxes_table()
        {
            txt_name.Clear();
            txt_percent.Clear();

            connection.Open();
            string sql = "select * from [taxes]";
            adapter = new SqlDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dv_taxes.DataSource = dt;
            connection.Close();



        }

        private void load_discounts_table()
        {
            txt_code.Clear();
            txt_percent_d.Clear();
            txt_usage.Clear();

            connection.Open();
            string sql = "select * from [discounts]";
            adapter = new SqlDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dv_discount.DataSource = dt;
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

            dv_discount.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(tableone, tabletwo, tablethree);
            dv_discount.BackgroundColor = this.BackColor;

            dv_taxes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(tableone, tabletwo, tablethree);
            dv_taxes.BackgroundColor = this.BackColor;

        }

        private Boolean check_name_taxes(string name) 
        { 
            Boolean c = false;
            connection.Open();
            string sql = "select Name from taxes";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {

                
                if (name == reader.GetString(0)) { c = true; }







            }
            connection.Close();


            return c; 
        
        }

        private Boolean check_name_discount(string name) 
        {
            Boolean c = false;
            connection.Open();
            string sql = "select Code from discounts";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {

               
                if (name == reader.GetString(0)) { c = true; }

            }
            connection.Close();

            return c; 
        
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
                e.Handled = (e.KeyChar == (char)Keys.Space);
            else
                e.Handled = false;
        }
    }
}
