using System;

namespace Album2
{   public enum Posicion
    {   Delantero,
        Lateral,
        Volante,
        Defensor,
        Arquero
    }
    
    public class Jugador
    {   private string nombres;
        private string apellidos;
        private DateTime fechaNacimiento ;
        private float peso;
        private float altura;
        private string imagen;
        private Posicion posicion;

        public Jugador(string nombres, DateTime fechaNacimiento)
        {
            this.nombres = nombres;
            this.fechaNacimiento = fechaNacimiento;
        }
      
        public Jugador(string nombres, string apellidos, DateTime fechaNacimiento, float peso, float altura, string imagen, Posicion posicion)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
            this.peso = peso;
            this.altura = altura;
            this.imagen = imagen;
            this.posicion = posicion;
        }

        public int getEdad()
        {   int currentYear = DateTime.Now.Year;
            int year = fechaNacimiento.Year;
            return currentYear-year;
        }

    }
}