using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="m">positive integer representing the number of sides on the first die</param>
        /// <param name="n">positive integer representing the number of sides on the second die</param>
        /// <example>
        /// GET: api/J2/DiceGame/6/8
        ///</example>
        /// <returns>There are 5 total ways to get the sum 10.</returns>
        ///<example>
        /// GET: api/J2/DiceGame/12/4
        ///</example>
        /// <returns>There are 4 ways to get the sum 10.</returns>
        /// ///<example>
        /// GET: api/J2/DiceGame/3/3
        ///</example>
        /// <returns>There are 0 ways to get the sum 10.</returns>
        //GET: api/j2/DiceGame
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            int total = 0;
            int sum = 10;
            for (int i = 1; i < Math.Min(sum, m + 1); ++i)
            {
                for (int j = 1; j < Math.Min(sum, n + 1); ++j)
                {
                    ///if (i + j == sum)
                    ///{
                    ///    ++total;
                    ///}
                    total += i + j == sum ? 1 : 0;
                }
            }

            string message = "There are " + total.ToString() + " ways to get the sum " + sum.ToString();
            return message;

        }
    }
}
