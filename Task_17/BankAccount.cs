using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17_v2
{
    class BankAccount<T>
    {
        public T Num { get; set; }
        public string Name { get; set; }
        public int Summa { get; set; }

        public string GetInfo()
        {
            return $"{Num} {Name} {Summa}";
        }

        public void Input()
        {
            Console.WriteLine("Введите номер счета");
            string stringNum = Console.ReadLine();
            Num = (T)Convert.ChangeType(stringNum, typeof(T));

            Console.WriteLine("Введите ФИО владельца");
            Name = Console.ReadLine();
            Console.WriteLine("Введите баланс");
            Summa = Convert.ToInt32(Console.ReadLine());
        }
    }
}
