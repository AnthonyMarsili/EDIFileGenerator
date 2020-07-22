using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private String TopEnvelopeFlipper(List<String> inEnvelope) {
            String outEnvelope = "";
            String sender = inEnvelope[6];
            String reciever = inEnvelope[8];
            int inEnvLen = inEnvelope.Count; // this line helps with swapping

            //First 6 segments stay the same
            for (int i = 0; i < inEnvLen; i++)
            {
                if (i == 6) // these two if statements do the swapping
                    outEnvelope += reciever;
                else if (i == 8)
                    outEnvelope += sender;
                else
                    outEnvelope += inEnvelope[0];
                
                outEnvelope += "*";
                inEnvelope.RemoveAt(0);
            }

            //outEnvelope = inEnvelope[0]; not sure what this did so i commented it out
            return outEnvelope;
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
           
            for (int i = 0; i < words.Count; i++) {
                envelope.Add(words[i]);
            }

            outputText = TopEnvelopeFlipper(envelope);



            //Put all the words back together
            counter = 0;
            length = words.Count;
            while (counter < length) {
                if (words[1] == "~")
                {
                    outputText += words[0] + "~\r\n";
                    words.RemoveAt(0);
                    words.RemoveAt(0);
                    counter++;
                    counter++;
                }
                else {
                    outputText += words[0];
                    outputText += "*";
                    words.RemoveAt(0);
                    counter++;
                }
                
            }

            OutputBox.Text = outputText;
        }
    }
}
