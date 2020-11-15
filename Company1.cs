using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EDIFileGenerator
{
    class Company1
    {
        public String POnumber;
        public String currency;
        public int numOfItems;
        public String deliveryDate;
        public bool tax0needed;
        public bool tax7needed;
        public int itemNumber = 12345;

        //Constructor for generating a PO
        public Company1(String POnum, String curr, int items, DateTime delivery, bool tax0, bool tax7) {
            POnumber = POnum;
            currency = curr;
            numOfItems = items;
            deliveryDate = "20" + delivery.ToString("yyMMdd");
            tax0needed = tax0;
            tax7needed = tax7;
        }
        public Company1() // another constructor than can be used for doing other Company 1 things like conversions
        { 
        }

        //Function to create a Company 1 PO
        public String createCompany1PO() {
            String PO = "";

            //Create the top envelope
            List<String> topEnvelope = new List<string>();
            PO += StringModifiers.PutBackTogether(Envelope.TopEnvelope(topEnvelope, "Company 1", 850));



            //Generate the static portion of the PO
            PO += "BEG|00|SA|";
            PO += POnumber;
            PO += "||20" + DateTime.Now.ToString("yyMMdd") + "||AC`\r\n";
            PO += "CUR|II|";
            PO += currency + "`\r\n";

            PO += "REF|PG|100`\r\nREF|PC|1010`\r\n";
            PO += "REF|BC|1010`\r\nREF|ZZ|PRODUCTION`\r\n";
            PO += "PER|SU|Test Vendor Company|TE|123-123-1234|FX|5874 5896`\r\n";
            PO += "PER|BD|Test User|TE|123456789|||EM|test@testEmail.com|DF|||01|EXW|CI|SINGAPORE`\r\n";
            PO += "ITD|||||||30|||||Within 30 days due net`\r\n";
            PO += "N1|SE|Vendor Factory|92|0000100123`\r\n";
            PO += "N3|123 Test Ave #54321`\r\n";
            PO += "N4|SINGAPORE||12345|SG`\r\n";
            PO += "N1|BT|Company 1|92|1010`\r\n";
            PO += "N3|2 Test Avenue`\r\n";
            PO += "N4|Singapore||123456|SG`\r\n";
            PO += "N1|ST|Company 1|92|1010`\r\n";
            PO += "N3|166 Test Circle`\r\n";
            PO += "N4|Singapore||123456|SG`\r\n";


            //Generate the PO1 loop based on selected tax amounts
            if (tax0needed && tax7needed)
            {
                for (int i = 1; i <= numOfItems; i++)
                {
                    if (i % 2 == 1)
                    {
                        PO += "PO1|" + lineItemGenerator(i) + "|10|ST|100.99||BP|" + itemNumber + "`\r\n";
                        PO += "PID|F||||DemoItem" + i + "`\r\n";
                        PO += "TXI|P4||0|||||||GST on import-MES 0%`\r\n";
                        PO += "SCH|10|EA|POA|POA|017|" + deliveryDate + "||002|" + deliveryDate + "`\r\n";
                        itemNumber++;
                    }
                    else
                    {
                        PO += "PO1|" + lineItemGenerator(i) + "|10|ST|100.99||BP|" + itemNumber + "`\r\n";
                        PO += "PID|F||||DemoItem" + i + "`\r\n";
                        PO += "TXI|P1||7|||||||Standard - rated 7 %`\r\n";
                        PO += "SCH|10|EA|POA|POA|017|" + deliveryDate + "||002|" + deliveryDate + "`\r\n";
                        itemNumber++;
                    }
                }
            }
            else if (tax7needed)
            {
                for (int i = 1; i <= numOfItems; i++)
                {
                    PO += "PO1|" + lineItemGenerator(i) + "|10|ST|100.99||BP|" + itemNumber + "`\r\n";
                    PO += "PID|F||||DemoItem" + i + "`\r\n";
                    PO += "TXI|P1||7|||||||Standard - rated 7 %`\r\n";
                    PO += "SCH|10|EA|POA|POA|017|" + deliveryDate + "||002|" + deliveryDate + "`\r\n";
                    itemNumber++;
                }
            }
            else if (tax0needed)
            {
                for (int i = 1; i <= numOfItems; i++)
                {
                    PO += "PID|F||||DemoItem" + i + "`\r\n";
                    PO += "TXI|P4||0|||||||GST on import-MES 0%`\r\n";
                    PO += "SCH|10|EA|POA|POA|017|" + deliveryDate + "||002|" + deliveryDate + "`\r\n";
                    itemNumber++;
                }
            }
            else
            {
                for (int i = 1; i <= numOfItems; i++)
                {
                    PO += "PO1|" + lineItemGenerator(i) + "|10|ST|100.99||BP|" + itemNumber + "`\r\n";
                    PO += "PID|F||||DemoItem" + i + "`\r\n";
                    PO += "SCH|10|EA|POA|POA|017|" + deliveryDate + "||002|" + deliveryDate + "`\r\n";
                    itemNumber++;
                }
            }

            PO += "CTT|" + numOfItems.ToString() + "|" + (numOfItems * 10).ToString() + "`\r\n";
            PO += "SE|38|0047`\r\n";
            PO += "GE|1|47`\r\n";
            PO += "IEA|1|161`";

            return PO;
        }

        //Function to generate line numbers 
        public String lineItemGenerator(int num)
        {
            String line = num + "0";
            while (line.Length < 5)
            {
                line = "0" + line;
            }
            return line;
        }
    }
}
