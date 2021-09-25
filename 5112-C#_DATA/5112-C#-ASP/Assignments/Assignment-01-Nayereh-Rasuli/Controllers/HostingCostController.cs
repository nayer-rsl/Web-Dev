using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication6.Controllers
{
    public class HostingCostController : ApiController
    {

        public string Get(int id)
        {
            //input is a number
            //output is 3 strings
            //Get api/localhost:9879/HostingCost/0
            //Get api/localhost:9879/HostingCost/14
            //Get api/localhost:9879/HostingCost/15
            //Get api/localhost:9879/HostingCost/21
            //Get api/localhost:9879/HostingCost/28

            //Hst is the ON tax
            //FN is the number of days divided by 14 +1. And it shoud be integer
            //There is 1 fortnight minimum,Cuz with 0 day input the expected response is not $0
            //PriceFN is the fixed price per fortnight
            //Net is the price before tax
            //Tax is the tax on the service
            //Final is the final Cost
            //I have written them seprately and not in 1 equation cuz we need them in the Return
            //Each sens is stored in different strings
            //output is 3 strings

            double HST = 0.13;
            int FN = (id / 14) + 1;
            double PriceFN = 5.5;
            double Net = FN * PriceFN;
            double Tax = HST * Net;
            double Final = Tax + Net;
            string Sen1 = FN + " fortnights at $5.50/FN = $" + Net + " CAD";
            string Sen2 = "\n HST 13% = $" + Tax + " CAD";
            string Sen3 = "\n Total = $" + Final + " CAD";
            return Sen1 + Sen2 + Sen3;

            //I used \n to go to the next line
            //I also tried to show the numbers with 2 decimals.
            //I found the proccess in stackoverFlow. I had to multiply it by 100. but I was not successful.
        }
        
    }
}
