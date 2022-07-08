static class funciones
{

    //CARGAR TODOS LOS PERSONAJES
    public static void empezarJuego(List<Personaje> PJ, int numeroPersonajes)
    {
        Random Aleatorio = new Random();
        for (int i = 0; i < numeroPersonajes; i++)
        {
            PJ.Add(new Personaje(i));
        }
    }

    public static int SeHagamoCaga(Personaje P1, Personaje P2)
    {
        int i = 0;
        while (i < 3 && P1.salud >= 0 && P2.salud >= 0)
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