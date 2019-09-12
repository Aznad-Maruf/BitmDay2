using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void saveButton2_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void saveButton2_Click_1(object sender, EventArgs e)
        {
                string customerName, contactNo, address, order, temp, item;
                int quantity, unitPrice, totalBill;
                bool isNum;

                customerName = customerNameTextBox.Text;
                contactNo = contactNoTextBox.Text;
                address = addressTextBox.Text;
                order = orderComboBox.Text;

                if (order == "" || quantityTextBox.Text == "")
                {
                    MessageBox.Show("Select order and quantity");
                }
                else
                {

                    quantity = Convert.ToInt32(quantityTextBox.Text);

                    temp = ""; isNum = false; item = "";
                    for (int a_i = 0; a_i < order.Length; a_i++)
                    {
                        if (isNum) temp += order[a_i];
                        if (!isNum && order[a_i] != '-') item += order[a_i];
                        if (order[a_i] == '-') isNum = true;
                    }

                    unitPrice = Convert.ToInt32(temp);

                    totalBill = unitPrice * quantity;

                    temp = quantity + " cup of " + item + " Coffee\nTotal bill : " + totalBill.ToString() + " Taka\n\nCustomer : "+customerName+"\nContact : "+contactNo+"\nAddress : "+address;
                    showInfoRichTextBox.Text = temp;
                }
        }
    }
}
