using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen01.Abstract;
using Examen01.Interface;

namespace Examen01.ConcreteDecorators
{
    class HTTP: IServiceable
    {
        private readonly Bank _bank;
        public HTTP(Bank bank)
        {
            _bank = bank;
        }
        public string Notify()
        {
            return "Se hace por HTTP";
        }

     
    }
}
