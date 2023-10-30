using edu.PrEjercicio3._2410.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace edu.PrEjercicio3._2410.Servicios
{
    internal class OperacionImplementacion : OperacionInterfaz
    {

        public void menuBucle(int k)
        {

            MenuInterfaz mi = new MenuImplementacion();

            int suma = 0;

            k = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= k; i++)
            {
                Console.WriteLine(i);
                for (int j = 0; j<= k; j++)
                {
                    Console.WriteLine(j + "" +i);
                }


                 
               
                
                
            }

            

        }    
    }
}