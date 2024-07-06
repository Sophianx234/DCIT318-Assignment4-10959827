using System;
using System.Windows.Forms;

namespace AddressBookApp
{
    public partial class AddressBookForm1 : Form
    {
        public AddressBookForm1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string email = textBoxEmail.Text;
            string phone = textBoxPhone.Text;
            MessageBox.Show($"Name: {name}\nEmail: {email}\nPhone: {phone}");
        }
    }
}
