using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Microsoft.VisualBasic.Interaction.InputBox("Ingresa un numero", "Input", "0000");
            List<Personaje> P = new List<Personaje>();
            string[] personajes= new string[]{"personaje1","personaje2","personaje3"};
            Console.WriteLine(personajes[0]);
            Console.WriteLine(personajes[1]);
            Console.WriteLine(personajes[2]);
        }


        void empezarJuego(List<Personaje> P, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Random Aleatorio = new Random();
                
                P.Add(new Personaje(Aleatorio.Next(1,11),Aleatorio.Next(1,6),Aleatorio.Next(1,11),Aleatorio.Next(1,11),Aleatorio.Next(1,11)));//Cargar Caracteristicas
                
                P.Add(new Personaje());//Cargar Datos

            }
        }
    }
}
