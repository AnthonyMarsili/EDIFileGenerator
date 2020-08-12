using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDIFileGenerator
{
    class PetValu
    {
        public String POnumber;
        public String currency;
        public int numOfItems;
        public String deliveryDate;
        public bool headerAllowance;
        public bool headerCharge;
        public String[] headerSACvalues = new String[3];
        public bool ITDneeded;
        public String ITDpercent;
        public int itemNumber = 12345;

        //constructor for creating a Pet Valu PO
        public PetValu(String POnum, String curr, int items, String delivery, bool PVheaderAllowance, 
            bool PVheaderCharge, String[] headerSACvals, bool PVITDneeded, String PVITDpercent)
        {
            POnumber = POnum;
            currency = curr;
            numOfItems = items;
            deliveryDate = delivery;
            headerAllowance = PVheaderAllowance;
            headerCharge = PVheaderCharge;
            headerSACvalues = headerSACvals;
            ITDneeded = PVITDneeded;
            ITDpercent = PVITDpercent;
        }

        //constructor for doing other things with PetValu
        public PetValu() { 
        
        }

        public String CreatePetValuPO()
        {
            String PO = "";

            //Blank top envelope for function parameter. If can overload funciton please fix this
            List<String> topEnvelope = new List<string>();
            PO += StringModifiers.PutBackTogether(Envelope.TopEnvelope(topEnvelope, "Pet Valu", 850));

            PO += "BEG*00*SA*";
            PO += POnumber;
            PO += "**20" + DateTime.Now.ToString("yyMMdd") + "~\r\n";
            PO += "CUR* BY*USD~\r\n";
            PO += "REF* IA*ANGE01~\r\n";
            PO += "REF * 19 * Pet Valu~\r\n";
            PO += "REF * 11 * 4458809~\r\n";
            PO += "PER * BD * John Doe* TE*555 - 555 - 5555 * EM * test@test.com~\r\n";
            PO += "PER * DC * Tom Doe* TE*555 - 555 - 5555 * EM * test@test.com~\r\n";
            PO += "PER * SU * Test Supplier* TE*555 - 555 - 5555 * EM * test@test.com~\r\n";


            if (headerAllowance) // these need to be radio buttons
            {
                PO += "A*";
            }
            else if (headerCharge) {
                PO += "C*";
            }

            // headerSACvalues: [code, amount, percentage] -- the one that doesn't exitst between amt and per will be -1
            
            PO += headerSACvalues[0] + "***"; // the allowance/charge code
            
            if (headerSACvalues[1] != "-1") {
                PO += headerSACvalues[1] + "~\r\n";
            }
            else 
                PO += "3*" + headerSACvalues[2] + "~\r\n";

            if (ITDneeded)
            {
                PO += "ITD*08*15*" + ITDpercent + "**10**30*****Sample Discount~\r\n";
            }

            return PO;
        }
    }
}
