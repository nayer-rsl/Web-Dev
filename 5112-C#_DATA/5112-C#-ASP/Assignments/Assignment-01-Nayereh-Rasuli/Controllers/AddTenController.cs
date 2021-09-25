using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication6.Controllers
{
    public class AddTenController : ApiController
    {
        //input is a number
        //output is the same number plus 10
        //Get api/localhost:9879/AddTen/21
        //Get api/localhost:9879/AddTen/0
        //Get api/localhost:9879/AddTen/-9

        public int Get(int id)
        {
            int product = id + 10;
            return product;
        }
    }
}
