using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }
        private void login()
        {
            string Id = txtID.Text;
            string Pw = Password.Text;
            if (Id == "01" && Pw == "123")
            {
                this.Hide();
                Form1 f = new Form1();
                f.Show();


            }
            else
            {
                MessageBox.Show("User ID or Password incorrect!");
            }
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void ResetForm()
        {
            txtID.Text = "";
            Password.Text = "";
        }
        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                login();
            }
            if (e.KeyChar == (char)Keys.F1)
            {
                ResetForm();
            }
            
        }
    }
}
