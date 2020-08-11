using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDIFileGenerator
{
    class Envelope
    {
        //Function to create the top envelope for all document types 
        public static List<String> TopEnvelope(List<String> envelope, String Company, int type)
        {
            List<String> result = new List<String>();
            String sender = "";
            String receiver = "";

            //Set the proper sender and reciever based on which hub is selected
            if (Company == "Makino")
            {
                sender = "MASINGAPOREMEQ";
                receiver = "MAKINOSUPP";
            }
            else if(Company == "Pet Valu")
            {
                sender = "PETVALU";
                receiver = "SPANGELPET";
            }


            //Generate top envelope for RC
            if (type == 856)
            {
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

                for (int i = 0; i < 32; i++)
                {
                    result.Add(envelope[i]);
                }

                // storing values for bottom envelope
                result.Add(envelope[30]); // SE02
                result.Add(envelope[24]); // GE02
                result.Add(envelope[13].TrimStart('0')); // IEA02

                return result;
            }
            //Genereate top envelope for PO
            else if (type == 850)
            {
                //Template for PO
                String[] template = { "ISA", "00", "          ", "00", "          ", "ZZ", "Sender", "ZZ", "Receiver", "000000", "0000", "U", "00401", "000000161", "0", "T", ">", "`",
                                  "GS", "PO", "Sender", "Receiver", "00000000", "0000", "47", "X", "004010", "`",
                                  "ST", "850", "0047", "`",
                                };
                envelope = new List<string>(template);
                // GS Sender and Receiver
                envelope[20] = sender;
                envelope[21] = receiver;

                // ISA Sender and Receiver
                while (receiver.Length < 16)
                {
                    receiver += " ";
                }
                envelope[8] = receiver;

                while (sender.Length < 16)
                {
                    sender += " ";
                }
                envelope[6] = sender;

                // Dates
                String today = DateTime.Now.ToString("yyMMdd");
                envelope[9] = today;
                envelope[22] = "20" + today;

                // Times
                String time = DateTime.Now.ToString("HHmm");
                envelope[10] = time;
                envelope[23] = time;

                if (Company == "Pet Valu")
                {
                    envelope[11] = "|";
                    envelope[16] = ":";
                }

                // reconstruct top envelope
                for (int i = 0; i < 32; i++)
                {
                    result.Add(envelope[i]);
                }

                return result;
            }
            else
            {
                return result;
            }
        }

        //Make this the overloaded funciton for PO's 
        public static List<String> TopEnvelope(String Company, int type)
        {
            List<String> result = new List<String>();

            return result;
        }
    }
}
