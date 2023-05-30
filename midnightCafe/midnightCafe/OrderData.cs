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
    public partial class OrderData : UserControl
    {
        public OrderData()
        {
            InitializeComponent();
        }

        private void OrderData_Load(object sender, EventArgs e)
        {

        }

        public void setOrderDataDetails(string itemName, string itemPrice)
        {
            itemNameLabel.Text = itemName;
            itemPriceLabel.Text = itemPrice;
        }
    }
}
