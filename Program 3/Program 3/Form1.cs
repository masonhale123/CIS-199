/* Grading ID: R1738
 * Program 3
 * 11/05/2020
 * CIS 190-01
 * This application lets the user to input the order state, the order product number, and the quantity, and return a price of an item 
 * and will return the discount, tax and total cost of the order.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //array for tax rate according to state
        double[] discountRates = { 0.06, 0.0717, 0.07, 0.0874 };
        //array for cost per unit for each product
        double[] costPerUnit = { 7.87, 9.51, 10.73, 9.99, 11.99, 5.00, 4.58 };

        private void button1_Click(object sender, EventArgs e)
        {
            //variables
            int productNumber;
            int qunatity;
            double dblInitialCost;
            double dblDiscountedCost = 0;
            double dblTax;
            double dblTotalCost;

            //accepts the users input of the product number
            Int32.TryParse(textProduct.Text, out productNumber);
            if (productNumber >= 1001 && productNumber <= 1007)
            {
                //accpets users input of quantity
                Int32.TryParse(textQuantity.Text, out qunatity);
                //calculates initial cost
                dblInitialCost = costPerUnit[(productNumber % 10) - 1] * qunatity;
                //these if/else if statements calculate the cost after discount when the user inputs the quantity
                if (qunatity <= 4)
                    dblDiscountedCost = dblInitialCost;
                else if (qunatity >= 5 && qunatity <= 9)
                    dblDiscountedCost = dblInitialCost - dblInitialCost * 0.05;
                else if (qunatity >= 10 && qunatity <= 19)
                    dblDiscountedCost = dblInitialCost - dblInitialCost * 0.1;
                else if (qunatity >= 20)
                    dblDiscountedCost = dblInitialCost - dblInitialCost * 0.15;

                //calculates tax 
                dblTax = dblDiscountedCost * discountRates[comboState.SelectedIndex];

                //calculates the total cost
                dblTotalCost = dblDiscountedCost + dblTax;

                //these display the 
                lblInitial.Text = dblInitialCost.ToString("C2");
                lblDisc.Text = dblDiscountedCost.ToString("C2");
                lblTax.Text = dblTax.ToString("C2");
                lblTotal.Text = dblTotalCost.ToString("C2");
            }


        }
    }
}

