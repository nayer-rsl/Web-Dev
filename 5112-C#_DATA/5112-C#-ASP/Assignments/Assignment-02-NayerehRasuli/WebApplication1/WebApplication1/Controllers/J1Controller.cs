using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class J1Controller : ApiController
	{
		/// <summary>
		/// Inputs the number choice of burger, drink, side, dessert and outputs a message along with the calorie of the meal
		/// </summary>
		/// <param name="burger">Integer representing the index burger choice(1 - 4)</param>
		/// <param name="drink">Integer representing the index drink choice(1 - 4)</param>
		/// <param name="side">Integer representing the index side choice(1 - 4)</param>
		/// <param name="dessert">Integer representing the index dessert choice (1 - 4)</param>
		///<example>
		///GET: api/J1/Menue/4/4/4/4
		///</example>
		/// <returns>Your total calorie count is 0</returns>
		///<example>
		///GET: api/J1/Menue/1/2/3/4
		///</example>
		/// <returns>Your total calorie count is 691</returns>
		//GET: api/j1/Menu
		[HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]

        public string Menu(int burger, int drink, int side, int dessert)
        {
			int calorie = 0;

			if (burger == 1)
			{
				calorie += 461;
			}
			else if(burger == 2)
			{
				calorie += 431;
			}
			else if(burger == 3)
			{
				calorie += 420;
			}
			else if (burger == 4)
			{
				calorie = 0;
			}

			if (drink == 1)
			{
				calorie += 130;
			}
			else if (drink == 2)
			{
				calorie += 160;
			}
			else if (drink == 3)
			{
				calorie += 118;
			}
			else if (drink == 4)
			{
				calorie += 0;
			}

			if (side == 1)
			{
				calorie += 100;
			}
			else if (side == 2)
			{
				calorie += 57;
			}
			else if (side == 3)
			{
				calorie += 70;
			}
			else if (side == 4)
			{
				calorie += 0;
			}


			if (dessert == 1)
			{
				calorie += 167;
			}
			else if (dessert == 2)
			{
				calorie += 266;
			}
			else if (dessert == 3)
			{
				calorie += 75;
			}
			else if (dessert == 4)
			{
				calorie += 0;
			}

			string message = "your total calorie count is " + calorie;
			return message;
			
		}
    }
}
