using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01_Challenge
{

    public class ProgramUI
    {
        private Menu _menu;
        private MenuRepository _menuRepo;

        public ProgramUI()
        {
            _menu = new Menu();
            //_menuRepo = new MenuRepository(_menu.MenuList);
        }

        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Press the Number of what you would like to do:\n" +
                    "1. Create New Menu Item.\n" +
                    "2. View Items Created.\n" +
                    "3. Remove Item From List.\n" +
                    "4. Exit Application.");

                string inputAsString = Console.ReadLine();
                int input = int.Parse(inputAsString);

                switch (input)
                {
                    case 1:
                        CreateNewMenuItem();
                        break;
                    case 2:
                        ViewItemsCreated();
                        break;
                    case 3:
                        RemoveItemFromList();
                        break;
                    case 4:
                        running = false;
                        break;

                }

              
            }
        }

        private void CreateNewMenuItem()
        {
            Console.WriteLine("Enter The Name of your Item:" );
            string mealName = Console.ReadLine();

            Console.WriteLine("Enter the Number you would Like to Use:");
                int mealNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the description of your Item:");
            string description = Console.ReadLine();

            Console.WriteLine("Enter the Ingredients of the Item:");
            string listIngredients = Console.ReadLine();

            Console.WriteLine("What would you like the Price of the Item to be:");
            decimal priceOfMeal = decimal.Parse(Console.ReadLine());

            Menu menuToList = new Menu(mealNumber, mealName, description,listIngredients,priceOfMeal);

            _menuRepo.AddMenuItemsToList(menuToList);
        }
        private void ViewItemsCreated()
        {
            List<Menu> menu = _menuRepo.GetMenuList();

            foreach(Menu menuItem in menu)
            {
                Console.WriteLine($"Mealname:{menuItem.MealName} {menuItem.MealNumber} {menuItem.Description} {menuItem.ListIngredients} {menuItem.PriceOfMeal}");
            }
                Console.ReadLine();
        }
        private void RemoveItemFromList()
        {
            ViewItemsCreated();

            Console.WriteLine("What Combo would you like to remove.");
            int number = int.Parse(Console.ReadLine());

            bool success = _menuRepo.RemoveItemsFromMenu(number);
            if (success == true)
            {
                Console.WriteLine($"Combo {number} was successfully removed.\n" +
                    $"Press any key to continue:");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Combo {number} was not successfully removed.");
                Console.ReadKey();
                Console.Clear();
            }
        }
        
    }
}

