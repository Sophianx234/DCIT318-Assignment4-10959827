using System;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class LoginScreen : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            MessageBox.Show($"Username: {username}\nPassword: {password}");
        }
    }
}
