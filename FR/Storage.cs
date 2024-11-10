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

namespace StoreFront.FR
{
    public partial class Storage : Form
    {
        private static string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static string strConnstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + directory + "\\resources\\data.mdf;Integrated Security=True";
        private static SqlConnection connection = new SqlConnection(strConnstring);
        private static SqlDataAdapter adapter = new SqlDataAdapter("select * from user", strConnstring);
        private static SqlCommand command;
        private static SqlDataReader reader;
        public Storage()
        {
            InitializeComponent();
            panel_admin.Visible = false;
            access_levels();
        }

        private void Storage_Load(object sender, EventArgs e)
        {
            load_table();
            load_color();
            load_combobox();
        }
       
        //buttons and clicks
        private void dv_storage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dv_storage.Rows[e.RowIndex];
                lbl_Id.Text = row.Cells["Id"].Value.ToString();
                cbox_name.Text = row.Cells["name"].Value.ToString();
                cbox_qty.Text = row.Cells["Qty"].Value.ToString();
                cbox_price.Text = row.Cells["Price"].Value.ToString();
                rtbox_description.Text = get_description();
            }
            catch {
                
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int value_1;
            double value_2;
           
            if (cbox_name.Text.Length != 0 && cbox_price.Text.Length != 0 && cbox_qty.Text.Length != 0 && rtbox_description.Text.Length != 0)
            {
                if (int.TryParse(cbox_qty.Text, out value_1))
                {
                    
                    
                    if (double.TryParse(cbox_price.Text, out value_2))
                    {
                       
                        if (Item_Name_Check()) {
                            connection.Close();
                            connection.Open();

                            command.CommandType = System.Data.CommandType.Text;
                            int q = Int32.Parse(cbox_qty.Text.ToString());
                            string n = cbox_name.Text.ToString();
                            double p = double.Parse(cbox_price.Text.ToString());
                            command.CommandText = "INSERT storage (Name, Qty,Price) VALUES ('" + n + "'," + q + "," + p + ")";
                            command.ExecuteNonQuery();
                            connection.Close();
                            load_table();
                        }
                        else { MessageBox.Show("Item already in storage"); }
                      
                    }
                    else { MessageBox.Show("Warning: Only numbers are allowed on the price."); }
                }
                else { MessageBox.Show("Warning: Only numbers are allowed on the qty"); }
            }
            else { MessageBox.Show("Warning: Missing information. Please fill in all required fields."); }

        }

        private void btn_delet_Click(object sender, EventArgs e)
        {
            if (lbl_Id.Text.ToString() != " ")
            {
                connection.Close();
                connection.Open();
                string sql = "delete from storage where Name='" + cbox_name.Text.ToString() + "'";
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                connection.Close();
                load_table();

            }
            else { MessageBox.Show("No item have been selected"); }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int value_1;
            double value_2;
            if (lbl_Id.Text.ToString() != " " && cbox_name.Text.Length != 0 && cbox_price.Text.Length != 0 && cbox_qty.Text.Length != 0 && rtbox_description.Text.Length != 0)
            {
                if (int.TryParse(cbox_qty.Text, out value_1))
                {

                    if (double.TryParse(cbox_price.Text, out value_2))
                    {
                        connection.Close();
                        string sql = "update storage set Name=@name, Price=@price ,Qty=@qty , Description=@des where Id='" + lbl_Id.Text.ToString() + "'";
                        int q = Int32.Parse(cbox_qty.Text.ToString());
                        double p = double.Parse(cbox_price.Text.ToString());
                        string n = cbox_name.Text.ToString();
                        string d = rtbox_description.Text.ToString();
                        SqlCommand cmd = new SqlCommand(sql, connection);
                        connection.Open();

                        cmd.Parameters.AddWithValue("@name", n);
                        cmd.Parameters.AddWithValue("@price", p);
                        cmd.Parameters.AddWithValue("@qty", q);
                        cmd.Parameters.AddWithValue("@des", d);

                        cmd.ExecuteNonQuery();


                        connection.Close();
                        load_table();
                        MessageBox.Show("Update has been successful", "Update");
                    }
                    else { MessageBox.Show("Warning: Only numbers are allowed on the price."); }
                }
                else { MessageBox.Show("Warning: Only numbers are allowed on the qty"); }
            }
            else { MessageBox.Show("No item has been selected", "Not selected"); }
        }

        //methods
        private void load_color()
        {
            string name = "PlaceHolder";
            int tableone = 0;
            int tabletwo = 0;
            int tablethree = 0;

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
            sql = "select TableOne, TableTwo,TableThree from [theme] where ThemeName ='" + name + "'";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                tableone = reader.GetInt32(0);
                tabletwo = reader.GetInt32(1);
                tablethree = reader.GetInt32(2);
            }

            connection.Close();
            dv_storage.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(tableone, tabletwo, tablethree);
            dv_storage.BackgroundColor = this.BackColor;
          //  rtbox_description.BackColor = this.BackColor;

        }
        private void load_table()
        {
            if (dv_storage.Rows.Count != 0) { dv_storage.Rows.Clear(); }
            connection.Open();
            string sql = "select Id, Name, Qty, Price from [storage]";


            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.dv_storage.Rows.Add(reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetDouble(3).ToString(), reader.GetInt32(2).ToString());
            }

            connection.Close();
            cbox_name.Text = "";
            cbox_qty.Text = "";
            cbox_price.Text = "";
            lbl_Id.Text = "";
            rtbox_description.Text = "";

        }

        private void access_levels()
        {
            //Don't know it just works
            connection.Close();
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

            if (lvl == "Admin" || lvl == "Manager" || lvl == "Team Leader") { panel_admin.Visible = true; rtbox_description.ReadOnly = false; } else { panel_admin.Visible = false; rtbox_description.ReadOnly = true; }

        }

        private string get_description() 
        {

            string re="";
            connection.Open();
            string sql = "select Description from [storage] where Id ="+lbl_Id.Text.ToString();
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
               re= reader.GetString(0).ToString();
             
            }
            connection.Close();
           
            return re;
        }

        private Boolean Item_Name_Check() 
        {
            Boolean name = true;
            if (dv_storage.Rows.Count > 0)
            {
                for (int i = 0; i < dv_storage.Rows.Count; i++)
                {
                    DataGridViewRow row = dv_storage.Rows[i];
                    string NameValue = row.Cells["name"].Value.ToString();

                    if (cbox_name.Text == NameValue) { name = false; }

                }
            }
                return name;
        
        
        }
        private void load_combobox()
        {
            cbox_name.Items.Clear();
         
            connection.Open();
            string sql = "select Name from storage";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {

                cbox_name.Items.Add(reader.GetString(0).Trim());
              

            }
            connection.Close();

        }
    }
}
