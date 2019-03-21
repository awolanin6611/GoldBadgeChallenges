using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge
{
    public class Menu
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public string ListIngredients { get; set; }
        public decimal PriceOfMeal { get; set; }
        public List<Menu> MenuList { get; set; }

       
        public Menu()
        {
            MenuList = new List<Menu>();
        }
        public Menu(int mealNumber, string mealName, string description, string listIngredients, decimal priceOfMeal)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            Description = description;
            ListIngredients = listIngredients;
            PriceOfMeal = priceOfMeal;
            MenuList = new List<Menu>();

        }
       
  
    }
    
}
