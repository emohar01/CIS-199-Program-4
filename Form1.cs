// Name: A5508
// Program 4
// Due Date: 4/25/17
//Description:  This program allows you to type in the shipping information for a package (origin zip, destination zip, length,
//width, height, and weight) and figure out how much it cost to ship.  There's a details button the show all the information
//about the package, a Send from UofL button that sets the origin zip code to 40292, and a Send to UofL button that
//sets the origin zip code to 40292 as well.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program4
{
    public partial class GroundPackageForm : Form
    {
        // Precondition: None
        // Postcondition: Form is constructed and ready to display
        public GroundPackageForm()
        {
            InitializeComponent();
        }

        const int ulZip = 40292; // Constant to hold the zip code of UofL

        List<GroundPackage> packageList = new List<GroundPackage>(); // List to hold the ground packages is created.
        
        // Precondition: User clicked the Add button
        // Postcondition: If all of the input data for the package is valid
        //                then that package is added to the package list and 
        //                its cost is added to the package list box.
        private void addBtn_Click(object sender, EventArgs e)
        {
            const int MAX_ZIP = 99999; // Constant to hold the maximum zip code

            int originZip; // Variable to hold the origin zip
            int destZip; // Variable to hold the destination zip
            double length; // Variable to hold the length
            double width; // Variable to hold the width
            double height; // Variable to hold the height
            double weight; // Variable to hold the weight

            if(int.TryParse(originZipTxtBox.Text, out originZip) && (originZip >= 0) && (originZip <= MAX_ZIP))
            {
                if(int.TryParse(destZipTxtBox.Text, out destZip) && (destZip >= 0) && (destZip <= MAX_ZIP))
                {
                    if(double.TryParse(lengthTxtBox.Text, out length) && (length > 0))
                    {
                        if(double.TryParse(widthTxtBox.Text, out width) && (width > 0))
                        {
                            if(double.TryParse(heightTxtBox.Text, out height) && (height > 0))
                            {
                                if(double.TryParse(weightTxtBox.Text, out weight) && ( weight > 0))
                                {
                                    // new GroundPackage object is created
                                    GroundPackage Package = new GroundPackage(originZip,destZip,length,width,height,weight);

                                    // new Package is added to packageList and cost is added to packageListBox
                                    packageList.Add(Package);
                                    packageListBox.Items.Add(Package.CalcCost().ToString("c"));
                                }
                                else
                                    MessageBox.Show("Please enter a valid weight.");
                            }
                            else
                                MessageBox.Show("Please enter a valid height.");
                        }
                        else
                            MessageBox.Show("Please enter a valid width.");
                    }
                    else
                        MessageBox.Show("Please enter a valid length.");
                }
                else
                    MessageBox.Show("Please enter a valid ZIP code.");
            }
            else
                MessageBox.Show("Please enter a valid ZIP code.");
        }

        // Precondition: User clicked the Details button
        // Postcondition: A message box is dispayed with the selected package's data.
        private void descriptioBtn_Click(object sender, EventArgs e)
        {
            int index = packageListBox.SelectedIndex; // Variable to hold the index number between the list and the list box
            if (index != -1)
            {
                MessageBox.Show(packageList[index].ToString());
            }
            else
                MessageBox.Show("Please select an item from the list.");
        }

        // Precondition: User clicked the Send From UofL button
        // Postcondition: The origin zip of the selected package is changed to UofL's zip code
        private void sendfrmULBtn_Click(object sender, EventArgs e)
        {
            int index = packageListBox.SelectedIndex; // Variable to hold the index number between the list and the list box
            packageList[index].OriginZip = ulZip;
            packageListBox.Items[index] = packageList[index].CalcCost().ToString("c");

            MessageBox.Show(packageList[index].ToString());
        }

        // Precondition: User clicked the Send to UofL button
        // Postcondition: The destination zip of the selected package is changed to UofL's zip code
        private void sendtoULBtn_Click(object sender, EventArgs e)
        {
            int index = packageListBox.SelectedIndex; // Variable to hold the index number between the list and the list box
            packageList[index].DestinationZip = ulZip;
            packageListBox.Items[index] = packageList[index].CalcCost().ToString("c");

            MessageBox.Show(packageList[index].ToString());
        }
    }
}
