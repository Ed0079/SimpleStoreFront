using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreFront.FR.subforms
{
    public partial class S3 : Form
    {
        public S3()
        {
            InitializeComponent();
        }
        //buttons
        private void btn_intro_Click(object sender, EventArgs e)
        {
            gbox_start.Visible = true;
            gbox_option.Visible = false;
            gbox_buttons_p1.Visible = false;
           
            gbox_authority.Visible = false;
          
        }

        private void btn_level_Click(object sender, EventArgs e)
        {
            gbox_start.Visible = false;
            gbox_option.Visible = false;
            gbox_buttons_p1.Visible = false;
          
            gbox_authority.Visible = true;
         
        }

        private void btn_btn_Click(object sender, EventArgs e)
        {
            gbox_start.Visible = false;
            gbox_option.Visible = false;
            gbox_buttons_p1.Visible = true;
           
            gbox_authority.Visible = false;
         
        }

        private void btn_option_Click(object sender, EventArgs e)
        {
            gbox_start.Visible = false;
            gbox_option.Visible = true;
            gbox_buttons_p1.Visible = false;
           
            gbox_authority.Visible = false;
           
        }

       
    }
}
