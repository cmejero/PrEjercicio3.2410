


using edu.PrEjercicio3._2410.Servicios;

namespace edu.PrEjercicio3._2410.Controladores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            OperacionInterfaz oi = new OperacionImplementacion();
            int numSelec = mi.pedirNumero();
            oi.menuBucle(numSelec);

           
            
        }
    }

}
