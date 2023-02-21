using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssignmentCsharp.Controllers
{
    public class J1Controller : ApiController
    {
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)

        {
           
            int totalCalories = 0;

            totalCalories += GetBurgerCalorie(burger);
            totalCalories += GetDrinkCalories(drink);
            totalCalories += GetSideCalories(side);
            totalCalories += GetDessertCalories(dessert);


            return $"Your total calorie count is {totalCalories}";
        }
        private int GetBurgerCalorie(int burger)
        {
            if (burger == 1) //Cheese Burger
                return 461; //461 Calories
            else if (burger == 2)//Fish Burger
                return 431; //431 Calories
            else if (burger == 3) //Veggie Burger
                return 420; //420 Calories
            else
                return 0;
        }
        private int GetDrinkCalories(int drink)
        {
            if (drink == 1) //Soft Drink
                return 130; //130 Calories
            else if (drink == 2)// Orange Juice
                return 160; //160 Calories
            else if (drink == 3) //Milk
                return 118; // 118 Calories
            else
                return 0;
        }
        private int GetSideCalories(int side)
        {

            if (side == 1) //Fries
                return 100; //100 Calories
            else if (side == 2) //Baked Potato
                return 57; // 57 Calories
            else if (side == 3) //Chef Salad
                return 70; // 70 Calories
            else
                return 0;
        }
        private int GetDessertCalories(int dessert)
        {
            if (dessert == 1) //Apple Pie
                return 167; // 167 Calories
            else if (dessert == 2)  //Sundae
                return 266; //266 Calories
            else if (dessert == 3) // Fruit Cup
                return 75; //75 Calories
            else
                return 0;
        }
    }
}
