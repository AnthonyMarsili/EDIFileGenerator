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
        public DateTime deliveryDate;
        public bool headerAllowance;
        public bool headerCharge;
        public String[] headerSACvalues = new String[3];
        public bool ITDneeded;
        public String ITDpercent;
        public int itemNumber = 12345;

        //constructor for creating a Pet Valu PO
        public PetValu(String POnum, String curr, int items, DateTime delivery, bool PVheaderAllowance, 
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
            int productID = 111111111;

            //Blank top envelope for function parameter. If can overload funciton please fix this
            List<String> topEnvelope = new List<string>();
            PO += StringModifiers.PutBackTogether(Envelope.TopEnvelope(topEnvelope, "Pet Valu", 850));

            PO += "BEG*00*SA*";
            PO += POnumber;
            PO += "**20" + DateTime.Now.ToString("yyMMdd") + "~\r\n";
            PO += "CUR*BY*USD~\r\n";
            PO += "REF*IA*ANGE01~\r\n";
            PO += "REF*19*Pet Valu~\r\n";
            PO += "REF*11*4458809~\r\n";
            PO += "PER*BD*John Doe*TE*555-555-5555*EM*test@test.com~\r\n";
            PO += "PER*DC*Tom Doe*TE*555-555-5555*EM*test@test.com~\r\n";
            PO += "PER*SU*Test Supplier*TE*555-555-5555*EM*test@test.com~\r\n";

            if (headerSACvalues[0] != "false")
            {
                if (headerAllowance) // these need to be radio buttons
                {
                    PO += "SAC*A*";
                }
                else if (headerCharge)
                {
                    PO += "SAC*C*";
                }

                // headerSACvalues: [code, amount, percentage] -- the one that doesn't exitst between amt and per will be -1
                // unless the user doesnt wants a header SAC: [false, null, null]

                if(headerSACvalues[0] == "none") 
                {
                    PO = "Please enter values in all required SAC fields.";
                    return PO;
                }
                else
                    PO += headerSACvalues[0].Substring(0, 4) + "***"; // the allowance/charge code

                if (headerSACvalues[2] == "-1")  // they want an amount
                {
                    int decimalLocation = headerSACvalues[1].Length - 3;
                    headerSACvalues[1] = headerSACvalues[1].Remove(decimalLocation, 1);
                    PO += headerSACvalues[1] + "*3**";
                }
                else if (headerSACvalues[1] == "-1") // they want a percent
                    PO += "*3*" + headerSACvalues[2];
                else
                {
                    PO = "Please enter values in all required SAC fields.";
                    return PO;
                }

                PO += "********Discount\r\n";
            }

            if (ITDneeded)
            {
                PO += "ITD*08*15*" + ITDpercent + "**10**30*****Sample Discount~\r\n";
            }

            PO += "DTM*002*20" + deliveryDate.ToString("yyMMdd") + "~\r\n";
            PO += "DTM*010*20" + deliveryDate.AddDays(-2).ToString("yyMMdd") + "~\r\n";
            PO += "DTM*118*20" + deliveryDate.ToString("yyMMdd") + "~\r\n";

            PO += "TD5*****UPS~\r\n";
            PO += "TXI*GS*2~\r\n";
            PO += "N9*L1*GEN~\r\n";
            PO += "MTX**Test Note.~\r\n";
            PO += "N1*ST*Pet Retail Brands*92*94~\r\n";
            PO += "N2*Pet Retail Brands Testing~\r\n";
            PO += "N3*3501 BURRIS ROAD*Suite 1000~\r\n";
            PO += "N3*1st Floor*Last door on the right~\r\n";
            PO += "N4*DAVIE*FL*33314*US~\r\n";
            PO += "N1*VN*Test Vendor Name*92*1234~\r\n";
            PO += "N2*Test Supplier Name~\r\n";
            PO += "N3*123 Test Street*Address2~\r\n";
            PO += "N3*Address 3*Address 4~\r\n";
            PO += "N4*Omaha*NE*68007*US~\r\n";

            for (int i = 1; i <= numOfItems; i++)
            {
                PO += "PO1*" + i + "*5*EA" + i + ".99**BP*BPN" + i + i + i + "*VN*VPN" + i + i + i + "*UP*" + productID++ + "~\r\n";
                PO += "CTP********" + (i * (i + 0.99)) + "~\r\n";
                PO += "PID*F*08***Test Item Description " + i + "~\r\n";
                PO += "PO4*5****G*2*LB*2*IN~\r\n";
       
            }

            PO += "CTT*" + numOfItems + "~\r\n";

            PO += "SE|38|0047~\r\n";
            PO += "GE|1|47~\r\n";
            PO += "IEA|1|161~";


            return PO;
        }
    }
}
