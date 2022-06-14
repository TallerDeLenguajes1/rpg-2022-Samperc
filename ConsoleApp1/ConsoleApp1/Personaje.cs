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
        string[] nombres = new string[] { "Godwin", " Percival", "Wolfgang", "Nicholas", "Manrique", "Brayton" };
        public Personaje(int velocidad, int destreza, int fuerza, int nivel, int armadura, string tipo, int nombre, int edad, int salud) 
        {
            this.velocidad = velocidad;
            this.Destreza = destreza;
            this.Fuerza = fuerza;
            this.Nivel = nivel;
            this.Armadura = armadura;
            Tipo = tipo;
            Nombre = nombres[nombre];
            Edad = edad;
            Salud = salud;
        }

        public void MOSTRAR()
        {
            Console.WriteLine("velocidad= "+ velocidad);
            Console.WriteLine("Destreza= "+ Destreza);
            Console.WriteLine("Fuerza= " + Fuerza);
            Console.WriteLine("Nivel= "+ Nivel);
            Console.WriteLine("Armadura= " + Armadura);
            Console.WriteLine("Tipo= "+Tipo);
            Console.WriteLine("Nombre= "+ Nombre);
            Console.WriteLine("Edad= "+ Edad);
            Console.WriteLine("Salud= " + Salud);


        }




    }
}
