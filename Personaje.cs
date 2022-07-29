 public enum Tipos
    {
        Ballestero,
        Arquero,
        Espadachin,
        Piquero,
        Campesino,
        Mandoble


    }
    public enum Nombre
    {

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
        int ID;
        int Edad;
        int velocidad;
        int Destreza;
        float Fuerza;
        int Nivel;
        float Armadura;
        Tipos Tipo;
        string Nombre;
        int Salud;
        int victorias;
         const int MDP= 50000;
        string[] nombres = new string[] { "Godwin", "Percival", "Wolfgang", "Nicholas", "Manrique", "Brayton" };
        public int salud { get => Salud; set => Salud = value; }
        public float fuerza { get => Fuerza; set => Fuerza = value; }
        public float armadura { get => Armadura; set => Armadura = value; }
        public int nivel { get => Nivel; set => Nivel = value; }
        public int id { get => ID; set=> ID=value ;}
        public int EDAD { get => Edad; set=>Edad =value ;}
        public string nombre { get => Nombre;set => Nombre = value;}
        public int Vict { get => victorias;set => victorias = value;}

        public Personaje(int id)
        {

            Random Aleatorio = new Random();
            int num = Aleatorio.Next(0, 6);
            this.ID=id;
            this.velocidad = Aleatorio.Next(1, 11);
            this.Destreza = Aleatorio.Next(1, 6);
            this.Fuerza = Aleatorio.Next(1, 11);
            this.Nivel = Aleatorio.Next(1, ID+5);
            this.Armadura = Aleatorio.Next(1, 11);
            this.Tipo =(Tipos)num;
            this.Nombre = nombres[Aleatorio.Next(0, 6)];
            this.Salud = 100;
            this.victorias=0;
        }

        public void MOSTRAR()
        {
            Console.WriteLine("velocidad= " + velocidad);
            Console.WriteLine("Destreza= " + Destreza);
            Console.WriteLine("Fuerza= " + Fuerza);
            Console.WriteLine("Nivel= " + Nivel);
            Console.WriteLine("Armadura= " + Armadura);
            Console.WriteLine("Tipo= " + Tipo);
            Console.WriteLine("Nombre= " + Nombre);
            Console.WriteLine("Edad= " + Edad);
            Console.WriteLine("Salud= " + Salud);
            Console.WriteLine("Victorias= " + victorias);
         }
         public void Ataque(Personaje P2){
             Random Aleatorio = new Random();
           float PoderDisparo=Destreza * Fuerza * Nivel;
           float EfectividadDisparo=Aleatorio.Next(0,101);
           float ValorAtaque=PoderDisparo*EfectividadDisparo;
           float PoderDefensa= P2.Armadura*P2.velocidad;
           float DañoProvocado=((ValorAtaque*EfectividadDisparo-PoderDefensa)/MDP)*100; 

           P2.salud=P2.salud-(int)DañoProvocado;
         }
         public void actualizarValores(){

            Salud=Salud+5;
            
            Fuerza=Fuerza * (float)1.02;
            Armadura=Armadura* (float)1.05;
            victorias=victorias+1;


         }




    }