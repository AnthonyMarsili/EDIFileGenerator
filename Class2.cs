using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDIFileGenerator
{
    class StringModifiers
    {
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
    }
}
