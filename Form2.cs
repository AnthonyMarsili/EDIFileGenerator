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

            //Initialize random number for PO number - based on "4" - month - "00" random number
            Random rnd = new Random();
            int end = rnd.Next(1000, 10000);
            Globals.poNumber = end;
            
            //Set initail delivery date to a week from today
            DeliveryDatePicker.Value = DateTime.Now.AddDays(7);
            
            //Set the originator box to be the first value
            OriginatorBox.SelectedIndex = 0;
        }

        public static class Globals
        {
            //Global variables to hold the PO number and the item numbers
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

        
        //When the create PO button is clicked the PO is generated based on the selected options and the dsiplayed in the output box.
        private void CreatePOButton_Click(object sender, EventArgs e)
        {
            POOutputBox.Text = "";
            String PO = "";
            int NumOfItems = 1;
            String deliveryDate = "20" + DeliveryDatePicker.Value.ToString("yyMMdd");

            //Creating a basic template in a list of strings for a PO that can then be modified per hub
            string[] template = { "ISA", "00", "          ", "00", "          ", "ZZ", "Sender", "ZZ", "Receiver", "000000", "0000", "U", "00401", "000000161", "0", "T", ">", "`",
                                  "GS", "PO", "Sender", "Receiver", "00000000", "0000", "47", "X", "004010", "`",
                                  "ST", "850", "0047", "`",
                                  "BEG", "00", "SA", "", "20", "", "AC", "`",
                                  "CUR", "II", "`",
                                  "REF", "PG","100", "`",
                                  "REF", "PC", "1010", "`",
                                  "REF", "BC", "1010", "`",
                                  "REF", "ZZ", "PRODUCTION", "`",
                                  "PER", "SU", "Test Vendor Company", "TE", "123-123-1234", "FX", "5874 5896", "`",
                                  "PER", "BD", "Test User", "TE", "123456789", "", "", "EM", "test@redwavecommerce.com", "DF", "", "", "01", "EXW", "CI", "SINGAPORE", "`",
                                  "ITD", "", "", "", "", "", "", "30", "", "", "" ,"", "Within 30 days due net", "`",
                                  "N1", "SE", "Vendor Factory", "92", "0000100123", "`",
                                  "N3", "123 Poplar Ave #54321", "`",
                                  "N4", "SINGAPORE", "", "654321", "SG", "`",
                                  "N1", "BT", "MAKINO ASIA PTE LTD", "92", "1010", "`",
                                  "N3", "2 Gul Avenue", "`",
                                  "N4", "Singapore", "", "629649", "SG", "`",
                                  "N1", "ST", "MAKINO ASIA PTE LTD", "92", "1010", "`",
                                  "N3", "166 Gul Circle", "`",
                                  "N4", "Singapore", "", "629622", "SG", "`"

            };

            List<String> words = new List<string>(template);
            List<String> topEnvelope = words.GetRange(0, 32);

            PO += StringModifiers.PutBackTogether(Envelope.TopEnvelope(topEnvelope, OriginatorBox.SelectedItem.ToString(), 850));  
            
            // Makino Specific //
            ////////////////////
            PO += "BEG|00|SA|";
            PO += PONumberGeneretor();
            PO += "||20" + DateTime.Now.ToString("yyMMdd") + "||AC`\r\n";
            PO += "CUR|II|";
            //Add check for curency here
            
            if (USDRadio.Checked)
            {
                PO += "USD";
            }
            else
            {
                PO += "SGD";
            }
            PO += "`\r\n";
            PO += "REF|PG|100`\r\nREF|PC|1010`\r\n";
            PO += "REF|BC|1010`\r\nREF|ZZ|PRODUCTION`\r\n";
            PO += "PER|SU|Test Vendor Company|TE|123-123-1234|FX|5874 5896`\r\n";
            PO += "PER|BD|Test User|TE|123456789|||EM|test@redwavecommerce.com|DF|||01|EXW|CI|SINGAPORE`\r\n";
            PO += "ITD|||||||30|||||Within 30 days due net`\r\n";
            PO += "N1|SE|Vendor Factory|92|0000100123`\r\n";
            PO += "N3|123 Poplar Ave #54321`\r\n";
            PO += "N4|SINGAPORE||654321|SG`\r\n";
            PO += "N1|BT|MAKINO ASIA PTE LTD|92|1010`\r\n";
            PO += "N3|2 Gul Avenue`\r\n";
            PO += "N4|Singapore||629649|SG`\r\n";
            PO += "N1|ST|MAKINO ASIA PTE LTD|92|1010`\r\n";
            PO += "N3|166 Gul Circle`\r\n";
            PO += "N4|Singapore||629622|SG`\r\n";

            if (NumItemsDrop.SelectedItem != null) {
                NumOfItems = Int32.Parse(NumItemsDrop.SelectedItem.ToString());
            }


            if (zeroPercent.Checked && sevenPercent.Checked)
            {
                for (int i = 1; i <= NumOfItems; i++)
                {
                    if (i % 2 == 1)
                    {
                        PO += "PO1|" + lineItemGenerator(i) + "|10|ST|100.99||BP|" + Globals.itemNumber + "`\r\n";
                        PO += "PID|F||||DemoItem" + i + "`\r\n";
                        PO += "TXI|P4||0|||||||GST on import-MES 0%`\r\n";
                        PO += "SCH|10|EA|POA|POA|017|" + deliveryDate + "||002|" + deliveryDate + "`\r\n";
                        Globals.itemNumber++;
                    }
                    else
                    {
                        PO += "PO1|" + lineItemGenerator(i) + "|10|ST|100.99||BP|" + Globals.itemNumber + "`\r\n";
                        PO += "PID|F||||DemoItem" + i + "`\r\n";
                        PO += "TXI|P1||7|||||||Standard - rated 7 %`\r\n";
                        PO += "SCH|10|EA|POA|POA|017|" + deliveryDate + "||002|" + deliveryDate + "`\r\n";
                        Globals.itemNumber++;
                    }
                }
            }
            else if (sevenPercent.Checked)
            {
                for (int i = 1; i <= NumOfItems; i++)
                {
                    PO += "PO1|" + lineItemGenerator(i) + "|10|ST|100.99||BP|" + Globals.itemNumber + "`\r\n";
                    PO += "PID|F||||DemoItem" + i + "`\r\n";
                    PO += "TXI|P1||7|||||||Standard - rated 7 %`\r\n";
                    PO += "SCH|10|EA|POA|POA|017|" + deliveryDate + "||002|" + deliveryDate + "`\r\n";
                    Globals.itemNumber++;
                }
            }
            else if (zeroPercent.Checked)
            {
                for (int i = 1; i <= NumOfItems; i++)
                {
                    PO += "PID|F||||DemoItem" + i + "`\r\n";
                    PO += "TXI|P4||0|||||||GST on import-MES 0%`\r\n";
                    PO += "SCH|10|EA|POA|POA|017|" + deliveryDate + "||002|" + deliveryDate + "`\r\n";
                    Globals.itemNumber++;
                }
            }
            else
            {
                for (int i = 1; i <= NumOfItems; i++)
                {
                    PO += "PO1|" + lineItemGenerator(i) + "|10|ST|100.99||BP|" + Globals.itemNumber + "`\r\n";
                    PO += "PID|F||||DemoItem" + i + "`\r\n";
                    PO += "SCH|10|EA|POA|POA|017|" + deliveryDate + "||002|" + deliveryDate + "`\r\n";
                    Globals.itemNumber++;
                }
            }


            PO += "CTT|" + NumOfItems.ToString() + "|" + (NumOfItems * 10).ToString() + "`\r\n";
            PO += "SE|38|0047`\r\n";
            PO += "GE|1|47`\r\n";
            PO += "IEA|1|161`";

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

       public String lineItemGenerator(int num)
        {
            String line = num + "0";
            while (line.Length < 5){
                line = "0" + line;
            }
            return line;
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

        public void Engine()
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
