using System;

namespace project_xliv
{
    class Program
    {
        static void Main(string[] args)
        {
            //enums

            Console.WriteLine(Planets.Neptune + " is a planet");
            Console.WriteLine(Planets.Neptune + " is planet number : " + (int)Planets.Neptune);
            Console.WriteLine(Planets.Mercury + " is planet number : "  + (int)Planets.Mercury);

            String name = PlanetRadius.Earth.ToString();
             int radius = (int)PlanetRadius.Earth;
            double volume = Volume(PlanetRadius.Earth);


            Console.WriteLine("\nPlanet : " + name);
            Console.WriteLine("the radius of earth be like " + radius + " km long lmfao");
            Console.WriteLine("volume of earth do be like " + volume + " km^3");

            Console.ReadKey();
        }
        public static double  Volume(PlanetRadius radius)
        {
            double  volume = (4.0/3.0) * Math.PI * Math.Pow((int)radius, 3);
            return volume;
        }
    }
    enum Planets
    {
        Mercury = 1,
        Venus =2, 
        Earth =3 , 
        Mars = 4, 
        Jupiter =5 , 
        Saturn  = 6, 
        Uranus = 7, 
        Neptune = 8
    }
    enum PlanetRadius
    {
        Mercury = 2439,
        Venus = 6051,
        Earth = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25362,
        Neptune = 24622
    }
}

