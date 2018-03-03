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
        private string _transactionAmount;

        public BankA(string name)
        {
            _name = "Banco Azteca";
            Serviceable = new FTP();
        }

        public override string AskData()
        {

            Console.WriteLine("Cuenta Origen: ");
            _transactionOrigin = Console.ReadLine();
            Console.WriteLine("Cuenta Destino: ");
            _transactionDestiny = Console.ReadLine();
            Console.WriteLine("Cantidad a transferir: ");
            _transactionAmount = Console.ReadLine();

            return "Origin: "+ _transactionOrigin + "Destiny: " + _transactionDestiny + "Amount: "+_transactionAmount;
        }

        public override string SendData(SuperTransactor trasactor)
        {
            return trasactor.SendingData(_transactionOrigin,_transactionDestiny,_transactionAmount,Serviceable);
        }

      

        public override string ReciveTransaction()
        {
            throw new NotImplementedException();
        }
    }
}
