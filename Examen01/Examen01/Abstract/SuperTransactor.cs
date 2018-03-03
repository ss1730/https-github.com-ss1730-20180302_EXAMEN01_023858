using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen01.Interface;

namespace Examen01.Abstract
{
    public class SuperTransactor
    {
        private string message = "";
       public  string SendingData(string origin,string destiny, double amount,IServiceable serviceable,Bank bank)
       {
           if (bank == null)
           {
               message = "Error en banco";
               
           }
           else
           {
               message = "transacion exitosa";
                bank.ReciveTransaction(origin, amount);
            }
           return message;
       }

      

   }
}
