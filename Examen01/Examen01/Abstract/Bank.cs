using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen01.Abstract
{
   abstract class Bank
   {
       public  string Name;
       public abstract string AskData();
       public abstract string ReciveTransaction();
   }
}
