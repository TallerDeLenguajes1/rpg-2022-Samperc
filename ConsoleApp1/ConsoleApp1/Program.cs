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
            List<Personaje> PJ = new List<Personaje>();

            empezarJuego(PJ, 6);
            for (int i  = 0; i  < 6;  i++)
            {
                Console.WriteLine("PJ " + i);

                PJ[i].MOSTRAR();
                Console.WriteLine("\n");
            }

            Console.Read();
            
            
        }
          public static void empezarJuego(List<Personaje> PJ, int numeroPersonajes)
        {
            Random Aleatorio = new Random();
            for (int i = 0; i < numeroPersonajes; i++)
            {   
                
                int num = Aleatorio.Next(0, 6);
                string tipo = Convert.ToString((Tipos)num);
                PJ.Add(new Personaje(Aleatorio.Next(1, 11), Aleatorio.Next(1, 6), Aleatorio.Next(1, 11), Aleatorio.Next(1, 11), 
                Aleatorio.Next(1, 11),tipo, Aleatorio.Next(0,6),Aleatorio.Next(0,300),100));
                

           

            }
        }
    }
}
