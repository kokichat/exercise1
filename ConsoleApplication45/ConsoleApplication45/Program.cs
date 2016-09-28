using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication45
{
    class Program
    {
        static void Main(string[] args)
        {
            double montlyDays = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            double value = double.Parse(Console.ReadLine());
            
            double montlyMoney = money * montlyDays;
            double yearlyMoney = (montlyMoney * 12) + (montlyMoney * 2.5);
            double moneyTaxes = yearlyMoney - (yearlyMoney / 4);
            double valueBGN = moneyTaxes * value;
            double moneyDay = valueBGN / 365;

            Console.WriteLine(Math.Round(moneyDay, 2));
        }
    }
}
