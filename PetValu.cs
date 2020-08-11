using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDIFileGenerator
{
    class PetValu
    {
        public String POnumber;
        public String currency;
        public int numOfItems;
        public String deliveryDate;
        public int itemNumber = 12345;
        public PetValu(String POnum, String curr, int items, String delivery)
        {
            POnumber = POnum;
            currency = curr;
            numOfItems = items;
            deliveryDate = delivery;
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


            return PO;
        }
    }
}
