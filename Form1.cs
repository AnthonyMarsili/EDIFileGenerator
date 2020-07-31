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
                else if (currentChar == "\r")
                {
                    counter++;
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

        private void Engine(List<String> words) {
            List<String> envelope = new List<String>();
            List<String> bottomEnvVals;
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
                bottomEnvVals = topEnvelopeMaker(envelope);

                SE01 = ReceivingAdviceMaker(words);

                bottomEnvVals.Insert(0, SE01.ToString());

                bottomEnvelopeMaker(bottomEnvVals);
            }
        }

        private List<String> topEnvelopeMaker(List<String> envelope) {
            List<String> bottomEnvVals = new List<String>();

            // swaps sender and receiver on ISA and GS
            String temp = envelope[6];
            envelope[6] = envelope[8];
            envelope[8] = temp;
            temp = envelope[20];
            envelope[20] = envelope[21];
            envelope[21] = temp;

            // gets current date and puts in ISA and GS
            String today = DateTime.Now.ToString("yyMMdd");
            envelope[9] = today;
            envelope[22] = "20" + today;

            // gets current time and puts in ISA and GS
            String time = DateTime.Now.ToString("HHmm");
            envelope[10] = time;
            envelope[23] = time;

            // makes the output be an RC
            // HARDCODED for now but will change based on user dropdown input
            envelope[19] = "RC";
            envelope[29] = "861";

            // storing values for bottom envelope
            bottomEnvVals.Add(envelope[30]); // SE02
            bottomEnvVals.Add(envelope[24]); // GE02
            bottomEnvVals.Add(envelope[13].TrimStart('0')); // IEA02

            Globals.outputText += PutBackTogether(envelope);

            return bottomEnvVals;
        }

        private void bottomEnvelopeMaker(List<String> bottomEnvVals) {
            Globals.outputText += "SE*" + bottomEnvVals[0] + "*" + bottomEnvVals[1] + "~\r\n";
            Globals.outputText += "GE*1*" + bottomEnvVals[2] + "~\r\n";
            Globals.outputText += "IEA*1*" + bottomEnvVals[3] + "~\r\n";
        }
        
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
            while (segments[0] != "CTT") {
                if (segments[0] == "~")
                {
                    if (segments[1] == "PRF") {
                        poNum = segments[2];
                    }
                    else if (segments[1] == "LIN") {
                        lineCount++;
                        tempLIN = PutBackTogether(segments.GetRange(1, 7));
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

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            List<String> words;
            Globals.outputText = "";

            //Split all the words based on the value "|" or "*"
            words = WholeTextParse(InputBox.Text);

            Engine(words);

            OutputBox.Text = Globals.outputText;

            

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            InputBox.Text = "";
            OutputBox.Text = "";
        }
    }

}
