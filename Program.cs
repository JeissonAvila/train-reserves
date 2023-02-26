using System;
using TrainReserves.reserves;

namespace TrainReserves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            reserves();
        }

        private static Passengers passengers; 
        private static void reserves ()
        {
            Console.WriteLine("Hola, bienvenido al sistema de reservas del tren, que quieres hacer? \n 1. Reservar \n 2. Eliminar Reserva \n 3. Buscar Pasajero \n 4. Calcular el % de ocupación");
            var selectedAction = int.Parse(Console.ReadLine());
            var identification = 0;
            passengers = new Passengers();
            switch (selectedAction)
            {
                case 1:        
                    Console.WriteLine("Por favor escribe el tipo de silla: \n 1. Ejecutiva \n 2. Economica");
                    var chairType = int.Parse(Console.ReadLine());
                    Console.WriteLine("Por favor escribe la preferencia de la misma: \n 1. Ventanilla \n 2. Pasillo");
                    var chairPreference = int.Parse(Console.ReadLine());
                    var result = "";
                    if (chairType == 1 || chairType == 2)
                    {
                        result = passengers.ValidateClassAndPreference(chairType, chairPreference);
                        if (result != "")
                        {
                            Console.WriteLine(result);
                            break;
                        }
                        passengers.AddReserve(chairType, chairPreference);
                        setPassengerInfo();
                        Console.WriteLine("Se reservo de manera adecuada");
                    }
                    else
                    {
                        Console.WriteLine("Valor no valido, por favor intenta de nuevo desde el inicio.");
                    }              
                    break;
                case 2:
                    Console.WriteLine("Por favor digitar la identificación del usuario a eliminar la reserva.");
                    identification = int.Parse(Console.ReadLine());
                    var removeResult = passengers.RemovePassenger(identification);
                    if (removeResult)
                    {
                        Console.WriteLine("Reserva eliminada exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("El usuario no tenia reserva generada, valida que los datos esten correctos.");
                    }
                    break;
                case 3:
                    Console.WriteLine("Por favor digitar la identificación del usuario");
                    identification = int.Parse(Console.ReadLine());
                    var user = passengers.GetPassenger(identification);
                    if (user != null)
                    {
                        Console.WriteLine("La información del pasajero es: \n Nombre: " + user.FullName + "\n Identificacion: " + user.Identification + "\n Clase de reserva: " + user.SelectedClassChair + " \n Preferencia de silla: " + user.SelectedPreferenceChair);
                    }
                    else
                    {
                        Console.WriteLine("El usuario no tenia reserva generada, valida que los datos esten correctos.");
                    }
                    break;
                case 4:
                    var occupation = passengers.TrainOccupation();
                    Console.WriteLine("La ocupación del tren es de: " + occupation.ToString("0") + "%");
                    break;
                default:
                    Console.WriteLine("Ese valor no es valido, intenta de nuevo.");
                    break;
            }
            reserves();
        }

        private static void setPassengerInfo()
        {
            Console.WriteLine("Por favor escribe el nombre para la reserva:");
            passengers.FullName = (Console.ReadLine());
            Console.WriteLine("Por favor escribe el numero de identificación");
            passengers.Identification = int.Parse(Console.ReadLine());
            passengers.AddPassenger(passengers);
        }
    }
}