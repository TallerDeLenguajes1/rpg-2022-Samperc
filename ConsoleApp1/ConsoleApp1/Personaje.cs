using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum Tipos
    {
        Ballestero,
        Arquero,
        Espadachin,
        Piquero,
        Campesino,
        Mandoble,
        jinete,
        
    }
    public enum Nombre{

    }
    public class Personaje
    {
        /* public class caracteristicas
         {
             int velocidad;
             int Destreza;
             int Fuerza;
             int Nivel;
             int Armadura;
             public caracteristicas(int velocidad, int destreza, int fuerza, int nivel, int armadura)
             {
                 this.velocidad = velocidad;
                 Destreza = destreza;
                 Fuerza = fuerza;
                 Nivel = nivel;
                 Armadura = armadura;
             }
         }

         public class datos
         {
             string Tipo;
             string Nombre;
             string Apodo;
             int Edad;
             int Salud;

             public datos(string tipo, string nombre, string apodo, int edad, int salud)
             {
                 Tipo = tipo;
                 Nombre = nombre;
                 Apodo = apodo;
                 Edad = edad;
                 Salud = salud;
             }
         } */

        int velocidad;
        int Destreza;
        int Fuerza;
        int Nivel;
        int Armadura;
        string Tipo;
        string Nombre;
        int Edad;
        int Salud;
        public Personaje(int velocidad, int destreza, int fuerza, int nivel, int armadura)
        {
            this.velocidad = velocidad;
            this.Destreza = destreza;
             this.Fuerza = fuerza;
             this.Nivel = nivel;
             this.Armadura = armadura;
        }
        public Personaje(string tipo, string nombre, int edad, int salud)
        {
            Tipo = tipo;
            Nombre = nombre;
            
            Edad = edad;
            Salud = salud;
        }



    }
}
