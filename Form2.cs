using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace EDIFileGenerator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            //Initialize the initial PO number and delivery date
            Random rnd = new Random();
            int end = rnd.Next(1000, 10000);
            Globals.poNumber = end;
            DeliveryDatePicker.Value = DateTime.Now.AddDays(7);
            OriginatorBox.SelectedIndex = 0;
        }

        public static class Globals
        {
            
            public static int poNumber;
            public static int itemNumber = 12345;
        }


        private void CreatePOButton_Click(object sender, EventArgs e)
        {
            POOutputBox.Text = ""; // clears PO box
            String PO = ""; // initalizes PO string
            
            //Collect the values from the form
            String POnum = PONumberGeneretor();
            String currency;
            int numOfItems;
            
            //Get the number of requested lines else set it to one
            if (NumItemsDrop.SelectedItem != null)
                numOfItems = Int32.Parse(NumItemsDrop.SelectedItem.ToString());
            else 
                numOfItems = 1;

            //Get the currency
            if (USDRadio.Checked)
                currency = "USD";
            else
                currency = "SGD";


            // now check what hub was selected
            // the only option right now is Makino
            // create an instance of the Makino class
            if (OriginatorBox.SelectedItem.ToString() == "Company 1")
            {
                Company1 company1PO = new Company1(POnum, currency, numOfItems, DeliveryDatePicker.Value, zeroPercent.Checked, sevenPercent.Checked);

                PO += company1PO.createCompany1PO(); // call the create PO function in the Makino class with the values we jsut passed in
            }
            else if (OriginatorBox.SelectedItem.ToString() == "Company 2") 
            {
                String[] headerSAClist = buildHeaderSAC();

                Company2 company2PO = new Company2(POnum, currency, numOfItems, DeliveryDatePicker.Value, headerAllowanceRadio.Checked, HeaderChargeRadio.Checked, headerSAClist, ITDneeded.Checked, ITDpercentPicker.Value.ToString());

                PO += company2PO.CreateCompany2PO();
            }

            POOutputBox.Text = PO;
        }

        //Fucntion to generate a semi-random PO number
        public String PONumberGeneretor()
        {
            String poNum = "";
            String initials = InitialsTextBox.Text;
            
            //Set leading initials as TST if no initials are entered
            if (initials == "E.G. TST")
                poNum += "TST" + "4" +  DateTime.Now.ToString("MM") + "00" + Globals.poNumber.ToString();
            else
                poNum += initials + "4" + DateTime.Now.ToString("MM") + "00" + Globals.poNumber.ToString();

            Globals.poNumber++;

            return poNum;
        }

        public String[] buildHeaderSAC() {
            String[] headerSAClist = new string[3];
            
            if (HeaderSACNone.Checked)
                headerSAClist[0] = "false";
            else
            {
                if (headerSACcodeDrop.SelectedIndex > -1) // if they pick a code
                    headerSAClist[0] = headerSACcodeDrop.SelectedItem.ToString(); // put that code into 0
                else
                    headerSAClist[0] = "none"; // if they dont pick a code, put "none" into 0

                if (headerSACdropdown.SelectedIndex > -1) // if they choose a type
                {
                    if (headerSACdropdown.SelectedItem.ToString() == "Amount") // if the type is amount
                    {
                        headerSAClist[1] = SACNumberPicker.Value.ToString("0.00"); // put the number with 2 decimals into 1
                        headerSAClist[2] = "-1"; // put -1 into 2
                    }
                    else if (headerSACdropdown.SelectedItem.ToString() == "Percent")
                    {
                        headerSAClist[1] = "-1";
                        headerSAClist[2] = SACNumberPicker.Value.ToString("0.0");
                    }
                }
                else // if they do not choose a type. still need to initalize index 1 and 2
                {
                    headerSAClist[1] = "false";
                    headerSAClist[2] = "false";
                }
                
            }
            return headerSAClist;
        }

        //Function to take user back to Form 1
        private void BackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form mainMenu = new Form1();
            mainMenu.Show();
        }

        //Funtion to clear text box if original text is present otherwise highlight full text for easy typing
        private void InitialsTextBox_Click(object sender, EventArgs eventArgs)
        {
            if (InitialsTextBox.Text == "E.G. TST")
            {
                InitialsTextBox.Text = "";
                InitialsTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            }
            else
            {
                InitialsTextBox.SelectionStart = 0;
                InitialsTextBox.SelectionLength = InitialsTextBox.Text.Length;
            }
        }

        //Copy current text in output box to clipboard
        private void POCopy_Click(object sender, EventArgs e)
        {
            //Check that the box is not empty
            if (POOutputBox.Text == "")
                Clipboard.SetText(" ");
            else
                Clipboard.SetText(POOutputBox.Text);
        }

        //Clear the output box as well as all the form options
        private void Clear_Click(object sender, EventArgs e)
        {
            POOutputBox.Text = "";
            InitialsTextBox.Text = "E.G. TST";
            InitialsTextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            USDRadio.Checked = true;
            NumItemsDrop.SelectedIndex = -1;
            DeliveryDatePicker.Value = DateTime.Now.AddDays(7);
            zeroPercent.Checked = false;
            sevenPercent.Checked = false;
            HeaderSACNone.Checked = true;
            headerSACdropdown.SelectedIndex = -1;
            SACNumberPicker.Value = 0;
            headerSACcodeDrop.SelectedIndex = -1;
            ITDneeded.Checked = false;
            ITDpercentPicker.Value = 0;
        }

        //Close all forms on application close
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void OriginatorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OriginatorBox.SelectedItem.ToString() != "Company 2") // need a seperate if clause for the attributes specific to each hub
            {
                tableLayoutPanel6.Enabled = false;
                tableLayoutPanel10.Enabled = false;
            }
            else
            {
                tableLayoutPanel6.Enabled = true;
                tableLayoutPanel10.Enabled = true;
            }

            if (OriginatorBox.SelectedItem.ToString() != "Company 1")
            {
                tableLayoutPanel3.Enabled = false;
                SGDRadioBtn.Enabled = false;
            }
            else 
            {
                tableLayoutPanel3.Enabled = true;
                SGDRadioBtn.Enabled = true;
            }
        }
        private void headerSACdropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (headerSACdropdown.SelectedIndex > -1) // to account for when we clear this selection
            {
                if (headerSACdropdown.SelectedItem.ToString() == "Percent")
                {
                    SACNumberPicker.Maximum = 100;
                    SACNumberPicker.DecimalPlaces = 1;
                    SACNumberPicker.Value = 0;
                }
                else
                {
                    SACNumberPicker.Maximum = 10000;
                    SACNumberPicker.DecimalPlaces = 2;
                    SACNumberPicker.Value = 0;
                }
            }
        }

        private void ITDneeded_CheckedChanged(object sender, EventArgs e)
        {
            if (!ITDneeded.Checked)
                ITDpercentPicker.Enabled = false;
            else
                ITDpercentPicker.Enabled = true;
        }

        private void HeaderSACNone_CheckedChanged(object sender, EventArgs e)
        {
            if (HeaderSACNone.Checked)
                tableLayoutPanel8.Enabled = false;
            else
                tableLayoutPanel8.Enabled = true;
        }
    }
}
