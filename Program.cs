// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using System.Net;
using System.IO;

Console.WriteLine("Hello, World!");


Console.WriteLine("Deseas crear nuevo jugadores ('S') o usar jugadores guardados de la partida anterior ('N') ");
char char1 = char.Parse(Console.ReadLine());
List<Personaje> PJ = new List<Personaje>();
int numeroPersonajes = 6;
if (char1 == 'S')
{

    funciones.empezarJuego(PJ, numeroPersonajes);

    //SERIALIZAR LISTA DE OBJETOS 

    string fileName = "Personajes.json";
    string jsonString = JsonSerializer.Serialize(PJ);
    File.WriteAllText(fileName, jsonString);

}
else
{    //DESERIALIZAR LISTA DE OBJETOS 

    string fileName = "Personajes.json";
    string jsonString2 = File.ReadAllText(fileName);
    PJ = JsonSerializer.Deserialize<List<Personaje>>(jsonString2)!;
}
for (int i = 0; i < numeroPersonajes; i++)
{
    Console.WriteLine("PJ " + i);

    PJ[i].MOSTRAR();
    Console.WriteLine("\n");
}
/**********                             */

//Crear archivo csv para guardar ganadores
FileStream MiArchivo = new FileStream("ganadores.csv", FileMode.OpenOrCreate);
StreamWriter sw = new StreamWriter(MiArchivo);
int[] victorias;
victorias= new int[] {0,0,0,0,0,0};
//Pelea de personajes y elimacion del perdedor (Se muestra el ganador y lo guarda en archivo csv)
while (PJ.Count > 1)
{
    int j = 0;

    int a = funciones.SeHagamoCaga(PJ[j], PJ[j + 1]);

    if (a == 1)
    {
        Console.WriteLine($"GANO PJ {PJ[j].id}");
        PJ[j].actualizarValores();
        PJ[j].MOSTRAR();

        sw.WriteLine(PJ[j].id + ";" + PJ[j].nombre + ";" + PJ[j].nivel);

        Console.WriteLine("--------------------");
        victorias[PJ[j+1].id]=PJ[j+1].Vict;
        PJ.RemoveAt(j + 1);
    }
    else
    {
        Console.WriteLine($"GANO PJ {PJ[j + 1].id} ");
        PJ[j + 1].actualizarValores();
        PJ[j + 1].MOSTRAR();

        sw.WriteLine(PJ[j + 1].id + ";" + PJ[j + 1].nombre + ";" + PJ[j + 1].nivel);

        Console.WriteLine("--------------------");
        victorias[PJ[j].id]=PJ[j].Vict;
        PJ.RemoveAt(j);
    }

}
victorias[PJ[0].id]=PJ[0].Vict;
sw.Close();

 funciones.ApiGraficos(victorias);
