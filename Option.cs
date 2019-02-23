using System;

namespace Utilities.ConsoleUI
{
    public class Option : IMenuItem
    {
        private string title;

        public Option(string title)
        {
            this.title = title;
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public string Title()
        {
            return title;
        }
    }
}
