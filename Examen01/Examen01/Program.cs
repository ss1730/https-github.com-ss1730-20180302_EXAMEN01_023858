using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen01.Abstract;
using Examen01.ConcreteClasses;

namespace Examen01
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperTransactor superTransactor = new SuperTransactor();
            Bank bankA = new BankA();
            Bank bankB = new BankB();
            Bank bankC = new BankC();
            //Primera
            bankA.AskData();
            Console.WriteLine(bankA.SendData(superTransactor,bankB));
            Console.WriteLine(bankB.PrintTrnsaction());

            //Segundo
            bankC.AskData();
            Console.WriteLine(bankC.SendData(superTransactor, bankA));
            Console.WriteLine(bankA.PrintTrnsaction());

            //Terecero
            bankB.AskData();
           Console.WriteLine(bankB.SendData(superTransactor, bankA));
           Console.WriteLine(bankA.PrintTrnsaction());

            Console.ReadKey();
        }
    }
}
