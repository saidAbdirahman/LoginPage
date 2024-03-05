using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                passwordtextbox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordtextbox.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernametextbox.Text;
            string password = passwordtextbox.Text;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please Username and Password are required!!");
            }
            else
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
        }
    }
}
