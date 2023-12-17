using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkLang.AppData;

namespace ParkLang
{
    public partial class Register : Form
    {
        public object errorProvider;

        public Register()
        {
            InitializeComponent();
            UserRepo = new UserRepository();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                errorProvider.Clear();
                errorProvider.SetError(txtUsername, "Empty Field");
                return;
            }
            if (String.IsNullOrEmpty(txtPassword.Text)) 
            {
                errorProvider.Clear();
                errorProvider.SetError(txtPassword.Text, "Empty Field");
                return;
            }
            errorProvider.Clear();
            UserRepo res = userRepo.Register(txtUsername, txtPassword);
            if (res == ErrorCode.Success)
            {
                txtUsername.Clear();
                txtPassword.Clear();
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Error! Registration");
            }
        }
    }
}
