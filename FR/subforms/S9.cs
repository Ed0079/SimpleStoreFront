using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace StoreFront.FR.subforms
{
    public partial class S9 : Form
    {
        private static string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static string strConnstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + directory + "\\resources\\data.mdf;Integrated Security=True";
        private static SqlConnection connection = new SqlConnection(strConnstring);
        private static SqlDataAdapter adapter = new SqlDataAdapter("select * from login", strConnstring);
        private static SqlCommand command;
        private static SqlDataReader reader;
        public S9()
        {
            InitializeComponent();
            load_table();
            load_color();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
           

            switch (cbox_filter.SelectedItem.ToString().Split(new string[] { ": " }, StringSplitOptions.None).Last())
            {
                case "-Id-":
                    (dv_sales.DataSource as DataTable).DefaultView.RowFilter = String.Format("CONVERT(Id, System.String) like '%" + txt_search.Text + "%'");

                    break;
                case "-Id of Machine-":
                    (dv_sales.DataSource as DataTable).DefaultView.RowFilter = String.Format("CONVERT(IdOfMachine, System.String) like '%" + txt_search.Text + "%'");
                    
                    break;
                case "-Id of User-":
                    (dv_sales.DataSource as DataTable).DefaultView.RowFilter = String.Format("CONVERT(IdOfUser, System.String) like '%" + txt_search.Text + "%'");
                   
                    break;
                case "-UserName-":
                    (dv_sales.DataSource as DataTable).DefaultView.RowFilter = String.Format("UserName like '%" + txt_search.Text + "%'");
                   
                    break;
                case "-Section-":
                    (dv_sales.DataSource as DataTable).DefaultView.RowFilter = String.Format("Section like '%" + txt_search.Text + "%'");

                    break;
                case "-Total-":
                   ( dv_sales.DataSource as DataTable).DefaultView.RowFilter = String.Format("CONVERT(Total, System.String) like '%" + txt_search.Text + "%'");

                    break;
                case "-Payment-":
                    (dv_sales.DataSource as DataTable).DefaultView.RowFilter = String.Format("Payment like '%" + txt_search.Text + "%'");

                    break;
                case "-Date-":
                    (dv_sales.DataSource as DataTable).DefaultView.RowFilter = String.Format("Date like '%" + txt_search.Text + "%'");

                    break;
                case "-Confirm-":
                    (dv_sales.DataSource as DataTable).DefaultView.RowFilter = String.Format("Confirm like '%" + txt_search.Text + "%'");
                    break;
            }
            
            
        }

        private void load_table()
        {
            txt_search.Clear();
            cbox_filter.SelectedIndex = cbox_filter.FindStringExact("-Id-");

            connection.Open();
            string sql = "select * from [sales]";
            adapter = new SqlDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dv_sales.DataSource = dt;
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

            dv_sales.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(tableone, tabletwo, tablethree);
            dv_sales.BackgroundColor = this.BackColor;

            dv_sales.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(tableone, tabletwo, tablethree);
            dv_sales.BackgroundColor = this.BackColor;

        }
        //print
        private void btn_print_Click(object sender, EventArgs e)
        {
           
           
            DialogResult dialogResult = MessageBox.Show("Is everything ready to go?"," Ready to print ? ", MessageBoxButtons.YesNo);
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
            string val_8 = "";
            string val_9 = "";
           
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
            while (reader.Read()){ name = reader.GetString(0); }
            connection.Close();

            sql = "select Id from [user] where Name = '" + name + "' ";
            connection.Open();
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read()){id = reader.GetInt32(0).ToString();}
            connection.Close();

            
            e.Graphics.DrawString("Id: " + id, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(0, space));
            e.Graphics.DrawString("Date: " + date, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(450, space));
            space += 30;
            e.Graphics.DrawString(name, new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(0, space));
            e.Graphics.DrawString("Sales Table", new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(450, space));
            space += 50;
            e.Graphics.DrawString(dashes, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(0, space));
            space += 30;
            e.Graphics.DrawString("Id | Id Of Machine | Id of User | Username | Section | Total | Payment | Confirm | Date", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(0, space));
            space += 30;
            for (int i = 0; i < dv_sales.Rows.Count; i++)
            {
                space += 40;
                val_1 = dv_sales.Rows[i].Cells[0].Value.ToString();
                val_2 = dv_sales.Rows[i].Cells[1].Value.ToString();
                val_3 = dv_sales.Rows[i].Cells[2].Value.ToString();
                val_4 = dv_sales.Rows[i].Cells[3].Value.ToString();
                val_5 = dv_sales.Rows[i].Cells[4].Value.ToString();
                val_6 = dv_sales.Rows[i].Cells[5].Value.ToString();
                val_7 = dv_sales.Rows[i].Cells[6].Value.ToString();
                val_8 = dv_sales.Rows[i].Cells[7].Value.ToString();
                val_9 = dv_sales.Rows[i].Cells[8].Value.ToString();

                e.Graphics.DrawString(val_1.Trim() + " | " + val_2.Trim() + " | " + val_4.Trim() + " | " + val_5.Trim() + " | " + val_3.Trim() + " | " + val_7.Trim() + " | " + val_6.Trim() + " | " + val_9.Trim() + " | " + val_8.Trim(), new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(0, space));

            }
            space += 20;

            e.Graphics.DrawString(dashes, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(0, space));
          
        }
    }
}
