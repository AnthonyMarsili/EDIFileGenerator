using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDIFileGenerator
{
    class StringModifiers
    {
        //Reformats a list of strings into EDI format. Sets new lines based on delimiters in the list
        public static List<String> WholeTextParse(String text)
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

        public static String PutBackTogether(List<String> inputList)
        {
            //Put all the words back together with proper delimiters 
            String output = "";
            int counter = 0;
            int length = inputList.Count;
            while (counter < length)
            {
                if (inputList[1] == "~" || inputList[1] == "`")
                {
                    if (inputList[1] == "~") 
                        output += inputList[0] + "~\r\n";
                    else
                        output += inputList[0] + "`\r\n";

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
    }
}
