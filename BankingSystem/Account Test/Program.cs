using Banking_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Account myAccount1;
            myAccount1 = new Account("Juan Perez");

            Account myAccount2 = new Account("Jhon Doe");

           /* Console.WriteLine("myAccount1.Name={0}", myAccount1.Name);


            Console.WriteLine("myAccount2.Name={0}", myAccount2.Name);

            myAccount1.Name = "Juan Perez";
            myAccount2.Name = "Jhon Doe";*/

            Console.WriteLine("myAccount1.Name={0}", myAccount1.Name);
            Console.WriteLine("myAccount2.Name={0}", myAccount2.Name);
        }
    }
}
