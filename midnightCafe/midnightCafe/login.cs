using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace midnightCafe
{
    internal partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        Dictionary<string, User> USERS = new Dictionary<string, User>();

        private void button1_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();

            if (USERS.ContainsKey(textBox1.Text) && textBox2.Text.Equals(USERS[textBox1.Text].PASSWORD))
            {
                m.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registration r = new registration();
            r.Show();
            this.Hide();
        }

        public void RegisterUser(User user)
        {
            if (!USERS.ContainsKey(user.EMAIL))
            {
                USERS.Add(user.EMAIL, user);
            }
            else
            {
                MessageBox.Show("Email is taken!");
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}