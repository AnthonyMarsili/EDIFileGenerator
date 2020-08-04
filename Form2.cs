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
        }

        private void CreatePOButton_Click(object sender, EventArgs e)
        {
            POOutputBox.Text = "";
            String PO = "";
            int NumOfItems = 1;
            String deliveryDate = "20" + DeliveryDatePicker.Value.ToString("yyMMdd");

            PO += "ISA|00|          |00|          |ZZ|MASINGAPOREMEQ |ZZ|MAKINOSUPP     |";
            PO += DateTime.Now.ToString("yyMMdd") + "|";
            PO += DateTime.Now.ToString("HHmm");
            PO += "|U|00401|000000161|0|T|>`\r\nGS | PO | MASINGAPOREMEQ | MAKINOSUPP |";
            PO += "20" + DateTime.Now.ToString("yyMMdd") + "|";
            PO += DateTime.Now.ToString("HHmm");
            PO += "| 47 | X | 004010`\r\nST | 850 | 0047`\r\nBEG | 04 | SA |";
            PO += PONumberGeneretor();
            PO += "|| 20200731 || AC`\r\nCUR | II |";
            //Add check for curency here
            
            if (USDRadio.Checked)
            {
                PO += "USD";
            }
            else
            {
                PO += "SGD";
            }
            PO += "`\r\nREF | PG | 100`\r\nREF | PC | 1010`\r\nREF | BC | 1010`\r\nREF | ZZ | PRODUCTION`\r\nPER|SU|";
            PO += "|Test Vendor Company|TE|123-123-1234|FX|5874 5896`\r\n";
            PO += "PER | BD |Test User| TE |123456789||| EM | test@redwavecommerce.com`\r\nFOB | DF ||| 01 | EXW | CI | SINGAPORE`\r\n";
            PO += "ITD ||||||| 30 ||||| Within 30 days due net`\r\n";
            PO += "N1 | SE | Vendor Factory | 92 | 0000100123`\r\nN3 | 123 Poplar Ave #54321`\r\nN4 | SINGAPORE || 654321 | SG`\r\n";
            PO += "N1|BT|MAKINO ASIA PTE LTD|92|1010`\r\nN3 | 2 Gul Avenue`\r\nN4 | Singapore || 629649 | SG`\r\n";
            PO += "N1|ST|MAKINO ASIA PTE LTD|92|1010`\r\nN3 | 166 Gul Circle`\r\nN4 | Singapore || 629622 | SG`\r\n";

            if (NumItemsDrop.SelectedItem != null) {
                NumOfItems = Int32.Parse(NumItemsDrop.SelectedItem.ToString());
            }

            for (int i = 1; i <= NumOfItems; i++)
            {
                PO += "PO1|000" + i + "0|10|ST|100.99||BP|1CD024A-90.5`\r\n";
                PO += "PID | F |||| ATC PANEL, CX19(VBMTC) SET`\r\nTXI | P1 || 7 ||||||| Standard - rated 7 %`\r\nSCH | 10 | ST | POA | POA | 017 |";
                PO += deliveryDate + "||002|" + deliveryDate + "`\r\n";
            }
            
            PO += "CTT|" + NumOfItems.ToString() + "|10`\r\nSE | 38 | 0047`\r\nGE | 1 | 47`\r\nIEA | 1 | 161`\r\n";

            POOutputBox.Text = PO;

        }

        public String PONumberGeneretor()
        {
            String poNum = "";
            String initials = InitialsTextBox.Text;
            Random rnd = new Random();
            int end = rnd.Next(1000, 10000);

            if (initials == "E.G. AM")
            {
                poNum += "TST4" + DateTime.Now.ToString("MM") + "00" + end.ToString();
            }
            else
            {
                poNum += initials + "4" + DateTime.Now.ToString("MM") + "00" + end.ToString();
            }
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
            if (InitialsTextBox.Text == "E.G. AM")
            {
                InitialsTextBox.Text = "";
                InitialsTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            }
        }


    }
}
