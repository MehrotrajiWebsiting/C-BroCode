using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class interfacee
    {
        public static void Main(String[] args)
        {
            Rabbit rabbit=new Rabbit();
            Hawk hawk =new Hawk();
            Fish fish = new Fish();

            rabbit.Flee();
            hawk.Hunt();
            fish.Flee();
            fish.Hunt();
        }
    }
    interface IPrey
    {
        void Flee();
    }
    interface IPredator
    {
        void Hunt();
    }
    class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("Fall Back to Safe zone");
        }
    }
    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("LET'S HUNT");
        }
    }
    class Fish : IPredator, IPrey
    {
        public void Flee()
        {
            Console.WriteLine("SAVE THE FISH");
        }
        public void Hunt()
        {
            Console.WriteLine("SMALL FISH FOUND");
        }
    }
}
