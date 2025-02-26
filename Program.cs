using _2025_02_24_Method_Overloading.Converters;
using _2025_02_24_Method_Overloading.Utils;

namespace _2025_02_24_Method_Overloading;

partial class Program
{
    /* ---------------------------------- Main ---------------------------------- */
    static void Main()
    {
        Console.WriteLine("Hello, user!");
        string choice = InputHandler.GetUserChoice();

        if (choice == "error")
        {
            Console.WriteLine("Some error occurred. The program is terminating.");
            return;
        }
        if (choice == "length") LengthConverter.Converter();

        if (choice == "currency") CurrencyConverter.Converter();
    }
}



