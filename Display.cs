using System;

namespace Utilities.ConsoleUI
{
    public class Display
    {
        private string title;
        private string subtitle;
        private string selectionIndicator = GlobalVariables.SelectionIndicator;

        private int screenWidth;
        private int screenHeight;
        private int halfRows;

        private int rowLength = GlobalVariables.rowLength;
        private ConsoleColor highlightColor = GlobalVariables.highlightColor;
        private ConsoleColor textColor = GlobalVariables.textColor;
        private ConsoleColor borderColor = GlobalVariables.borderColor;
        private ConsoleColor titleHighlightColor = GlobalVariables.titleHighlightColor;

        public Display(string title, int rows)
        {
            screenWidth = Console.WindowWidth;
            screenHeight = Console.WindowHeight;
            this.title = title;
            halfRows = (rows + 1) / 2;
        }

        public void MenuList(string subtitle)
        {
            this.subtitle = subtitle;

            Console.CursorVisible = false;
            Console.Clear();
            PrintBorder();
            PrintSubtitle();
            PrintTitle();
        }

        public string Question(string question, string subtitle)
        {
            this.subtitle = subtitle;

            Console.Clear();
            Console.CursorVisible = false;
            PrintBorder();
            PrintTitle();
            PrintSubtitle();
            PrintSingleLine(question);

            Console.CursorVisible = true;
            return Console.ReadLine();
        }

        public void SingleLine(string firstLine, string subtitle)
        {
            this.subtitle = subtitle;

            Console.CursorVisible = false;
            PrintSubtitle();
            PrintSingleLine(firstLine);
            Console.ReadLine();
        }

        public void DoubleLine(string firstLine, string secondLine, string subtitle)
        {
            this.subtitle = subtitle;

            Console.CursorVisible = false;
            PrintSubtitle();
            PrintDoubleLine(firstLine, secondLine);
            Console.ReadLine();
        }

        public void PrintMenuItem(string itemName, bool isCurrentlySelected)
        {
            if (isCurrentlySelected)
            {
                Console.BackgroundColor = highlightColor;
                Console.ForegroundColor = textColor;
                Console.Write(selectionIndicator);
                Console.Write(itemName);
                PrintEmptySpaceFill(rowLength - (itemName.Length + selectionIndicator.Length));
                Console.ResetColor();
            }
            else
            {
                Console.Write(" ");
                Console.Write(itemName);
                PrintEmptySpaceFill(rowLength - itemName.Length);
            }
        }

        private void PrintBorder()
        {
            Console.ForegroundColor = borderColor;

            //Top Border
            Console.SetCursorPosition(screenWidth / 2 - rowLength / 2, screenHeight / 2 - halfRows - 1);
            PrintBorderedSpaceFill("-");
            //Bottom Border
            Console.SetCursorPosition(screenWidth / 2 - rowLength / 2, screenHeight / 2 + halfRows + 1);
            PrintBorderedSpaceFill("-");

            Console.ResetColor();
        }

        private void PrintEmptySpaceFill(int emptySpace)
        {
            for (int i = 0; i < emptySpace; i++)
            {
                Console.Write(" ");
            }
        }

        private void PrintBorderedSpaceFill(string borderType)
        {
            for (int i = 0; i < rowLength; i++)
            {
                Console.Write(borderType);
            }
        }

        private void PrintTitle()
        {
            Console.SetCursorPosition(screenWidth / 2 - rowLength / 2, screenHeight / 2 - halfRows);
            Console.BackgroundColor = titleHighlightColor;
            Console.ForegroundColor = textColor;
            //variable to control the centering if the title is an odd number of characters
            var leftAlignCenter = (rowLength / 2) - (title.Length / 2);
            PrintEmptySpaceFill(leftAlignCenter);
            Console.Write(title);
            PrintEmptySpaceFill(rowLength - leftAlignCenter - title.Length);
            Console.ResetColor();
        }

        private void PrintSubtitle()
        {
            Console.SetCursorPosition(screenWidth / 2 - rowLength / 2, screenHeight / 2 - halfRows + 1);
            Console.ForegroundColor = titleHighlightColor;
            var leftAlignCenter = (rowLength / 2) - (subtitle.Length / 2);
            PrintEmptySpaceFill(leftAlignCenter);
            Console.Write(subtitle);
            PrintEmptySpaceFill(rowLength - leftAlignCenter - subtitle.Length);
            Console.ResetColor();
        }

        private void PrintSingleLine(string message)
        {
            //clear lines
            Console.SetCursorPosition(screenWidth / 2 - rowLength / 2, screenHeight / 2 - halfRows + 3);
            PrintEmptySpaceFill(rowLength);
            Console.SetCursorPosition(screenWidth / 2 - rowLength / 2, screenHeight / 2 - halfRows + 4);
            PrintEmptySpaceFill(rowLength);

            Console.SetCursorPosition(screenWidth / 2 - rowLength / 2, screenHeight / 2 - halfRows + 3);
            Console.Write(message);
        }

        private void PrintDoubleLine(string firstLine, string secondLine)
        {
            PrintSingleLine(firstLine);

            Console.SetCursorPosition(screenWidth / 2 - rowLength / 2, screenHeight / 2 - halfRows + 4);
            Console.Write(secondLine);
        }
    }
}
