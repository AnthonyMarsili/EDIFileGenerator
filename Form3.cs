using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDIFileGenerator
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            OriginatorBox.SelectedIndex = 0;
        }

        public static class Globals {
            public static String outputText = "";
        }

        //Main function for converting ASN to RC
        private void Engine(List<String> words) {
            List<String> envelope = new List<String>();
            List<String> bottomEnvVals = new List<String>();
            Boolean flag = true;

            int SE01;

            try
            {

                // 32 is the size of the envelope
                for (int i = 0; i < 32; i++)
                {
                    envelope.Add(words[0]);
                    words.RemoveAt(0);
                }
            }
            catch (Exception e)
            {
                Globals.outputText = "Please ensure your ASN is in the proper format.";
                OutputBox.ForeColor = Color.Red;
                flag = false;
            }

            if (flag)
            {
                //Grab top envelope from ASN and covert for RC
                envelope = Envelope.TopEnvelope(envelope, OriginatorBox.ValueMember, 856);

                //Getting the values for the bottom envelope.
                for(int i = 0; i < 3; i++)
                {
                    bottomEnvVals.Add(envelope[32]);
                    envelope.RemoveAt(32);
                }

                //Adds top envelpope to output text
                Globals.outputText += StringModifiers.PutBackTogether(envelope); 
               
                //Sets body of RC while returning value for SE01
                SE01 = ReceivingAdviceMaker(words);

                //Add bottom envelope to output text
                bottomEnvVals.Insert(0, SE01.ToString());
                bottomEnvelopeMaker(bottomEnvVals);
            }
        }

        //Add bottom envelope to output text       
        private void bottomEnvelopeMaker(List<String> bottomEnvVals) {
            Globals.outputText += "SE*" + bottomEnvVals[0] + "*" + bottomEnvVals[1] + "~\r\n";
            Globals.outputText += "GE*1*" + bottomEnvVals[2] + "~\r\n";
            Globals.outputText += "IEA*1*" + bottomEnvVals[3] + "~\r\n";
        }
        
        //Function to create body of receiveing advice
        private int ReceivingAdviceMaker(List<String> segments) {
            int SEcount = 0;
            String asnNum = segments[2];

            // builds the BRA
            Globals.outputText += "BRA*" + asnNum + 
                "*20" + DateTime.Now.ToString("yyMMdd") + "*06*8~\r\n";
            // builds the REF
            Globals.outputText += "REF*SI*" + asnNum + "~\r\n";
            // builds the DTM
            Globals.outputText += "DTM*999" + "*20" + DateTime.Now.ToString("yyMMdd") + "~\r\n";

            int lineCount = 0;
            String tempLIN;
            String tempQty;
            String poNum = "";

            //Loop runs for each line item in ASN and creates appropriate RC segment. Ends when it reaches the CTT segment
            while (segments[0] != "CTT") {
                if (segments[0] == "~")
                {
                    if (segments[1] == "PRF") {
                        poNum = segments[2];
                    }
                    else if (segments[1] == "LIN") {
                        lineCount++;
                        tempLIN = StringModifiers.PutBackTogether(segments.GetRange(1, 7));
                        tempQty = segments[10];
                        Globals.outputText += "RCD**" + tempQty + "*ST~\r\n";
                        Globals.outputText += tempLIN + "PRF*" + poNum + "~\r\n";
                    }
                    segments.RemoveAt(0);
                }
                else {
                    segments.RemoveAt(0);
                }
            }

            Globals.outputText += "CTT*" + lineCount.ToString() + "~\r\n";

            SEcount = lineCount * 3 + 6; // this is the complex forumla we deduced for the se01

            return SEcount;        
        }

        //Function to create the recieveing advice
        private void ConvertButton_Click(object sender, EventArgs e)
        {
            List<String> words;
            Globals.outputText = "";

            //Split all the words based on the value "|" or "*"
            words = StringModifiers.WholeTextParse(InputBox.Text);

            Engine(words);

            OutputBox.Text = Globals.outputText;

            

        }

        //Clear both text boxes
        private void Clear_Click(object sender, EventArgs e)
        {
            InputBox.Text = "";
            OutputBox.Text = "";
        }

        //Copy output text to clipboard
        private void Copy_Click(object sender, EventArgs e)
        {                
            Clipboard.SetText(OutputBox.Text);
        }

        //Return to form 1
        private void BackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form mainMenu = new Form1();
            mainMenu.Show();
        }

        //Close all form when application is closed
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

}
