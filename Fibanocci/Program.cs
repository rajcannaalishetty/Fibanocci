using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibanocci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter ua target digit");
            int u = Convert.ToInt32(Console.ReadLine());
            int a = 0,x=0;
            int b = 1;
            
            for (int i = 0; i <= i+1; i++)
            {
                if (x <= u)
                {
                    Console.Write("{0} ", x);
                    x = a + b;
                    a = b;
                    b = x;
                    
                }
                else
                    break;
                
                }
            Console.ReadLine();
        }
    }
}
