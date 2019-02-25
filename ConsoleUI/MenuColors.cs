using System;

namespace Utilities.ConsoleUI
{
    public enum ColorPreset
    {
        Cyberpunk,
        Sprite,
        Monochrome,
        Patriotic,
    }

    public class MenuColors
    {
        public ConsoleColor Hightlight { get; private set;}
        public ConsoleColor Text { get; private set;}
        public ConsoleColor Border { get; private set;}
        public ConsoleColor TitleHighlight { get; private set;}

        public MenuColors(ColorPreset preset)
        {
            switch(preset)
            {
                case ColorPreset.Cyberpunk:
                    Hightlight = ConsoleColor.Cyan;
                    Text = ConsoleColor.Black;
                    Border = ConsoleColor.DarkCyan;
                    TitleHighlight = ConsoleColor.DarkMagenta;
                break;
                case ColorPreset.Sprite:
                    Hightlight = ConsoleColor.Green;
                    Text = ConsoleColor.Black;
                    Border = ConsoleColor.DarkGreen;
                    TitleHighlight = ConsoleColor.DarkYellow;
                break;
                case ColorPreset.Monochrome:
                    Hightlight = ConsoleColor.Gray;
                    Text = ConsoleColor.Black;
                    Border = ConsoleColor.DarkGray;
                    TitleHighlight = ConsoleColor.DarkGray;
                break;
                case ColorPreset.Patriotic:
                    Hightlight = ConsoleColor.Red;
                    Text = ConsoleColor.White;
                    Border = ConsoleColor.DarkBlue;
                    TitleHighlight = ConsoleColor.Blue;
                    break;

            }
        }
    }
}