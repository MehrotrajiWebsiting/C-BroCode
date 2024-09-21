using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class enums
    {
        static void Main(String[] args)
        {
            Console.WriteLine(Planets.Pluto + " is a planet");
            Console.WriteLine(Planets.Pluto + " has number "+
                (int)Planets.Pluto);

            Console.WriteLine(PlanetsRadius.Earth+" has radius "+
                (int)PlanetsRadius.Earth);

            Console.WriteLine(Volume(PlanetsRadius.Earth));
        }
        static double Volume(PlanetsRadius radius)
        {
            return 4 / 3 * Math.PI * Math.Pow((int)radius, 3);
        }
    }
    //named integer constants
    enum Planets
    {
        Mercury,
        Venus,
        Earth,
        Mars,
        Jupiter,
        Saturn,
        Uranus,
        Neptune,
        Pluto
    }
    enum PlanetsRadius
    {
        Mercury = 122,
        Venus =2214,
        Earth = 141123,
        Mars =2132,
        Jupiter=21421,
        Saturn=41234,
        Uranus=4212,
        Neptune=21421,
        Pluto=1232
    }
}
