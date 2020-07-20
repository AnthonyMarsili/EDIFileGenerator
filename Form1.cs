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

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            //InputBox.AppendText("Test");
            String inputText = "";
            String outputText = "";
            List<String> words = new List<String>();
            String currentChar;
            String currentWord = "";
            int counter = 0;

            inputText = InputBox.Text;

            currentChar = inputText[counter].ToString();
            
            //Split all the words based on the value "|"
            while (currentChar != "\n") {
                if (currentChar != "|") {
                    currentWord += currentChar;
                }
                else {
                    words.Add(currentWord);
                    currentWord = "";
                }
                counter++;
                currentChar = inputText[counter].ToString();
            }
            
            //Put all the words back together
            while (words.Count > 0) {
                outputText += words[0];
                outputText += "*";
            }

            OutputBox.Text = outputText;
        }
    }
}
