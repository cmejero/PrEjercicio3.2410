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

             string aux="";

           

            for (int i = 1; i <= k; i++)
            {
                aux = "";

                for (int j = 1; j <= i; j++)
                {
                    aux = aux + j;
                    
                }


                Console.WriteLine(aux);

            }
            
            

        }    
    }
}