/* Grading ID: R1738
 * Program 2
 * 10/15/2020
 * CIS 190-01
 * This application lets the user enter a packages weight, delivery distance, and number of days they want it delivered in 
 * and gives prices for three companies and picks the company with the lowest cost.
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

namespace Program_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double weight, miles, total_cost, total_weight, total_miles;
            int day;

            bool compA, compB, compC;
            compA = double.TryParse(textWght.Text, out weight);
            compB = double.TryParse(textDis.Text, out miles);
            compC = int.TryParse(textDay.Text, out day);

            if (compA == true && compB == true && compC == true)
            {
                //Company A
                if (weight > 0 && miles > 0 && day > 0)
                {
                    //total miles cost
                    total_miles = miles * 0.02;

                    //total weightost
                    total_weight = weight;

                    //total cost accounting for number of days
                    if (day == 1)
                    {
                        total_cost = 20.0 + (total_miles) + (total_weight);
                        lblAcost.Text = total_cost.ToString("$#,##0.00");
                    }
                    else if (day == 2)
                    {
                        total_cost = 17.0 + (total_miles) + (total_weight);
                        lblAcost.Text = total_cost.ToString("$#,##0.00");
                    }
                    else if (day == 3)
                    {
                        total_cost = 15.0 + (total_miles) + (total_weight);
                        lblAcost.Text = total_cost.ToString("$#,##0.00");
                    }
                    else if (day >= 4 && day <= 7)
                    {
                        total_cost = 10.0 + (total_miles) + (total_weight);
                        lblAcost.Text = total_cost.ToString("$#,##0.00");
                    }
                    else
                    {
                        total_cost = 7.0 + (total_miles) + (total_weight);
                        lblAcost.Text = total_cost.ToString("$#,##0.00");
                    }

                }
                else
                {
                    MessageBox.Show("Numbers invalid -- Please enter valid numbers");
                    return;
                }

                //company B
                if (weight > 0 && miles > 0 && day > 0)
                {
                    total_weight = 0;
                    total_miles = miles * 0.10;

                    if (weight < 10)
                        total_weight = 3;

                    else if (weight >= 10 && weight < 50)
                        total_weight = 5.0;

                    else if (weight >= 50 && weight < 100)
                        total_weight = 10.0;

                    else if (weight >= 100 && weight < 200)
                        total_weight = 20.0;

                    else if (weight >= 200)
                        total_weight = weight * 0.15;

                    if (day >= 1 && day <= 4)
                    {
                        total_cost = 10.0 + (total_miles) + total_weight;
                        lblBcost.Text = total_cost.ToString("$#,##0.00");
                    }
                    else if (day > 4)
                    {
                        total_cost = 7.0 + (total_miles) + (total_weight);
                        lblBcost.Text = total_cost.ToString("$#,##0.00");
                    }

                }
                else
                {
                    MessageBox.Show("Numbers invalid -- Please enter valid numbers");
                    return;
                }

                //company C
                if (weight > 0 && miles > 0 && day > 0)
                {
                    total_weight = weight * 0.25;
                    total_miles = 0;

                    if (miles >= 1000) total_miles = 40;

                    else if (miles >= 750 && miles < 1000)
                        total_miles = 35;

                    else if (miles >= 500 && miles < 750)
                        total_miles = 25;

                    else if (miles >= 200 && miles < 500)
                        total_miles = 15;

                    else if (miles < 200)
                        total_miles = 10;

                    total_cost = 20.0 + total_miles + (total_weight);
                    lblCcost.Text = total_cost.ToString("$#,##0.00");

                }
                else
                {
                    MessageBox.Show("Numbers invalid -- Please enter valid numbers");
                    return;
                }

                    compA = double.TryParse(lblAcost.Text.Trim('$'), out double a);
                    compB = double.TryParse(lblBcost.Text.Trim('$'), out double b);
                    compC = double.TryParse(lblCcost.Text.Trim('$'), out double c);

                //shows company with the lowest cost in the box
                if (a < b && a < c) lblLow.Text = "The lowest Cost Company is" + ": A";

                if (b < a && b < c) lblLow.Text = "The lowest Cost Company is" + ": B";

                if (c < a && c < b) lblLow.Text = "The lowest Cost Company is" + ": C";

                }
                else
                {
                    MessageBox.Show("Numbers invalid -- Please enter valid numbers");
                    return;
                }


        }
    }
}
