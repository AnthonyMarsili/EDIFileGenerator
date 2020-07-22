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
                else if (currentChar == "~")
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

        private void PutBackTogether(List<String> inputList) {
            //Put all the words back together with proper delimiters 
            String output = "";
            int counter = 0;
            int length = inputList.Count;
            while (counter < length)
            {
                if (inputList[1] == "~")
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

            Globals.outputText += output;

        }

        private void TopEnvelopeFlipper(List<String> inEnvelope) {
            String temp = inEnvelope[6];
            inEnvelope[6] = inEnvelope[8];
            inEnvelope[8] = temp;

            temp = inEnvelope[20];
            inEnvelope[20] = inEnvelope[21];
            inEnvelope[21] = temp;

            PutBackTogether(inEnvelope);

            //First 6 segments stay the same
            //for (int i = 0; i < inEnvLen; i++)
            //{
            //    if (i == 6) // these two if statements do the swapping
            //        outEnvelope += reciever;
            //    else if (i == 8)
            //        outEnvelope += sender;
            //    else
            //        outEnvelope += inEnvelope[0];
                
            //    outEnvelope += "*";
            //    inEnvelope.RemoveAt(0);
            //}
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            //InputBox.AppendText("Test");
            String inputText = "";
            String outputText = "";
            List<String> words = new List<String>();
            List<String> envelope = new List<String>();
            int length = 0;
            int counter = 0;
            
            inputText = InputBox.Text;
            length = inputText.Length;

            //Split all the words based on the value "|" or "*"
            words = WholeTextParse(inputText);
           
            //Change word count to be the size of the envelope
            for (int i = 0; i < words.Count; i++) {
                envelope.Add(words[i]);
            }

            TopEnvelopeFlipper(envelope);

            OutputBox.Text = Globals.outputText;
        }
    }
}
