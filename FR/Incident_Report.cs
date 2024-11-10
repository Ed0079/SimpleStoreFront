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
    public partial class Incident_Report : Form
    {
        private static string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static string strConnstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + directory + "\\resources\\data.mdf;Integrated Security=True";
        private static SqlConnection connection = new SqlConnection(strConnstring);
        private static SqlDataAdapter adapter = new SqlDataAdapter("select * from user", strConnstring);
        private static SqlCommand command;
        private static SqlDataReader reader;
        public Incident_Report()
        {
            InitializeComponent();
            connection.Open();
            string sql = "select ActiveUser from [Machine] Where IdofMachine='1'";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read()) { lbl_signed.Text = reader.GetString(0); }
            
            connection.Close();
        }

       //what add/send the report
        private void btn_send_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string u=lbl_signed.Text.ToString();
            string c="Not checked";
            string d= now.ToString();
            string m="machine 001";
            string de=rtbox_report.Text.ToString();

            connection.Open();
            string sql = "select IdofMachine, ActiveUser from [Machine] ";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read()) { m = reader.GetInt32(0).ToString(); c = reader.GetString(1); }
            connection.Close();

            if (rbtn_lv1.Checked) { c = rbtn_lv1.Text.ToString(); }
            else if (rbtn_lv2.Checked) { c = rbtn_lv2.Text.ToString(); }
            else if (rbtn_lv3.Checked) { c = rbtn_lv3.Text.ToString(); }

            if (rtbox_report.Text.Length != 0)
            {
                if (rbtn_lv1.Checked || rbtn_lv2.Checked || rbtn_lv3.Checked)
                {
                    connection.Open();

                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "INSERT incidentreport (SignedUser, Category , Date , Machine , Description , Resolved ) VALUES ('" + u + "','" + c + "','" + d + "','" + m + "','" + de + "','No')";
                    command.ExecuteNonQuery();
                    connection.Close();
                  
                   rtbox_report.Clear();
                    rbtn_lv1.Checked = false;
                    rbtn_lv2.Checked = false;
                    rbtn_lv3.Checked = false;
                    MessageBox.Show("The Report has been sent","Sent");
                }
                else { MessageBox.Show("Please check the field as something is missing", "Missing fields"); }
            }
            else { MessageBox.Show("Please check the field as something is missing", "Missing fields"); }
        }
    }
}
