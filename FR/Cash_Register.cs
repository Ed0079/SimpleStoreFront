using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Printing;

namespace StoreFront.FR
{
    public partial class Cash_Register : Form
    {

        private static string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static string strConnstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + directory + "\\resources\\data.mdf;Integrated Security=True";
        private static SqlConnection connection = new SqlConnection(strConnstring);

        private static SqlCommand command;
        private static SqlDataReader reader;

        AutoCompleteStringCollection itemcol = new AutoCompleteStringCollection();
        AutoCompleteStringCollection discountcol = new AutoCompleteStringCollection();
        Dictionary<int, string> dict = new Dictionary<int, string>();
        Dictionary<string, double> AD = new Dictionary<string, double>();
        Dictionary<string, double> SD = new Dictionary<string, double>();
        public Cash_Register()
        {
            InitializeComponent();
        }

        private void Cash_Register_Load(object sender, EventArgs e)
        {
            load_search();
        }

        //buttons , clicks, & text changes
        private void Add_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            if (cbox_name.Text.Length != 0)
            {
                if (int.TryParse(cbox_qty.Text.ToString(), out x))
                {
                    if (cbox_qty.Text.Length != 0 && int.Parse(cbox_qty.Text.ToString()) > 0)
                    {


                        if (int.TryParse(cbox_name.Text.ToString(), out y))
                        {
                            y = Int32.Parse(cbox_name.Text.ToString());
                            if (dict.ContainsKey(y) == true) { check_storage(); }
                            else { MessageBox.Show("There's no item by that name or id", "item not found"); }
                        }
                        else if (cbox_name.Items.Contains(cbox_name.Text.ToString())) { check_storage(); }
                        else { MessageBox.Show("There's no item by that name or id", "item not found"); }



                    }
                    else { MessageBox.Show("There's no qty selected", "Qty Problem"); }
                }
                else { MessageBox.Show("incorrect input", "Error"); }
            }
            else { MessageBox.Show("There's no item been placed", "item Problem"); }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            for (int i = lv_cart.Items.Count - 1; i >= 0; i--)
            {
                if (lv_cart.Items[i].Selected)
                {
                    lv_cart.Items[i].Remove();
                }
            }
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            if (lv_cart.Items.Count != 0)
            {
                if (last_check())
                {
                    payment();
                }

            }
            else { MessageBox.Show("It seems that there is nothing in the cart", "Cart is empty"); }
        }

        private void btn_discount_Click(object sender, EventArgs e)
        {
            string x = cbox_txtdiscount.Text.ToString();
            if (SD.ContainsKey(x) == true)
            {
                if (AD.ContainsKey(cbox_txtdiscount.Text.ToString()) == false)
                {
                    check_usage();
                    cbox_discount.Checked = false;
                    cbox_txtdiscount.Text = "";
                }
                else { MessageBox.Show("That code is already in use", "All ready active"); }
            }
            else { MessageBox.Show("The code you entered is not found in our database.", "Not found"); }
        }

        private void btn_taxes_Click(object sender, EventArgs e)
        {
            Taxes mores = new Taxes();
            mores.Show();


        }

        private void lv_cart_Click(object sender, EventArgs e)
        {
            cbox_name.Text = lv_cart.SelectedItems[0].Text;
            cbox_qty.Text = lv_cart.SelectedItems[0].SubItems[1].Text;

        }

        private void cbox_discount_Click(object sender, EventArgs e)
        {


        }

