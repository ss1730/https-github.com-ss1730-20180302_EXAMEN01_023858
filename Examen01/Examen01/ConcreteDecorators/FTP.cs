using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen01.Abstract;
using Examen01.Interface;

namespace Examen01.ConcreteDecorators
{
    class FTP : IServiceable
    {
        private readonly Bank _bank;
        public FTP(Bank bank)
        {
            _bank = bank;
        }
        public string Notify()
        {
            return "Se hace por FTP";
        }

     
    }
}
