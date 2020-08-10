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
            int length = text.Length;
            int counter = 0;

            //While loop to check each character and build a list of strings
            while (counter < length)
            {
                //Take next character from string
                currentChar = text[counter].ToString();

                //If you reach a segment delimeter save the current word to the list and reset your current word
                if (currentChar == "|" || currentChar == "*")
                {
                    words.Add(currentWord);
                    currentWord = "";
                }
                //If you reach and end of line delimiter add it to the list and skip the appropriate following characters
                else if (currentChar == "~" || currentChar == "`")
                {
                    words.Add(currentWord);
                    if (currentChar == "~")
                        words.Add("~");
                    else
                        words.Add("`");
                    currentWord = "";
                    counter += 2;
                }
                else if (currentChar == "\r")
                {
                    counter++;
                }
                //Add your current character to the current word
                else
                {
                    currentWord += currentChar;
                }
                //Increment to next character
                counter++;
            }

            return words;
        }

        //Function to take a list of stirngs and revert them to a contious string for output
        public static String PutBackTogether(List<String> inputList)
        {
            //Put all the words back together with proper delimiters 
            String output = "";
            int counter = 0;
            int length = inputList.Count;
            
            //Loop through the entierty of the list
            while (counter < length)
            {

                //If you reach an end of line delimiter as the second in the string add the word and the delimiter to the string
                //as well as the appropriate carriage return characters
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
                //Add the string from the list to the output string as well as a segment delimiter. 
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
