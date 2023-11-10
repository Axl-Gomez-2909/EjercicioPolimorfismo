using EjercicioPolimorfismo;

List<IVehiculo> vehiculos = new List<IVehiculo>
        {
            new Automovil(),
            new Motocicleta(),
            new Vehiculo()
        };

foreach (var vehiculo in vehiculos)
{
    vehiculo.Arrancar();
    vehiculo.Detener();

    // Verifica si el vehículo es un Automovil para llamar a métodos específicos
    if (vehiculo is Automovil)
    {
        ((Automovil)vehiculo).Acelerar();
    }
    // Verifica si el vehículo es una Motocicleta para llamar a métodos específicos
    else if (vehiculo is Motocicleta)
    {
        ((Motocicleta)vehiculo).Inclinar();
    }

    Console.WriteLine();
}
