using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication6.Controllers
{
    public class GreetingController : ApiController
    {

        //first request is POST
        //output is  a string
        //POST api/localhost:9879/Greeting
        //returns in command prompt

        public string Post()
        {
            return "Hello World!";
        }
        
        //input is a number
        //output is string
        //Get api/localhost:9879/Greeting/3
        //Get api/localhost:9879/Greeting/6
        //Get api/localhost:9879/Greeting/0

        public string Get(int id)
        {
            return "Greetings to " + id + " people!";
        }
    }
}
