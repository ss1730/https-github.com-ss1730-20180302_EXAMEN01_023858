using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen01.Abstract;
using Examen01.ConcreteDecorators;
using Examen01.Interface;

namespace Examen01.ConcreteClasses
{
    class BankA:Bank
    {
        private string _name;
        public IServiceable Serviceable;
        private string _transactionOrigin;
        private string _transactionDestiny;
        private double _transactionAmount;

        public BankA()
        {
            _name = "Banco Azteca";
          
        }

        public override string AskData()
        {

            Console.WriteLine("Cuenta Origen: ");
            _transactionOrigin = Console.ReadLine();
            Console.WriteLine("Cuenta Destino: ");
            _transactionDestiny = Console.ReadLine();
            Console.WriteLine("Cantidad a Transferir: ");
            _transactionAmount = Double.Parse(Console.ReadLine());

            return "Origin: "+ _transactionOrigin + "Destiny: " + _transactionDestiny + "Amount: "+_transactionAmount;
        }

        public override string SendData(SuperTransactor trasactor,Bank bank)
        {
            return trasactor.SendingData(_transactionOrigin,_transactionDestiny,_transactionAmount,Serviceable,bank);
        }

        public override string ReciveTransaction(string origin,double amount)
        {
            _transactionOrigin = origin;
            _transactionAmount = amount;
            return "Trasaction From:" + _transactionOrigin + "The Amount Of : "+ amount;
        }

        public override string PrintTrnsaction()
        {
            return "Trasaction From:" + _transactionOrigin + "The Amount Of : " + _transactionAmount;
        }
    }
}
