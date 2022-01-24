using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace log_in
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbutton_Click(object sender, EventArgs e)
        {
            string x, a;
            x = txtuser.Text;
            a = txtpass.Text;
            if (x == "jawad" && a == "12345")
            {
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
                txtuser.Focus();
            }
            else
            {
                MessageBox.Show("invalid username or password");
                txtuser.Text = "";
                txtpass.Text = "";

            }
        }
    }
}
