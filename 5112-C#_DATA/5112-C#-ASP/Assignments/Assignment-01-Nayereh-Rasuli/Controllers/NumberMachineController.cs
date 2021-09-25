using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication6.Controllers
{
    public class NumberMachineController : ApiController
    {

        //input is a number
        //output is a number
        //output is the given number after going through 4 mathematical operations
        //Get api/localhost:9879/NumberMachine/10
        //Get api/localhost:9879/NumberMachine/-5
        //Get api/localhost:9879/NumberMachine/30

        public int Get(int id)
        {
            int product = (id * id) + id - (id / id);
            return product;
        }
    }
}
