/* Grading ID: R1738
 * Program 1
 * 09/22/2020
 * CIS 190-01
 * This is an application that will be used for estimating the materials and labor costs for our hardwood sales and installation company.
 * The user can enter the specifications of the room and it will give you the total cost.
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

namespace Program_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {

            const double underlaycost = 4.25; //constant for underlay cost
            const double laborcost = 3.25; // constant for labor cost
            const int firstroomcost = 50; // constant for first room cost
                
            double length, width, hwprice, sqyards, hwcost, total, underlayprice, laborprice; // variables that the user will input along with variables needed to calculate sqyards and the cost/total
            int underlayment, firstroom; // these variables are used for the text boxes that the user will enter a 1 or 0 in


            //below is code that allows associates the value that the user inputs to the specific variable 
            length = double.Parse(maxWidthtb.Text);
                width = double.Parse(maxLengthtb.Text);
                hwprice = double.Parse(hardwoodPricetb.Text);
                underlayment = Convert.ToInt32(underlayTb.Text);
                firstroom = Convert.ToInt32(firstRoomTb.Text);
                
                // below is the formula to calculate the square yards
                sqyards = (length * width) / 9;
                sqYardslbl.Text = sqyards.ToString("0.0");
                
                // below is the formula that calculates the hardwood price per square yard
                hwcost = sqyards * hwprice * 1.1;
                hwCostlbl.Text = hwcost.ToString("c");

            // below is an if and else statement that tells the application whether or not to include the cost of underlay
            if (underlayment == 1) underlayprice = (sqyards * underlaycost);
            else underlayprice = 0;
            
            underlayCostlbl.Text = underlayprice.ToString("c");

            // below is an if statement that tells the application whether or not the 50 dollar first room fee is to be added into the labor cost
            laborprice = (sqyards * laborcost);
            if (firstroom == 1) laborprice += firstroomcost;
            
            laborcostlbl.Text = laborprice.ToString("c");

            // below is the formula to calculate the total cost
            total = hwcost + underlayprice + laborprice;
            totallbl.Text = total.ToString("c");














        }
    }
}
