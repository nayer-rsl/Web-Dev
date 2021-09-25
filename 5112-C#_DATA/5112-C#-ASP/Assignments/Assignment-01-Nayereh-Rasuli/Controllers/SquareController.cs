using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication6.Controllers
{
    public class SquareController : ApiController
    {

        //input is a number
        //output is the square of the same number
        //Get api/localhost:9879/Square/2
        //Get api/localhost:9879/Square/-2
        //Get api/localhost:9879/Square/10

        public int Get(int id)
        {
            int product = id * id;
            return product;
        }
    }
}
