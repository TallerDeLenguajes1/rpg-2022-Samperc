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
        Mandoble
    }
    public class Personaje
    {
        public class caracteristicas
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
        } 

        
        
    }
}
