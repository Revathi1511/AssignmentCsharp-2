using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssignmentCsharp.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// this is going to take the number of ways to roll a dice
        /// </summary>
        /// <param name="m">side 1</param>
        /// <param name="n">side 2</param>
        /// <returns>10</returns>
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string Get(int m, int n)
        {
            int numOfWays = GetNumOfWays(m, n, 10);

            if (numOfWays == 1)  //this is to get the value 10 in one way
                return $"There is 1 ways to get the sum 10";

            return $"There are {numOfWays} ways to get the sum 10";
        }

        /// <summary>
        /// this is going to take the different ways to roll a dice
        /// </summary>
        /// <param name="m">side 1</param>
        /// <param name="n">side 2</param>
        /// <returns>10</returns>
        private int GetNumOfWays(int dice1Sides, int dice2Sides, int targetValue)
        {
            int waysToRoll = 0;

            for (int i = 1; i <= dice1Sides; i++)  //using for loop to get the possible probablities of the dices roll
            {
                for (int j = 1; j <= dice2Sides; j++)
                {
                    if (i + j == targetValue)
                    {
                        waysToRoll++;
                    }
                }
            }

            return waysToRoll;

        }
    }
}
    

