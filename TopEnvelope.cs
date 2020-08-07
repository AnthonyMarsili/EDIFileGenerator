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
        public static List<String> TopEnvelope(List<String> envelope, String Company, int type) {
            List<String> result = new List<String>();
            String sender = "";
            String receiver = "";
            if (Company == "Makino")
            {
                sender = "MASINGAPOREMEQ";
                receiver = "MAKINOSUPP     ";
            }

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
            else if (type == 850)
            {
                envelope[6] = sender;
                while (receiver.Length < 16)
                {
                    receiver += " ";
                }
                envelope[8] = receiver;
                envelope[20] = sender;
                envelope[21] = receiver;

                String today = DateTime.Now.ToString("yyMMdd");
                envelope[9] = today;
                envelope[22] = "20" + today;

                String time = DateTime.Now.ToString("HHmm");
                envelope[10] = time;
                envelope[23] = time;

                for (int i = 0; i < 32; i++)
                {
                    result.Add(envelope[i]);
                }

                return result;
            }
        }
}
}
