using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Motocicleta : Vehiculo
    {
        public  void Arrancar()
        {
            Console.WriteLine("Motocicleta arrancada.");
        }

        public  void Detener()
        {
            Console.WriteLine("Motocicleta detenida.");
        }

        public void Inclinar()
        {
            Console.WriteLine("Motocicleta inclinándose.");
        }
    }
}
