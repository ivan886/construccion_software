using System;

namespace Album2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaNacimiento1 = new DateTime(2000,5, 7);
            Jugador jugador1 = new Jugador("FRANCO",    fechaNacimiento1 );
            Jugador jugador2 = new Jugador("JUAN MARCOS",fechaNacimiento1);

            int edad = jugador1.getEdad();
            Console.WriteLine(edad);

        }
    }
}