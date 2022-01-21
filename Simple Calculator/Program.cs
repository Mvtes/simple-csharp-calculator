using System;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a calculator, write 1 number.");
            var nmbr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("write 2th number");
            var nmbr2 = int.Parse(Console.ReadLine());
            var operation = Console.ReadLine();
            var wyn = 0;
            switch (operation)
            {

                case "+":
                    wyn = nmbr1 + nmbr2;
                    break;
                case "-":
                    wyn = nmbr1 - nmbr2;
                    break;
                case "*":
                    wyn = nmbr1 * nmbr2;
                    break;
                case "/":
                    wyn = nmbr1 / nmbr2;
                    break;
                default:
                    break;
            }
            Console.WriteLine("wynik dzialania to", wyn);
        }
    }
}
