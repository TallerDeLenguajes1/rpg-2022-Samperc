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
            int numeroPersonajes = 6;
            empezarJuego(PJ, numeroPersonajes);
            for (int i = 0; i < numeroPersonajes; i++)
            {
                Console.WriteLine("PJ " + i);

                PJ[i].MOSTRAR();
                Console.WriteLine("\n");
            }

            while (PJ.Count > 1)
            {
                int i = 0;


                int a = SeHagamoCaga(PJ[i],PJ[i + 1]);
                if (a == 1)
                {
                    Console.WriteLine($"GANO PJ {PJ[i].id}");
                    PJ[i].MOSTRAR();
                    PJ.RemoveAt(i + 1);
                }
                else
                {
                    Console.WriteLine($"GANO PJ {PJ[i + 1].id}");
                    PJ[i + 1].MOSTRAR();
                    PJ.RemoveAt(i);
                }

            }




            Console.Read();


        }

        //CARGAR TODOS LOS PERSONAJES
        public static void empezarJuego(List<Personaje> PJ, int numeroPersonajes)
        {
            Random Aleatorio = new Random();
            for (int i = 0; i < numeroPersonajes; i++)
            {
                PJ.Add(new Personaje(i + 1));
            }
        }

        public static int SeHagamoCaga(Personaje P1, Personaje P2)
        {
            int i = 0;
            while (i < 3 || P1.salud >= 0 || P2.salud >= 0)
            {
                if (P1.salud >= 0 && P2.salud >= 0)
                {
                    P1.Ataque(P2);

                }
                if (P1.salud >= 0 && P2.salud >= 0)
                {
                    P2.Ataque(P1);

                }
                i++;
            }
            if (P1.salud > P2.salud)
            {
                P1.salud = 100;
                return 1;
            }
            else if (P1.salud < P2.salud)
            {
                P2.salud = 100;
                return 2;
            }
            else
            {
                Random rdm = new Random();
                int a = rdm.Next(1, 3);

                if (a == 1)
                {
                    P1.salud = 100;
                    return 1;
                }
                else
                {
                    P2.salud = 100;
                    return 2;
                }


            }
        }
    }
}