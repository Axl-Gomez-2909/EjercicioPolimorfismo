using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Automovil : Vehiculo
    {
        public  void Arrancar()
        {
            Console.WriteLine("Automóvil arrancado.");
        }

        public  void Detener()
        {
            Console.WriteLine("Automóvil detenido.");
        }

        public void Acelerar()
        {
            Console.WriteLine("Automóvil acelerando.");
        }
    }
}
