using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17_v1
{
    class BankAcc<T>
    {
        public T Num { get; set; }
        public string Name { get; set; }
        public int Summa { get; set; }

        public BankAcc(T num, string name, int summa)
        {
            Num = num;
            Name = name;
            Summa = summa;
        }

        public string GetInfo()
        {
            return $"{Num} {Name} {Summa}";
        }
    }
}
