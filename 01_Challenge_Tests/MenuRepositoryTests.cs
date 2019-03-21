using System;
using _01_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Challenge_Tests
{
    [TestClass]
    public class MenuRepositoryTests
    {
       
        [TestMethod]
        public void AddItemsToMenu_ShouldBeCorrect()
        {
            MenuRepository _menuRepo = new MenuRepository();
            Menu item = new Menu();
            Menu itemOne = new Menu();
            Menu itemTwo = new Menu();

            _menuRepo.AddMenuItemsToList(item);
            _menuRepo.AddMenuItemsToList(itemOne);
            _menuRepo.AddMenuItemsToList(itemTwo);


            int actual = _menuRepo.GetMenuList().Count;
            int expected = 3;

            Assert.AreEqual(expected, actual);
        
        }

        [TestMethod]
        public void RemoveMenuItemFromList_ShouldBeCorrect()
        {
            MenuRepository _menuRepo = new MenuRepository();
            Menu item = new Menu();
            Menu itemOne = new Menu();
            Menu itemTwo = new Menu();

            _menuRepo.AddMenuItemsToList(item);
            _menuRepo.AddMenuItemsToList(itemOne);
            _menuRepo.AddMenuItemsToList(itemTwo);

            _menuRepo.RemoveItemsFromMenu(item);


            int actual = _menuRepo.GetMenuList().Count;
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }
    }
}
