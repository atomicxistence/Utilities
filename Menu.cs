using System;
using System.Collections.Generic;

namespace Utilities.ConsoleUI
{
    public class Menu
    {
        private int totalRows;

        private string title;
        private List<IMenuItem> menuItems = new List<IMenuItem>();
        private MenuInput input = new MenuInput();

        private readonly string subtitle = "USE ARROWS KEYS TO NAVIGATE | PRESS ENTER TO SELECT";
        private readonly int rowLength = GlobalVariables.rowLength;
        private readonly int defaultRows = 3;

        public Menu(List<IMenuItem> menuItems, string menuTitle)
        {
            this.menuItems = menuItems;
            title = menuTitle;
        }

        public void Display()
        {
            totalRows = menuItems.Count + defaultRows;
            var display = new Display(title, totalRows);
            display.MenuList(subtitle);
            PrintMenuItems(display); 
        }

        public bool Selecting()
        {
            return input.Selection(menuItems.Count);
        }

        public int CurrentSelection()
        {
            return input.selectionItem;
        }

        private void PrintMenuItems(Display display)
        {
            for (int i = 0; i < menuItems.Count; i++)
            {
                var yOffset = i + defaultRows;
                Console.SetCursorPosition(Console.WindowWidth / 2 - rowLength / 2, Console.WindowHeight / 2 - totalRows / 2 + yOffset);
                display.PrintMenuItem(menuItems[i].Title(), i == input.selectionItem);
            }
        }
    }
}
