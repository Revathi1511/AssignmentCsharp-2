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
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string Get(int m, int n)
        {
            int numOfWays = GetNumOfWays(m, n, 10);

            if (numOfWays == 1)
                return $"There is 1 ways to get the sum 10";

            return $"There are {numOfWays} ways to get the sum 10";
        }
        private int GetNumOfWays(int dice1Sides, int dice2Sides, int targetValue)
        {
            int waysToRoll = 0;

            for (int i = 1; i <= dice1Sides; i++)
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
    

