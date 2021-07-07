//By: B1706
//Program 1
//Due: 2/14/17
//CIS-199-02

//This program allows users to input the Sq. Ft. of the wall
//they want painted, the number of coats they want, and the 
//price per gal of the paint. It then displays the labor, 
//requirements, and cost for the painting job.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class Form1 : Form
    {
        //Declare constant fields to hold numerical values.
        const float SQUARE_FEET = 330.0f; //330.0 ft of wall space for every gallon of paint.
        const float LABOR_HOURS = 6.0f; //6 hrs of labor for every gallon of paint.
        const float COST_PER_LABOR_HOUR = 10.50f; //$10.50 per labor hour.

        public Form1()
        {
            InitializeComponent();
        }

        //Calculate and display the requirements for the painting job.
        private void calcOrderButton_Click(object sender, EventArgs e)
        {
            float squareFeet; //The square feet to be painted.
            int coatsOfPaintDesired; //The number of coats of paint.
            float pricePerGallon; //The price of the paint per gallon.

            float totalSqFeet; //The total Square Feet needed.
            float galPaintUsed;
            int galPaintReq; //The total nuber of gallons of paint needed.
            float laborHrsReq; //The total number of labor hours needed.
            float paintCost; //The cost of the paint.
            float laborCost; //The cost of the labor.
            float totalCost; //The total cost of the job.

            //Convert input from the textboxes to decimal.
            squareFeet = float.Parse(sqFeetTextBox.Text);
            coatsOfPaintDesired = int.Parse(coatsOfPaintTextBox.Text);
            pricePerGallon = float.Parse(paintPricePerGalTextBox.Text);

            //Calculate the total Sq Feet to be painted display 
            //in fixed-format.
            totalSqFeet = squareFeet * coatsOfPaintDesired;
            totalSqFeetLabel.Text = totalSqFeet.ToString("f1");

            //Calculate the Gallons of paint required for the Job. 
            galPaintUsed = (totalSqFeet / SQUARE_FEET);
            galPaintReq = (int)Math.Ceiling(galPaintUsed);
            gallonsReqLabel.Text = galPaintReq.ToString("d");

            //Calculate the labor hours required for the job 
            //and display in fixed-format.
            laborHrsReq = galPaintUsed * LABOR_HOURS;
            laborHrsReqLabel.Text = laborHrsReq.ToString("f1");

            //Calculate the total cost of the labor and display 
            //in the currency format.
            laborCost = laborHrsReq * COST_PER_LABOR_HOUR;
            laborCostLabel.Text = laborCost.ToString("c");

            //Calculate the total cost of the paint and
            //display in the currency format.
            paintCost = galPaintReq * pricePerGallon;
            paintCostLabel.Text = paintCost.ToString("c");

            //Calculate the total cost of the job and 
            //display in the currency format.
            totalCost = paintCost + laborCost;
            totalCostLabel.Text = totalCost.ToString("c");

        }
        
        //Clears the form.
        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the textboxes.
            sqFeetTextBox.Text = "";
            coatsOfPaintTextBox.Text = "";
            paintPricePerGalTextBox.Text = "";

            //Clear the labels.
            totalSqFeetLabel.Text = "";
            gallonsReqLabel.Text = "";
            laborHrsReqLabel.Text = "";
            paintCostLabel.Text = "";
            laborCostLabel.Text = "";
            totalCostLabel.Text = "";
        }
    }
}
