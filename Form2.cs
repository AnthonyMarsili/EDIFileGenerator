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

        private String PutBackTogether(List<String> inputList)
        {
            //Put all the words back together with proper delimiters 
            String output = "";
            int counter = 0;
            int length = inputList.Count;
            while (counter < length)
            {
                if (inputList[1] == "~" || inputList[1] == "`")
                {
                    output += inputList[0] + "~\r\n";
                    inputList.RemoveAt(0);
                    inputList.RemoveAt(0);
                    counter++;
                    counter++;
                }
                else
                {
                    output += inputList[0];
                    output += "*";
                    inputList.RemoveAt(0);
                    counter++;
                }
            }
            return output;
        }

        private void CreatePOButton_Click(object sender, EventArgs e)
        {
            POOutputBox.Text = ""; // clears PO box
            String PO = ""; // initalizes PO string
            
            // now we get our values from the form
            String deliveryDate = "20" + DeliveryDatePicker.Value.ToString("yyMMdd");
            String POnum = PONumberGeneretor();
            String currency;
            int numOfItems;
            
            if (NumItemsDrop.SelectedItem != null)
                numOfItems = Int32.Parse(NumItemsDrop.SelectedItem.ToString());
            else 
                numOfItems = -1;

            if (USDRadio.Checked)
                currency = "USD";
            else
                currency = "SGD";


            // now check what hub was selected
            // the only option right now is Makino
            // create an instance of the Makino class
            if (OriginatorBox.SelectedItem.ToString() == "Makino")
            {
                Makino makinoPO = new Makino(POnum, currency, numOfItems, deliveryDate, zeroPercent.Checked, sevenPercent.Checked);

                PO += makinoPO.createMakinoPO(); // call the create PO function in the Makino class with the values we jsut passed in
            }

            POOutputBox.Text = PO;
        }

        public String PONumberGeneretor()
        {
            String poNum = "";
            String initials = InitialsTextBox.Text;
            

            if (initials == "E.G. TST")
            {
                poNum += "TST" + DateTime.Now.ToString("MM") + "00" + Globals.poNumber.ToString();
            }
            else
            {
                poNum += initials + "4" + DateTime.Now.ToString("MM") + "00" + Globals.poNumber.ToString();
            }

            Globals.poNumber++;

            return poNum;
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form mainMenu = new Form1();
            mainMenu.Show();
        }

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

        private void POCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(POOutputBox.Text);
        }

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

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
