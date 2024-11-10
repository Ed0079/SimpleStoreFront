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
    public partial class Taxes : Form
    {
        private static string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static string strConnstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + directory + "\\resources\\data.mdf;Integrated Security=True";
        private static SqlConnection connection = new SqlConnection(strConnstring);

        private static SqlCommand command;
        private static SqlDataReader reader;
        public Taxes()
        {
            InitializeComponent();
        }
        //Loads the taxes
        private void Taxes_Load(object sender, EventArgs e)
        {
            connection.Open();
            string sql = "select Name, [Percent] from [taxes]";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetString(0).ToString());

               
                lvi.SubItems.Add(reader.GetDouble(1).ToString());

                listView1.Items.Add(lvi);
               
            }
            connection.Close();
            Timer MyTimer = new Timer();
            MyTimer.Interval = (10000); 
            MyTimer.Tick += new EventHandler(timer_Tick);
            MyTimer.Start();
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
