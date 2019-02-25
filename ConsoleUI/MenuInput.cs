using System;

namespace Utilities.ConsoleUI
{
    public class MenuInput
    {
        public int selectionItem;

        public bool Selection(int totalMenuItems)
        {
            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.Enter:
                    return false;
                case ConsoleKey.UpArrow:
                    if (selectionItem == 0)
                    {
                        selectionItem = totalMenuItems - 1;
                    } else 
                    { 
                        selectionItem -= 1; 
                    }
                    return true;
                case ConsoleKey.DownArrow:
                    if (selectionItem == totalMenuItems - 1)
                    {
                        selectionItem = 0;
                    }
                    else
                    {
                        selectionItem += 1;
                    }
                    return true;
                default:
                    return Selection(totalMenuItems);
            }
        }
    }
}
