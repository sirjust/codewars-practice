using System;


    class Program
    {
        static void Main(string[] args)
        {
            CharSwap charSwap = new CharSwap();

            Console.WriteLine(charSwap.Correct("L0ND0N"));
            Console.WriteLine(charSwap.Correct("DUBL1N"));
            Console.WriteLine(charSwap.Correct("51NGAP0RE"));
            Console.WriteLine(charSwap.Correct("BUDAPE5T"));
            Console.WriteLine(charSwap.Correct("PAR15"));
            Console.ReadLine();

        }
    }
