using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lbHello.Text = "Hello Window form c# ..!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbHello.Text = "Text has been concel!";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {   
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            lbHello.Text = "Hello C# window form again!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbHello.Text = "Login Success";
        }
    }
}
