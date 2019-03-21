using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge
{
    public class MenuRepository
    {
        private List<Menu> _menuItems = new List<Menu>();
        //private List<Menu> menuList;

       // public MenuRepository(List<Menu> menuList)
        //{
       //     this.menuList = menuList;
       //}

        public void AddMenuItemsToList(Menu menuItem)
        {
            _menuItems.Add(menuItem);
        }
        public List<Menu> GetMenuList()
        {
            return _menuItems;
        }
        public void RemoveItemsFromMenu(Menu menu)
        {
            _menuItems.Remove(menu);
        }
        public bool RemoveItemsFromMenu(int mealNumber)
        {
            bool success = false;
            foreach(Menu menu in _menuItems)
            {
                if(menu.MealNumber == mealNumber)
                {
                    RemoveItemsFromMenu(menu);
                    success = true;
                    break;
                }
               
            }
            return success;
        }


    }
}
