namespace Utilities.ConsoleUI
{
    public class Validator
    {
        public bool PositiveNumber(double input)
        {
            return input > 0;
        }

        public bool GreaterThanOrEqualToZero(double input)
        {
            return input >= 0;
        }
    }
}
