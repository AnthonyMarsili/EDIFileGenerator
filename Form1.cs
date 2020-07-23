using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDIFileGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        public static class Globals {
            public static String outputText = "";
        }

        private List<String> WholeTextParse(String text)
        {
            List<String> words = new List<String>();
            String currentChar;
            String currentWord = "";
            int length = 0;
            int counter = 0;

            length = text.Length;
            while (counter < length)
            {

                currentChar = text[counter].ToString();
                Console.WriteLine(currentChar);

                if (currentChar == "|" || currentChar == "*")
                {
                    words.Add(currentWord);
                    currentWord = "";
                }
                else if (currentChar == "~" || currentChar == "`")
                {
                    words.Add(currentWord);
                    words.Add("~");
                    currentWord = "";
                    counter += 2;
                }
                else
                {
                    currentWord += currentChar;
                }
                counter++;
            }

            return words;
        }

        private String PutBackTogether(List<String> inputList) {
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

        private void TopEnvelopeFlipper(List<String> inEnvelope) {
            // swaps sender and receiver on ISA and GS
            String temp = inEnvelope[6];
            inEnvelope[6] = inEnvelope[8];
            inEnvelope[8] = temp;
            temp = inEnvelope[20];
            inEnvelope[20] = inEnvelope[21];
            inEnvelope[21] = temp;

            // gets current date and puts in ISA and GS
            String today = DateTime.Now.ToString("yyMMdd");
            inEnvelope[9] = today;
            inEnvelope[22] = "20" + today;

            // gets current time and puts in ISA and GS
            String time = DateTime.Now.ToString("hhmm");
            inEnvelope[10] = time;
            inEnvelope[23] = time;

            // makes the output be an RC
            // HARDCODED for now but will change based on user dropdown input
            inEnvelope[19] = "RC";
            inEnvelope[29] = "861";

            Globals.outputText += PutBackTogether(inEnvelope);
        }

        private void ReceivingAdviceMaker(List<String> segments) {
            int count = 0;
            String asnNum = segments[2];

            // builds the BRA
            Globals.outputText += "BRA*" + asnNum + 
                "*20" + DateTime.Now.ToString("yyMMdd") + "*06*8~\r\n";
            // builds the REF
            Globals.outputText += "REF*SI*" + asnNum + "~\r\n";
            // builds the DTM
            Globals.outputText += "DTM*999" + "*20" + DateTime.Now.ToString("yyMMdd") + "~\r\n";

            //loop through segments list
            // delete everything until you get to a tilde
            // if the next string is not PRF, delete everything until you get to a tilde
            // if it is PRF, grab segments[1] and that is your PO number
            // then delete that PRF and everything until you get to a tilde
            // if the next string is not LIN, keep deleting
            // if it is, exit loop

            int lineCount = 0;
            String tempLIN;
            String tempQty;
            String poNum = "";
            while (segments[0] != "CTT") {
                if (segments[0] == "~")
                {
                    if (segments[1] == "PRF") {
                        poNum = segments[2];
                    }
                    else if (segments[1] == "LIN") {
                        lineCount++;
                        tempLIN = PutBackTogether(segments.GetRange(1, 7));
                        tempQty = segments[9];
                        Globals.outputText += "RCD**" + tempQty + "*ST~\r\n" + tempLIN + "PRF*" + poNum + "~\r\n";
                    }
                    segments.RemoveAt(0);
                }
                else {
                    segments.RemoveAt(0);
                }
            }

            // now segments starts at first LIN and we have the po Num
            
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            //OutputBox.Text = "";
            Globals.outputText = "";
            //InputBox.AppendText("Test");
            String inputText = "";
            String outputText = "";
            List<String> words = new List<String>();
            List<String> envelope = new List<String>();
            int length = 0;
            int counter = 0;
            
            inputText = InputBox.Text;

            //Split all the words based on the value "|" or "*"
            words = WholeTextParse(inputText);
           
            // 32 is the size of the envelope
            for (int i = 0; i < 32; i++) 
            {
                envelope.Add(words[0]);
                words.RemoveAt(0);
            }

            TopEnvelopeFlipper(envelope);

            // now "words" contains everything after the top envelope

            ReceivingAdviceMaker(words);

            OutputBox.Text = Globals.outputText;
        }
    }
}
