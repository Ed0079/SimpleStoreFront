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
    public partial class S6 : Form
    {
        private static string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static string strConnstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + directory + "\\resources\\data.mdf;Integrated Security=True";
        private static SqlConnection connection = new SqlConnection(strConnstring);
        private static SqlDataAdapter adapter = new SqlDataAdapter("select * from login", strConnstring);
        private static SqlCommand command;
        private static SqlDataReader reader;
        public S6()
        {
            InitializeComponent();
            load_table();
            load_color();
        }
        //buttons
        private void btn_done_Click(object sender, EventArgs e)
        {
            if (lbl_id.Text.Length != 0)
            {
                string resolved = "No";
                if (cbox_resolved.Checked) { resolved = "Yes"; } else { resolved = "No"; }


                SqlCommand cmd = new SqlCommand("update incidentreport set  Description=@d, Resolved=@r where Id = '" + lbl_id.Text.ToString() + "'", connection);
                connection.Open();


                cmd.Parameters.AddWithValue("@d", rtxt_des.Text.ToString());
                cmd.Parameters.AddWithValue("@r", resolved);



                cmd.ExecuteNonQuery();


                connection.Close();
                load_table();
            }
            else { MessageBox.Show("Something is missing please check", "Empty fields"); }
        }

        private void dv_ir_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
                DataGridViewRow row = this.dv_ir.Rows[e.RowIndex];
                lbl_id.Text = row.Cells["id"].Value.ToString();
                lbl_user.Text = row.Cells["user"].Value.ToString();
                lbl_category.Text = row.Cells["category"].Value.ToString();
                lbl_machine.Text = row.Cells["machine"].Value.ToString();
                rtxt_des.Text = row.Cells["description"].Value.ToString();
                lbl_date.Text = row.Cells["date"].Value.ToString();
                string r = row.Cells["resolved"].Value.ToString();
                if (r =="Yes") { cbox_resolved.Checked = true; }
                else { cbox_resolved.Checked = false;}

            }
            catch
            {
          
            }
        }

        //methods
        private void load_table() 
        {
            lbl_id.Text = "";
            lbl_user.Text = "";
            lbl_machine.Text = "";
            lbl_date.Text = "";
            lbl_category.Text = "";
            rtxt_des.Text = "";
            cbox_resolved.Checked = false;
            string sql = "select * from [incidentreport]";
            adapter = new SqlDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dv_ir.DataSource = dt;
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

            dv_ir.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(tableone, tabletwo, tablethree);
            dv_ir.BackgroundColor = this.BackColor;

        }
    }
}
