using System.Text.Json;
using System.Net;
using System.IO;
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
        apiEDADES(PJ);
    }
    //CONSUMIR API PREDECIR EDADES

    public static void apiEDADES(List<Personaje> PJ)
    {

        string urlaConcantenar = $"https://api.agify.io/?name[]=";
        string stringSticky = $"&name[]=";
        int i = 0;
        while (i < PJ.Count)
        {
            urlaConcantenar = String.Concat(urlaConcantenar, PJ[i].nombre);
            i++;
            if (i < PJ.Count)
            {
                urlaConcantenar = String.Concat(urlaConcantenar, stringSticky);
            }
        }


        var url = urlaConcantenar;
        Console.WriteLine(url);
        var request = (HttpWebRequest)WebRequest.Create(url);
        request.Method = "GET";
        request.ContentType = "application/json";
        request.Accept = "application/json";
        try
        {
            using (WebResponse response2 = request.GetResponse())
            {
                using (Stream strReader2 = response2.GetResponseStream())
                {
                    if (strReader2 == null) return;
                    using (StreamReader objReader2 = new StreamReader(strReader2))
                    {
                        string responseBody2 = objReader2.ReadToEnd();
                        List<Root> objPredecirEdad = JsonSerializer.Deserialize<List<Root>>(responseBody2)!;
                        {
                            for (int j = 0; j < PJ.Count; j++)
                            {
                                PJ[j].EDAD = objPredecirEdad[j].age;
                            }
                        }
                    }
                }
            }
        }
        catch (WebException ex)
        {

            Console.WriteLine("Problemas de acceso a la API");
        }

    }
    public static void ApiGraficos(int [] victorias)
    {
        //Inserto el url q crea un grafico y le añado el tamaño (anchura x altura)
        //como se a priori el numero de personajes coloco las etiquetas de los mismos

        string urlInicial = "https://image-charts.com/chart?cht=p&chs=700x400&chl=jugador0|jugador1|jugador2|jugador3|jugador4|jugador5&chan=1500,easeOutExpo&chdlp=l&chma=30,20,0,0";
        //A continuacion cargo los resultados de las batallas (N de victorias) a los parametros

        int i = 0;
        //concateno el nombre del parametro de los datos del grafico
        urlInicial = String.Concat(urlInicial, "&chd=t:");
        //y a continuacion los valores del mismo
        while (i < 6)
        {
            String valorPegar = (victorias[i]).ToString();
            i++;
            if (i < 6)
            {
                valorPegar = valorPegar + ",";
            }
            urlInicial = String.Concat(urlInicial, valorPegar);
        }
        i = 0;
         //concateno el nombre del parametro de las leyendas del grafico
        urlInicial = String.Concat(urlInicial, "&chdl=");
        //y a continuacion los valores del mismo
        while (i < 6)
        {
            String valorPegar = (victorias[i]).ToString() + "victorias";
            i++;
            if (i < 6)
            {
                valorPegar = valorPegar + "|";
            }
            urlInicial = String.Concat(urlInicial, valorPegar);
        }



        var uri = urlInicial;
        var psi = new System.Diagnostics.ProcessStartInfo();
        psi.UseShellExecute = true;
        psi.FileName = uri;
        System.Diagnostics.Process.Start(psi);
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