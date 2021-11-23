/* Grading ID: R1738
 * Lab 2
 * 09/13/2020
 * CIS 190-01
 * This program lets the user enter the price of a meal from a restaurant and calculates three different tip percentages at the click of a button using a form.
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

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void buttonCalc_Click(object sender, EventArgs e) // This event enables the code below to be ran when the button is clicked
        {
            Double price, tip1, tip2, tip3; // these variables represent the price of meal, tip1 (15%), tip2 (18%), and tip3 (20%)

            price = double.Parse(textBoxPrice.Text);

            tip1 = price * .15;
            textBoxTip1.Text = tip1.ToString("c");

            tip2 = price * .18;
            textBoxTip2.Text = tip2.ToString("c");

            tip3 = price * .20; 
            textBoxTip3.Text = tip3.ToString("c");

        }
    }
}
