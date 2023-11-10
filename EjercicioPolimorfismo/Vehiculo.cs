using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Vehiculo : IVehiculo
    {
        public  void Arrancar()
        {
            Console.WriteLine("Vehículo arrancado.");
        }

        public  void Detener()
        {
            Console.WriteLine("Vehículo detenido.");
        }
    }
}
