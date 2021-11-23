/* Grading ID: R1738
 * Lab 3
 * 09/20/2020
 * CIS 190-01
 * This program lets the user enter the radius of a circle and at the click of a button it will display the diameter, surface area, and volume of said circle
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

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e) // the code under this will run when the "Calculate button is clicked"
        {
            double radius, diameter, area, volume, pi = Math.PI; //these variables represent every label on the form along with pi (3.14)

            radius = double.Parse(radiusTb.Text);

            diameter = 2 * radius;//calculates diameter
            diameterLbl.Text = diameter.ToString("0.00");

            area = 4 * pi * Math.Pow(radius,2);//calculates radius
            surfaceareaLbl.Text = area.ToString("0.00");

            volume = (4  * pi * Math.Pow(radius,3)) / 3;//calculates volume
            volumeLbl.Text = volume.ToString("0.00");
        }
    }
}
