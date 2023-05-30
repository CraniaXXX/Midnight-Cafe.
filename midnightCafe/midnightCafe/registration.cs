using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midnightCafe
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login n = new login();
            User newUser = new User();
            newUser.FIRSTNAME = textBox1.Text;
            newUser.LASTNAME = textBox3.Text;
            newUser.EMAIL = textBox2.Text;
            newUser.PASSWORD = textBox4.Text;
            newUser.BIRTHDATE = textBox5.Text;
            newUser.GENDER = textBox9.Text;

            n.RegisterUser(newUser);
            n.Show();
            this.Hide();
        }

        private void registration_Load(object sender, EventArgs e)
        {

        }
    }
}
