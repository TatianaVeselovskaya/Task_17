using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числовой номер счета");
            int numInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ФИО владельца");
            string name = Console.ReadLine();
            Console.WriteLine("Введите баланс");
            int summa = Convert.ToInt32(Console.ReadLine());
            BankAcc<int> bankAcc1 = new BankAcc<int>(numInt, name, summa);
            Console.WriteLine(bankAcc1.GetInfo());
            Console.WriteLine();

            Console.WriteLine("Введите строковый номер");
            string numString = Console.ReadLine();
            Console.WriteLine("Введите ФИО владельца");
            name = Console.ReadLine();
            Console.WriteLine("Введите баланс");
            summa = Convert.ToInt32(Console.ReadLine());
            BankAcc<string> bankAcc2 = new BankAcc<string>(numString, name, summa);
            Console.WriteLine(bankAcc2.GetInfo());

            Console.ReadKey();
        }
    }
}
