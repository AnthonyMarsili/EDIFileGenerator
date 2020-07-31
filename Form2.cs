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

        private void Create_Click(object sender, EventArgs e)
        {
            poBox.Text = "";
            String PO = "";
            DateTime today = DateTime.Now.AddDays(7);
            String deliveryDate = "20" + today.ToString("yyMMdd");

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
            if (true)
            {
                PO += "SGD";
            }
            else
            {
                PO += "USD";
            }
            PO += "`\r\nREF | PG | 100`\r\nREF | PC | 1010`\r\nREF | BC | 1010`\r\nREF | ZZ | PRODUCTION`\r\nPER|SU|";
            PO += "|Test Vendor Company|TE|123-123-1234|FX|5874 5896`\r\n";
            PO += "PER | BD |Test User| TE |123456789||| EM | test@redwavecommerce.com`\r\nFOB | DF ||| 01 | EXW | CI | SINGAPORE`\r\n";
            PO += "ITD ||||||| 30 ||||| Within 30 days due net`\r\n";
            PO += "N1 | SE | Vendor Factory | 92 | 0000100123`\r\nN3 | 123 Poplar Ave #54321`\r\nN4 | SINGAPORE || 654321 | SG`\r\n";
            PO += "N1|BT|MAKINO ASIA PTE LTD|92|1010`\r\nN3 | 2 Gul Avenue`\r\nN4 | Singapore || 629649 | SG`\r\n";
            PO += "N1|ST|MAKINO ASIA PTE LTD|92|1010`\r\nN3 | 166 Gul Circle`\r\nN4 | Singapore || 629622 | SG`\r\n";
           
            //Enter number of line items wanted here
            for (int i = 1; i <= 3; i++)
            {
                PO += "PO1|000" + i + "0|10|ST|100.99||BP|1CD024A-90.5`\r\n";
                PO += "PID | F |||| ATC PANEL, CX19(VBMTC) SET`\r\nTXI | P1 || 7 ||||||| Standard - rated 7 %`\r\nSCH | 10 | ST | POA | POA | 017 |";
                PO += deliveryDate + "||002|" + deliveryDate + "`\r\n";
            }
            
            //Enter number of lines instead of "3"
            PO += "CTT|" + "3" + "|10`\r\nSE | 38 | 0047`\r\nGE | 1 | 47`\r\nIEA | 1 | 161`\r\n";

            poBox.Text = PO;

        }

        public String PONumberGeneretor()
        {
            String poNum = "";
            Random rnd = new Random();
            int end = rnd.Next(1000, 10000);

            //Add the intials from the menu here instead of ND
            poNum += "ND" + "4" + DateTime.Now.ToString("MM") + "00" + end.ToString();
           
            return poNum;
        }
    }
}