        private void cbox_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbox_discount_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_discount.Checked) { panel_discount.Visible = true; }
            else { panel_discount.Visible = false; }
        }

        private void cbox_txtdiscount_TextChanged(object sender, EventArgs e)
        {
            string x = cbox_txtdiscount.Text.ToString();
            if (SD.ContainsKey(x) == true) { }
        }

        private void rbtn_other_Click(object sender, EventArgs e)
        {
            gbox_other.Visible = true;
        }

        private void rbtn_cash_Click(object sender, EventArgs e)
        {
            gbox_other.Visible = false;
        }

        //checks in storage if the article is available
        private void check_storage()
        {

            int x;
            int y = Int32.Parse(cbox_qty.Text.ToString());
            string n = "";
            int q = 0;
            double p = 0;
            //If use the id of the item
            if (int.TryParse(cbox_name.Text.ToString(), out x))
            {
                connection.Open();
                string sql = "select Name, Qty, Price from [storage] where Id ='" + cbox_name.Text.ToString() + "'";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    n = reader.GetString(0).ToString();

                    q = reader.GetInt32(1);
                    p = reader.GetDouble(2);


                }
                connection.Close();
            }
            //if you use the name
            else
            {
                connection.Open();
                string sql = "select Name, Qty, Price from [storage] where Name ='" + cbox_name.Text.ToString() + "'";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    n = reader.GetString(0).ToString();

                    q = reader.GetInt32(1);
                    p = reader.GetDouble(2);
                }
                connection.Close();

            }

            if (y <= q)
            {
                Boolean m = false;
                int id;
                for (id = 0; id < lv_cart.Items.Count; id++)
                {

                    if (lv_cart.Items[id].SubItems[0].Text.ToString() == n)
                    {

                        m = true;
                        break;

                    }



                }

                if (m == true)
                {
                    y = Int32.Parse(lv_cart.Items[id].SubItems[1].Text.ToString()) + y;
                    if (y <= q)
                    {
                        p = p * y;

                        ListViewItem lvi = new ListViewItem(n);

                        lvi.SubItems.Add(y.ToString());
                        lvi.SubItems.Add(p.ToString());

                        lv_cart.Items.Add(lvi);
                        lv_cart.Items[id].Remove();
                    }
                    else { MessageBox.Show("Sorry but we don't have much left in storage", "Inventory out"); }
                }
                else
                {
                    p = p * y;

                    ListViewItem lvi = new ListViewItem(n);

                    lvi.SubItems.Add(y.ToString());
                    lvi.SubItems.Add(p.ToString());

                    lv_cart.Items.Add(lvi);
                }
                update_totals();
            }
            else { MessageBox.Show("Sorry but we don't have much in storage", "Inventory out"); }




        }

        private void check_usage()
        {
            connection.Open();
            int x = 0;
            string sql = "select Usage from [discounts] where Code ='" + cbox_txtdiscount.Text.ToString() + "'";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                x = reader.GetInt32(0);


            }
            connection.Close();

            if (x > 0)
            {
                update_totals();
                AD.Add(cbox_txtdiscount.Text.ToString(), SD[cbox_txtdiscount.Text.ToString()]);

                MessageBox.Show("Discount has been added", "Successful");
            }
            else { MessageBox.Show("Discount is expired", "Discount discontinued"); }

        }

        //double checks if everything is  in stock
        private Boolean last_check()
        {
            Boolean x = true;
            Boolean y = true;
            Boolean z = true;

            int i = 0;
            int ii = 0;
            int storage_usage = 0;
            int active_usage = 0;
            int storage_qty = 0;
            int listview_qty = 0;
            string test="";
            string sql = "";

            for (i = 0; i < lv_cart.Items.Count; i++)
            {
                connection.Open();


                sql = "select Qty from [storage] where Name ='" + lv_cart.Items[i].SubItems[0].Text.ToString() + "'";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    storage_qty = reader.GetInt32(0);
                }
                connection.Close();

                listview_qty = Int32.Parse(lv_cart.Items[i].SubItems[1].Text.ToString());
                if (storage_qty < listview_qty)
                {
                    x=false;
                    break;
                }
            }

            if (AD.Count > 0)
            {
                for (ii = 0; ii < AD.Count; ii++)
                {
                    connection.Open();
                    sql = "select Usage from [discounts] where Code ='" + AD.ElementAt(ii).Key.ToString() + "'";
                    command = new SqlCommand(sql, connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        storage_usage = reader.GetInt32(0);


                    }

                    connection.Close();
                    if (storage_usage <= 0)
                    {
                        y = false;
                        break;
                    }
                }
            }
            if (x == false || y == false) { z = false; }
            if (x == false) { MessageBox.Show("Something went wrong with '" + lv_cart.Items[i].SubItems[0].Text.ToString() + "'", "Error please try again"); }
            if (y == false) { MessageBox.Show("Discount has been expired and has been removed", "Discount error"); AD.Remove(AD.ElementAt(ii).Key.ToString()); }
           return z;
        }

        private void update_totals()
        {



            if (lv_cart.Items.Count != 0) {
                decimal sub = 0;
                for (int i = 0; i < lv_cart.Items.Count; i++)
                {
                    sub = decimal.Parse(lv_cart.Items[i].SubItems[2].Text.ToString()) + sub;


                }


                if (AD.Count > 0) { decimal d = sub * AP(); sub = sub - d; }
                sub = decimal.Round(sub, 2, MidpointRounding.AwayFromZero);
                lbl_s.Text = sub.ToString();


                double x = 0;
                decimal y = 0;
                decimal z = 0;

                connection.Open();
                string sql = "select [Percent] from [taxes]";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    x = reader.GetDouble(0);
                    y = decimal.Parse(lbl_s.Text.ToString()) * decimal.Parse(x.ToString());


                    z = z + y;



                }
                z = decimal.Parse(lbl_s.Text.ToString()) + z;
                connection.Close();

                z = decimal.Round(z, 2, MidpointRounding.AwayFromZero);
                lbl_t.Text = z.ToString();


            }

        }

        //Combines all the active discount/percentages
        private decimal AP()
        {
            decimal i = 0;
            foreach (decimal val in AD.Values)
            {
                i += val;

            }

            return i;

        }

        //Loads items to the combo box and enables to search items by id
        private void load_search()
        {
            connection.Open();
            string sql = "select Id, Name, Qty, Price from [storage]";
            cbox_name.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbox_name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbox_txtdiscount.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbox_txtdiscount.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                itemcol.Add(reader.GetString(1).ToString().Trim());
                cbox_name.Items.Add(reader.GetString(1).Trim());

                dict.Add(reader.GetInt32(0), reader.GetString(1).Trim());




            }

            connection.Close();
            connection.Open();
            sql = "select Code, [Percent] from [discounts]";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                discountcol.Add(reader.GetString(0).ToString());
                cbox_txtdiscount.Items.Add(reader.GetString(0).ToString());
                SD.Add(reader.GetString(0).ToString(), reader.GetDouble(1));
            }
            connection.Close();

            cbox_name.AutoCompleteCustomSource = itemcol;
            cbox_txtdiscount.AutoCompleteCustomSource = discountcol;

        }
        //updates the storage
        private void update_data()
        {
           
           
                for (int i = 0; i < lv_cart.Items.Count; i++)
                {
                    int storage_qty= get_qty(lv_cart.Items[i].Text.ToString());
                    int cart_qty = Int32.Parse(lv_cart.Items[i].SubItems[1].Text.ToString());

                    cart_qty = storage_qty - cart_qty;
                    SqlCommand cmd = new SqlCommand("update storage set Qty=@qty where Name='"+lv_cart.Items[i].Text.ToString()+"'", connection);
                    connection.Open();

                    cmd.Parameters.AddWithValue("@qty", cart_qty);

                    cmd.ExecuteNonQuery();
                   
                    connection.Close();

                   
                }
                if (AD.Count>0) 
                {
                    for (int ii = 0; ii < AD.Count; ii++)
                    {
                        int active_discount = 1;
                        int discount_usage = get_usage(AD.ElementAt(ii).Key.ToString());

                        active_discount = discount_usage - active_discount;
                        SqlCommand cmd = new SqlCommand("update discounts set Usage=@use where Code='" + AD.ElementAt(ii).Key.ToString() + "'", connection);
                        connection.Open();

                        cmd.Parameters.AddWithValue("@use", active_discount);

                        cmd.ExecuteNonQuery();


                        connection.Close();


                    }
            }
            AD.Clear();
            lv_cart.Items.Clear();
            cbox_name.Text = "";
            cbox_qty.Text = "";
            lbl_t.Text = "0.00";
            lbl_s.Text = "0.00";
            cbox_discount.Checked = false;
            panel_discount.Visible = false;
            rbtn_cash.Checked = false;
            rbtn_other.Checked = false;
            gbox_other.Visible = false;
            rbt_other_one.Visible = false;
            rbt_other_two.Visible = false;
            rbt_other_three.Visible = false;
            rbt_other_one.Checked = false;
            rbt_other_two.Checked = false;
            rbt_other_three.Checked = false;
            cbox_txtdiscount.Text = "";
        }

        //only used in update as a way to have it more org
        int get_qty(string n)
        {
            connection.Close();
            int qty = 0;
            connection.Open();
            string sql = "select Qty from [storage] where Name ='" + n + "'";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {


                qty = reader.GetInt32(0);



            }
            connection.Close();
            return qty;
        }

        int get_usage(string y)
        {

            connection.Open();
            int x = 0;
            string sql = "select Usage from [discounts] where Code ='" + y + "'";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                x = reader.GetInt32(0);


            }

            connection.Close();
            return x;
        }
        //gives the sales table what payment its being use 
        private void payment() 
        {

            Confirm confirm = new Confirm();

            string im = "placeholder";
            string s = "placeholder";
            string iu = "placeholder";
            string u = "placeholder";
            string pay = "placeholder";
            double t = double.Parse(lbl_t.Text);
            string d = DateTime.Now.ToLongDateString();
            if (rbtn_cash.Checked || rbtn_other.Checked & rbt_other_one.Checked || rbtn_other.Checked & rbt_other_two.Checked || rbtn_other.Checked & rbt_other_three.Checked)
            {
                    if (rbtn_other.Checked)
                    {
                        if (rbt_other_one.Checked) { pay = "PayPal"; }
                        else if (rbt_other_two.Checked) { pay = "Credit"; }
                        else if (rbt_other_three.Checked) { pay = "Debit"; }
                        else { MessageBox.Show("Please check a payment method"); }

                    }
                    else if (rbtn_cash.Checked) { pay = "Cash"; }


                    //search 
                    connection.Open();
                    string sql = "select IdofMachine, ActiveUser,Section from [Machine]";
                    command = new SqlCommand(sql, connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        im = reader.GetInt32(0).ToString();
                        u = reader.GetString(1);
                        s = reader.GetString(2);
                    }
                    connection.Close();

                    //more user info
                    connection.Open();
                    sql = "select Id from [user] where Name='" + u + "'";
                    command = new SqlCommand(sql, connection);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        iu = reader.GetInt32(0).ToString();

                    }
                    connection.Close();

                    //create entry
                    connection.Open();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "INSERT sales (IdOfMachine, Section,IdOfUser, UserName , Payment ,Total ,Date ,Confirm) VALUES ('" + im + "','" + s + "','" + iu + "','" + u + "','" + pay + "'," + t + ",'" + d + "','No')";
                    command.ExecuteNonQuery();
                    connection.Close();
                    //confirm form
                    confirm.FormClosed += F_FormClosed;

                    confirm.Show();
               
            }
            else { MessageBox.Show("Please check a payment method"); }

        }

        //prints the receipt
        private void PD_PrintPage(object sender, PrintPageEventArgs e)
        {

            //datebase variable
            string id = id_and_name(1);
            string name = id_and_name(2);
            string id_user = id_and_name(3);
            string username = id_and_name(4);
            //form variable & machine
            string date = DateTime.Now.ToLongDateString(); ;
            string item = "item";
            string price = "price";
            string qty = "qty";
            string code = "code";
            string percent = "percent";
            //function only variables
            int space = 10;
            string dashes = "--------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString("Id: " + id, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(5, space));
            space += 10;
            //space=20
            e.Graphics.DrawString(dashes, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(0, space));
            space += 30;
            //space=50
            e.Graphics.DrawString(name, new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(300, space));
            space += 20;
            //space=70
            e.Graphics.DrawString(dashes, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(0, space));

            //space=110
            for (int i = 0; i < lv_cart.Items.Count; i++)
            {
                space += 40;
                item = lv_cart.Items[i].SubItems[0].Text.ToString();
                price = lv_cart.Items[i].SubItems[2].Text.ToString();
                qty = lv_cart.Items[i].SubItems[1].Text.ToString();
                e.Graphics.DrawString(item.Trim() + "  |   " + qty.Trim() + "  |   " + price.Trim(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(0, space));

            }
            space += 20;

            e.Graphics.DrawString(dashes, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(0, space));
            space += 30;
            e.Graphics.DrawString("Discounts:", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(0, space));
            if (AD.Count != 0)
            {
                for (int i = 0; i < AD.Count; i++)
                {
                    space += 40;
                    code = AD.Keys.ElementAt(i);
                    percent = AD.Values.ElementAt(i).ToString();
                    e.Graphics.DrawString(code + ": " + percent, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(30, space));


                }
            }
            else { space += 40; e.Graphics.DrawString("None are applied", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(30, space)); }
            space += 20;
            e.Graphics.DrawString(dashes, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(0, space));
            space += 30;
            e.Graphics.DrawString("SubTotal: $"+lbl_s.Text.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(0, space));
            space += 30;
            e.Graphics.DrawString("Total: $"+lbl_t.Text.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(0, space));
            space += 30;
            e.Graphics.DrawString(dashes, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(0, space));
            space += 40;
            e.Graphics.DrawString("Thank you so much for your purchase!", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(140, space));
            space += 30;
            e.Graphics.DrawString("We truly appreciate your support and hope you enjoy", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(60, space));
            space += 30;
            e.Graphics.DrawString(" our service. If you have any questions assistance ,", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(75, space));
            space += 30;
            e.Graphics.DrawString("please don't hesitate to reach out to us", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(140, space));
            space += 30;
            e.Graphics.DrawString("Thanks again!", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(300, space));
            space += 30;
            e.Graphics.DrawString(dashes, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(0, space));
            space += 30;
            e.Graphics.DrawString("Id of Employee: " + id_user, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(0, space));
            space += 40;
            e.Graphics.DrawString("Employee Name: " + username, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(0, space));
            e.Graphics.DrawString(date, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(500, space));
        }
        //returns the id and name of the program/machine also the active user 
        private string id_and_name(int i)
        {
            string val = "id or name";
            int val_key = 1;
            int vel_key = 2;
            string sql = " ";
            if (i == 1) { sql = "select IdofMachine, ActiveUser from [Machine] "; }
            else if (i == 2) { sql = "select ProgramName from [Machine] "; }
            else if (i == 3 || i == 4 || i == 1) { sql = "select ActiveUser from [Machine] "; }


            connection.Open();
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (i == 1) { val_key = reader.GetInt32(0); val = reader.GetString(1); }
                else { val = reader.GetString(0); }




            }
            connection.Close();
            if (i == 3 || i == 1)
            {
                sql = "select Id from [user] where Name = '" + val + "' ";
                connection.Open();
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (i == 1) { vel_key = reader.GetInt32(0); }
                    else { val = reader.GetInt32(0).ToString(); }




                }
                connection.Close();


            }
            if (i == 1)
            {

                sql = "select Id from [sales] where  IdOfMachine=" + val_key + "and IdOfUser =" + vel_key + " and UserName= '" + val + "'";
                connection.Open();
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {

                    val = reader.GetInt32(0).ToString();




                }
                connection.Close();
            }


            return val;


        }
       //after the confirm page is close it checks if the payment went throw then if yes it will print the receipt and use the update_data method
        private void F_FormClosed(object sender, FormClosedEventArgs e)
          {

            string c = "No";
            string u = "placeholder";
            string d = DateTime.Now.ToLongDateString();

            connection.Open();
            string sql = "select ActiveUser,Section from [Machine]";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                u = reader.GetString(0);
               
            }
            connection.Close();


            connection.Open();
            sql = "select Confirm from [sales] where UserName='" +u  +"' and Date='"+d+"'";
            command = new SqlCommand(sql, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                c = reader.GetString(0);



            }
            connection.Close();


           
           
            if (c=="Yes")
            {PPD.Document = PD; PPD.ShowDialog(); update_data(); }
            else if(c=="No") { }
           }
    }
}
