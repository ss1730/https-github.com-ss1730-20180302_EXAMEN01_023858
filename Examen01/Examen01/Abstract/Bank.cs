using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen01.Interface;

namespace Examen01.Abstract
{
    public abstract class Bank
   {
       public abstract string AskData();
       public abstract string SendData(SuperTransactor trasactor,Bank bank);
       public abstract string ReciveTransaction(string origin,double amount);
       public abstract string PrintTrnsaction();
   }
}
