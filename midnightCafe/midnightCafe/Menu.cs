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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            CheckOutPanel.Hide();
        }
        Dictionary<string, string> orderData = new Dictionary<string, string>();
        List<string> addsOn = new List<string>();

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            var t = ((RadioButton)sender);

            if (t.Checked == true)
            {
                addsOn.Add(t.Text);

            }
            else
            {
                addsOn.Remove(t.Text);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            var t = ((RadioButton)sender);

            if (t.Checked == true)
            {
                addsOn.Add(t.Text);

            }
            else
            {
                addsOn.Remove(t.Text);
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            var t = ((CheckBox)sender);

            if (t.Checked == true)
            {
                orderData.Add(t.Text, milkTeaPrice6.Text);

            }
            else
            {
                orderData.Remove(t.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckOutPanel.Show();
            CheckOutPanel.BringToFront();
            showAllOrders();
            addsOnLabel.Text = addsOn[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbOkinawa.Checked = false;
            cbWintermelon.Checked = false;
            cbDarkChocoMilktea.Checked = false;
            cbBobohClassic.Checked = false;
            cbTaro.Checked = false;
            cbMatcha.Checked = false;

            cbCaffeLatte.Checked = false;
            cbCappucinoLatte.Checked = false;
            cbSpanishLatte.Checked = false;
            cbDarkMochaLatte.Checked = false;
            cbVanillaBeanLatte.Checked = false;
            cbCaramelMacchiatoLatte.Checked = false;

            tbCreamCheese.Checked = false;
            rbCocoJelly.Checked = false;
            rbPearl.Checked = false;
            rbCreampuff.Checked = false;

            cmbModofPayment.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CheckOutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbOkinawa_CheckedChanged(object sender, EventArgs e)
        {
            var t = ((CheckBox)sender);

            if (t.Checked == true)
            {
                orderData.Add(t.Text, milkTeaPrice1.Text);

            }
            else
            {
                orderData.Remove(t.Text);
            }
        }

        private void cbWintermelon_CheckedChanged(object sender, EventArgs e)
        {
            var t = ((CheckBox)sender);

            if (t.Checked == true)
            {
                orderData.Add(t.Text, milkTeaPrice2.Text);

            }
            else
            {
                orderData.Remove(t.Text);
            }
        }

        private void cbDarkChocoMilktea_CheckedChanged(object sender, EventArgs e)
        {
            var t = ((CheckBox)sender);

            if (t.Checked == true)
            {
                orderData.Add(t.Text, milkTeaPrice3.Text);

            }
            else
            {
                orderData.Remove(t.Text);
            }
        }

        private void cbBobohClassic_CheckedChanged(object sender, EventArgs e)
        {
            var t = ((CheckBox)sender);

            if (t.Checked == true)
            {
                orderData.Add(t.Text, milkTeaPrice4.Text);

            }
            else
            {
                orderData.Remove(t.Text);
            }
        }

        private void cbTaro_CheckedChanged(object sender, EventArgs e)
        {
            var t = ((CheckBox)sender);

            if (t.Checked == true)
            {
                orderData.Add(t.Text, milkTeaPrice5.Text);

            }
            else
            {
                orderData.Remove(t.Text);
            }
        }

        private void cbCaffeLatte_CheckedChanged(object sender, EventArgs e)
        {
            var t = ((CheckBox)sender);

            if (t.Checked == true)
            {
                orderData.Add(t.Text, iceCoffeePrice1.Text);

            }
            else
            {
                orderData.Remove(t.Text);
            }
        }

        private void cbCappucinoLatte_CheckedChanged(object sender, EventArgs e)
        {
            var t = ((CheckBox)sender);

            if (t.Checked == true)
            {
                orderData.Add(t.Text, iceCoffeePrice2.Text);

            }
            else
            {
                orderData.Remove(t.Text);
            }
        }

        private void cbSpanishLatte_CheckedChanged(object sender, EventArgs e)
        {
            var t = ((CheckBox)sender);

            if (t.Checked == true)
            {
                orderData.Add(t.Text, iceCoffeePrice3.Text);

            }
            else
            {
                orderData.Remove(t.Text);
            }
        }

        private void cbDarkMochaLatte_CheckedChanged(object sender, EventArgs e)
        {
            var t = ((CheckBox)sender);

            if (t.Checked == true)
            {
                orderData.Add(t.Text, iceCoffeePrice4.Text);

            }
            else
            {
                orderData.Remove(t.Text);
            }
        }

        private void cbVanillaBeanLatte_CheckedChanged(object sender, EventArgs e)
        {
            var t = ((CheckBox)sender);

            if (t.Checked == true)
            {
                orderData.Add(t.Text, iceCoffeePrice5.Text);

            }
            else
            {
                orderData.Remove(t.Text);
            }
        }

        private void cbCaramelMacchiatoLatte_CheckedChanged(object sender, EventArgs e)
        {
            var t = ((CheckBox)sender);

            if (t.Checked == true)
            {
                orderData.Add(t.Text, iceCoffeePrice6.Text);

            }
            else
            {
                orderData.Remove(t.Text);
            }
        }

        private void tbCreamCheese_CheckedChanged(object sender, EventArgs e)
        {
            var t = ((RadioButton)sender);

            if (t.Checked == true)
            {
                addsOn.Add(t.Text);

            }
            else
            {
                addsOn.Remove(t.Text);
            }
        }

        private void rbCocoJelly_CheckedChanged(object sender, EventArgs e)
        {
            var t = ((RadioButton)sender);

            if (t.Checked == true)
            {
                addsOn.Add(t.Text);

            }
            else
            {
                addsOn.Remove(t.Text);
            }
        }

        public void showAllOrders()
        {
            int amount = 0;

            foreach (var item in orderData)
            {
                OrderData newOrder = new OrderData();
                amount += Convert.ToInt32(item.Value);

                newOrder.setOrderDataDetails(item.Key, item.Value);

                flowLayoutPanel1.Controls.Add(newOrder);
            }
            totalLabel.Text = Convert.ToString(amount);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            printBtn.Visible = true;
            homeBtn.Visible = true;
            button5.Visible = false;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            CheckOutPanel.Hide();
            CheckOutPanel.SendToBack();
            printBtn.Visible = false;
            homeBtn.Visible = false;
            button5.Visible = true;
        }
    }
}
