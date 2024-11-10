using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreFront.FR.subforms
{
    public partial class S5 : Form
    {
        private static string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static string strConnstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + directory + "\\resources\\data.mdf;Integrated Security=True";
        private static SqlConnection connection = new SqlConnection(strConnstring);
        private static SqlDataAdapter adapter = new SqlDataAdapter("select * from color", strConnstring);
        private static SqlCommand command;
        private static SqlDataReader reader;
        public S5()
        {
            InitializeComponent();
            load_color();
            load_theme();
            load_combobox();
            load_table_color();
            access_levels();

        }
        //buttons
        private void dv_theme_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dv_theme.Rows[e.RowIndex];
                lbl_theme_id.Text = row.Cells["id"].Value.ToString().Trim();
                txt_theme_name.Text = row.Cells["name"].Value.ToString().Trim();
                cbox_h.Text = row.Cells["h"].Value.ToString();
                cbox_b.Text = row.Cells["b"].Value.ToString();
                cbox_t.Text = row.Cells["t"].Value.ToString();
                cbox_s.Text = row.Cells["s"].Value.ToString();

            }
            catch
            {
               
            }
        }

        private void dv_color_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dv_color.Rows[e.RowIndex];
                lbl_Id.Text = row.Cells["cid"].Value.ToString().Trim();
                txt_name.Text = row.Cells["nombre"].Value.ToString().Trim();
                txt_one.Text = row.Cells["co"].Value.ToString().Trim();
                txt_two.Text = row.Cells["ct"].Value.ToString().Trim();
                txt_three.Text = row.Cells["cth"].Value.ToString().Trim();


            }
            catch
            {
               
            }
        }

        private void btn_cadd_Click(object sender, EventArgs e)
        {
            if (txt_one.Text.Length != 0 && txt_two.Text.Length != 0 && txt_three.Text.Length != 0)
            {

                if (int.Parse(txt_one.Text.ToString()) <= 255 && int.Parse(txt_two.Text.ToString()) <= 255 && int.Parse(txt_three.Text.ToString()) <= 255)
                {
                    if (check_name(txt_name.Text.ToString().Trim()) == true)
                    {

                        connection.Open();

                        command.CommandType = System.Data.CommandType.Text;
                       
                        string n = txt_name.Text.ToString();
                        int o = int.Parse(txt_one.Text.ToString());
                        int t = int.Parse(txt_two.Text.ToString());
                        int th = int.Parse(txt_three.Text.ToString());
                        command.CommandText = "INSERT [color] (Name, CodeOne,CodeTwo,CodeThree) VALUES ('" + n + "'," + o + "," + t + ","+th+")";
                        command.ExecuteNonQuery();
                        connection.Close();
                        load_color();
                        load_combobox();
                    }
                    else { MessageBox.Show("That name already exists", "Try again"); }
                }
                else { MessageBox.Show("One or more of the number has passed the limit of 255", "Over the limit"); }
            }
            else { MessageBox.Show("Something is missing please check", "Empty fields"); }
        }

        private void btn_cupdate_Click(object sender, EventArgs e)
        {
            if (txt_one.Text.Length != 0 && txt_two.Text.Length != 0 && txt_three.Text.Length != 0 && lbl_Id.Text.Length!=0)
            {

                if (int.Parse(txt_one.Text.ToString()) <= 255 && int.Parse(txt_two.Text.ToString()) <= 255 && int.Parse(txt_three.Text.ToString()) <= 255)
                {
                    if (check_name(txt_name.Text.ToString().Trim()) == true || update_check_color(txt_name.Text.ToString().Trim())==true)
                    {
                        string sql = "update [color] set Name=@N, CodeOne=@O, CodeTwo=@T ,CodeThree=@Th where Id=" + lbl_Id.Text.ToString() + "";

                        SqlCommand cmd = new SqlCommand(sql, connection);
                        connection.Open();
                        cmd.Parameters.AddWithValue("@N", txt_name.Text.ToString());
                        cmd.Parameters.AddWithValue("@O", Int32.Parse(txt_one.Text.ToString()));
                        cmd.Parameters.AddWithValue("@T", Int32.Parse(txt_two.Text.ToString()));
                        cmd.Parameters.AddWithValue("@Th", Int32.Parse(txt_three.Text.ToString()));
                        

                        cmd.ExecuteNonQuery();


                        connection.Close();
                        load_color();
                        load_combobox();
                        MessageBox.Show("Update has been successful", "Update");
                    }
                    else { MessageBox.Show("That name already exists", "Try again"); }
                }
                else { MessageBox.Show("One or more of the number has passed the limit of 255", "Over the limit"); }
            }
            else { MessageBox.Show("Something is missing please check", "Empty fields"); }
        }

        private void btn_cdelete_Click(object sender, EventArgs e)
        {
            if (lbl_Id.Text.Length != 0)
            {

                DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    connection.Open();
                    string sql = "delete from [color] where Id='" + lbl_Id.Text.ToString() + "'";
                    command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    connection.Close();

                    load_color();
                    load_combobox();
                }

            }
            else { MessageBox.Show("Something is missing please check", "Empty fields"); }
        }

        private void btn_tadd_Click(object sender, EventArgs e)
        {
            if (txt_theme_name.Text.Length != 0 && cbox_h.Text.Length != 0 && cbox_b.Text.Length != 0 && cbox_t.Text.Length != 0 && cbox_s.Text.Length != 0)
            {

                if (check_theme_name(txt_theme_name.Text.ToString().Trim()) == true)
                {
                    int[] val= new int[12];
                    val[0] = search_code(cbox_h.Text.ToString(), 0);
                    val[1] = search_code(cbox_h.Text.ToString(), 1);
                    val[2] = search_code(cbox_h.Text.ToString(), 2);

                    val[3] = search_code(cbox_b.Text.ToString(), 0);
                    val[4] = search_code(cbox_b.Text.ToString(), 1);
                    val[5] = search_code(cbox_b.Text.ToString(), 2);

                    val[6] = search_code(cbox_t.Text.ToString(), 0);
                    val[7] = search_code(cbox_t.Text.ToString(), 1);
                    val[8] = search_code(cbox_t.Text.ToString(), 2);

                    val[9] = search_code(cbox_s.Text.ToString(), 0);
                    val[10] = search_code(cbox_s.Text.ToString(), 1);
                    val[11] = search_code(cbox_s.Text.ToString(), 2);

                    connection.Open();

                        command.CommandType = System.Data.CommandType.Text;

                       
                        string o = txt_one.Text.ToString();
                        string t = txt_two.Text.ToString();
                        string th = txt_three.Text.ToString();
                        command.CommandText = "INSERT [Theme] (ThemeName,HeaderOne,HeaderTwo,HeaderThree, BackGroundOne, BackGroundTwo, BackGroundThree, TableOne,TableTwo,TableThree,SideBarOne,SideBarTwo,SideBarThree) " +"VALUES ('" 
                        + txt_theme_name.Text.ToString() + "'," + val[0] + "," + val[1] + "," + val[2] + "," + val[3] + "," + val[4] + "," + val[5] +"," + val[6] + "," + val[7] + "," + val[8] + "," + val[9] + "," + val[10] + "," + val[11] + ")";
                        command.ExecuteNonQuery();
                        connection.Close();
                       
                        load_theme();
                        load_combobox();
                    
                }
                else { MessageBox.Show("That name already exists", "Try again"); }
            }
            else { MessageBox.Show("Something is missing please check", "Empty fields"); }
        }

        private void btn_tupdate_Click(object sender, EventArgs e)
        {
            if (txt_theme_name.Text.Length != 0 && lbl_theme_id.Text.Length != 0 && cbox_b.Text.Length != 0 && cbox_h.Text.Length != 0 && cbox_s.Text.Length != 0 && cbox_t.Text.Length != 0)
            {

                    
                    if (check_theme_name(txt_theme_name.Text.ToString().Trim()) == true || update_check_theme(txt_theme_name.Text.ToString().Trim()) == true)
                    {
                    int[] val = new int[12];
                    val[0] = search_code(cbox_h.Text.ToString(), 0);
                    val[1] = search_code(cbox_h.Text.ToString(), 1);
                    val[2] = search_code(cbox_h.Text.ToString(), 2);

                    val[3] = search_code(cbox_b.Text.ToString(), 0);
                    val[4] = search_code(cbox_b.Text.ToString(), 1);
                    val[5] = search_code(cbox_b.Text.ToString(), 2);

                    val[6] = search_code(cbox_t.Text.ToString(), 0);
                    val[7] = search_code(cbox_t.Text.ToString(), 1);
                    val[8] = search_code(cbox_t.Text.ToString(), 2);

                    val[9] = search_code(cbox_s.Text.ToString(), 0);
                    val[10] = search_code(cbox_s.Text.ToString(), 1);
                    val[11] = search_code(cbox_s.Text.ToString(), 2);
                  

                        SqlCommand cmd = new SqlCommand("update Theme set ThemeName=@n , HeaderOne=@ho,HeaderTwo=@ht,HeaderThree=@htr, BackGroundOne=@bo, BackGroundTwo=@bt, BackGroundThree=@btr, TableOne=@to,TableTwo=@tt,TableThree=@ttr,SideBarOne=@so,SideBarTwo=@st,SideBarThree=@str where Id = '" + lbl_theme_id.Text.ToString() + "'", connection);
                        connection.Open();

                        cmd.Parameters.AddWithValue("@n", txt_theme_name.Text.ToString());

                        cmd.Parameters.AddWithValue("@ho",  val[0]);
                        cmd.Parameters.AddWithValue("@ht",  val[1]);
                        cmd.Parameters.AddWithValue("@htr", val[2]);

                        cmd.Parameters.AddWithValue("@bo",  val[3]);
                        cmd.Parameters.AddWithValue("@bt",  val[4]);
                        cmd.Parameters.AddWithValue("@btr", val[5]);

                        cmd.Parameters.AddWithValue("@to",  val[6]);
                        cmd.Parameters.AddWithValue("@tt",  val[7]);
                        cmd.Parameters.AddWithValue("@ttr", val[8]);

                        cmd.Parameters.AddWithValue("@so",  val[9]);
                        cmd.Parameters.AddWithValue("@st",  val[10]);
                        cmd.Parameters.AddWithValue("@str", val[11]);

                        cmd.ExecuteNonQuery();


                        connection.Close();


                        load_theme();
                        
                        load_combobox();
                        MessageBox.Show("Update has been successful", "Update");
                    }
                    else { MessageBox.Show("That name already exists", "Try again"); }
               
            }
            else { MessageBox.Show("Something is missing please check", "Empty fields"); }
        }

        private void btn_tdelete_Click(object sender, EventArgs e)
        {
            if (lbl_theme_id.Text.Length != 0)
            {

                DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    connection.Open();
                    string sql = "delete from [Theme] where Id='" + lbl_theme_id.Text.ToString() + "'";
                    command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    connection.Close();

                    
                    load_combobox();
                    load_theme();
                }

            }
            else { MessageBox.Show("Something is missing please check", "Empty fields"); }
        }
       
        private void txt_one_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
                e.Handled = (e.KeyChar == (char)Keys.Space);
            else
                e.Handled = false;
        }

        private void txt_theme_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
                e.Handled = (e.KeyChar == (char)Keys.Space);
            else
                e.Handled = false;
        }

        //methods

        //loads/refreshes the tables & combobox
        private void load_color()
        {
            lbl_Id.Text = "";
            txt_name.Clear();
            txt_one.Clear();
            txt_two.Clear();
            txt_three.Clear();
            connection.Open();
            string sql = "select * from [color]";
            adapter = new SqlDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dv_color.DataSource = dt;
            connection.Close();

        }

        private void load_theme()
        {
            lbl_theme_id.Text = "";
            txt_theme_name.Clear();
            cbox_h.Text = "";
            cbox_b.Text = "";
            cbox_t.Text = "";
            cbox_s.Text = "";
            dv_theme.Rows.Clear();
            connection.Open();
            string sql = "select * from [Theme]";
            adapter = new SqlDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();

            int row = dt.Rows.Count;
            int i = 0;
            while (true)
            {
                i++;
                int[] codearray = new int[12];

                int id = 0;
                string name = "";
                connection.Open();
                sql = "select Id,ThemeName, HeaderOne,HeaderTwo,HeaderThree, BackGroundOne, BackGroundTwo, BackGroundThree, TableOne,TableTwo,TableThree,SideBarOne,SideBarTwo,SideBarThree from Theme where Id='" + i + "'";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                    name = reader.GetString(1);

                    codearray[0] = reader.GetInt32(2);
                    codearray[1] = reader.GetInt32(3);
                    codearray[2] = reader.GetInt32(4);

                    codearray[3] = reader.GetInt32(5);
                    codearray[4] = reader.GetInt32(6);
                    codearray[5] = reader.GetInt32(7);

                    codearray[6] = reader.GetInt32(8);
                    codearray[7] = reader.GetInt32(9);
                    codearray[8] = reader.GetInt32(10);

                    codearray[9] = reader.GetInt32(11);
                    codearray[10] = reader.GetInt32(12);
                    codearray[11] = reader.GetInt32(13);






                }
                connection.Close();

                this.dv_theme.Rows.Add(id, name,
                    search_color(codearray[0], codearray[1], codearray[2]),
                    search_color(codearray[3], codearray[4], codearray[5]),
                    search_color(codearray[6], codearray[7], codearray[8]),
                    search_color(codearray[9], codearray[10], codearray[11]));
                if (i == row) { break; }



            }

        }

        private void load_combobox()
        {
            cbox_h.Items.Clear();
            cbox_b.Items.Clear();
            cbox_t.Items.Clear();
            cbox_s.Items.Clear();
            connection.Open();
            string sql = "select Name from color";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {

                cbox_h.Items.Add(reader.GetString(0));
                cbox_b.Items.Add(reader.GetString(0));
                cbox_t.Items.Add(reader.GetString(0));
                cbox_s.Items.Add(reader.GetString(0));




            }
            connection.Close();

        }

        //searches the color's name by its code
        private string search_color(int one, int two, int three)
        {

            string name = "";
            connection.Open();
            string sql = "select Name from color where CodeOne='" + one + "' and CodeTwo='" + two + "' and CodeThree='" + three + "'";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {

                name = reader.GetString(0);

            }
            connection.Close();
            return name;


        }

        //checks if the name is already in use. Gives a false if there is one with the same name
        private Boolean check_name(string name) 
        {
            Boolean c = true;
            connection.Open();
            string sql = "select Name from color";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
               
               
                if (name== reader.GetString(0).Trim()) { c = false; break; }
              


            }
            connection.Close();
            return c;
        }
       
        private Boolean check_theme_name(string name) 
        {  
            Boolean c = true;

            connection.Open();
            string sql = "select ThemeName from Theme";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {

               
                if (name == reader.GetString(0).Trim()) { c = false; break; }







            }
            connection.Close();
            return c;
            
        }

        //This onw if the name that was search by the id matches with the name that was inputted it gives true
        private Boolean update_check_theme(string name) 
        {
            Boolean c= false;
            connection.Open();
            string sql = "select ThemeName from Theme where Id=" + int.Parse(lbl_theme_id.Text.ToString());
            
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
              

                if (name == reader.GetString(0).Trim()) {  c = true; break; }


               



            }
            connection.Close();

            return c;
        }

        private Boolean update_check_color(string name)
        {
            Boolean c = false;
            connection.Open();
            string sql = "select Name from color where Id=" + int.Parse(lbl_Id.Text.ToString());
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {


                if (name == reader.GetString(0).Trim()) {  c = true; break; }


               



            }
            connection.Close();

            return c;
        }
        private int search_code(string name, int num) 
        {
            int i = 0;
            string n = "";
            connection.Open();
            string sql = "select CodeOne, CodeTwo, CodeThree from color where Name='" + name + "'";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (num==0)   {  i = reader.GetInt32(0); }
                if (num == 1) { i = reader.GetInt32(1); }
                if (num == 2) { i = reader.GetInt32(2); }
                
              




            }
            connection.Close();
           
            return i;
        
        
        }
        //loads the color for the tables
        private void load_table_color()
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

            dv_color.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(tableone, tabletwo, tablethree);
            dv_theme.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(tableone, tabletwo, tablethree);
            dv_color.BackgroundColor = this.BackColor;
            dv_theme.BackgroundColor = this.BackColor;

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


            
            if (lvl == "Team Leader")
            {
                txt_name.Enabled = false;
                txt_one.Enabled = false;
                txt_two.Enabled = false;
                txt_three.Enabled = false;
                btn_cadd.Enabled = false;
                btn_cdelete.Enabled = false;
                btn_cupdate.Enabled = false;
            }
         

        }


    }
}
