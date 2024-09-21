using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class oops
    {
        public static void Main(String[] args)
        {

            Car c = new Car(1,"om",21);
            Console.WriteLine(c.id);
            c.identity();
            c.ab();

            Console.WriteLine();
            Car[] garage=new Car[2];
            garage[0] = c;
            garage[1] = new Car(2,"rohit",22);

            foreach (Car car in garage)
            {
                car.identity();
            }
            Car nc=copy(c);
            changeAge(c, 101);
            garage[0].identity();
            nc.identity();  

            c.fg();
            (new Bike(4)).fg();

            Console.WriteLine(c); // same as ToString()
            Console.WriteLine(c.ToString());

            Vehicle[] vehicles = {new Car(1,"om",21), new Bike(2) };
            foreach (Vehicle vehicle in vehicles)
            {
                //THIS CALLS IDENTITY OF VEHICLE CLASS
                //AS ITS NOT OVERRIDDEN
                vehicle.identity();
                //for bike this calls fg in bike
                //as its overridden
                vehicle.fg();
            }
        }
        public static void changeAge(Car car,int age)
        {
            car.age = age;
        }
        public static Car copy(Car car)
        {
            return new Car(car.id,car.name,car.age);
        }
    }
}
abstract class Vehicle
{
    public int id;
    public string name;
    public int age;
    public Vehicle(int id)
    {
        this.id = id;
    }
    public void identity()
    {
        Console.WriteLine(id + " in vehicle");
    }
    public void cd()
    {
        Console.WriteLine("age = "+age);
    }
    //must be overriden by child
    public abstract void ab();
    //may or not be overriden by children
    public virtual void fg()
    {
        Console.WriteLine("fg called in vehicle");
    }
}
class Car : Vehicle
{
    public Car(int i,String j,int a) : base(i)
    {
        base.name = j;
        age = a;
    }
    public void identity() 
    {
        Console.WriteLine();
        cd();
        base.identity();
        Console.WriteLine(base.name);
    }
    // must override abstract functions
    // can use override only for abstract, virtual functions
    public override void ab()
    {
        Console.WriteLine("called ab");
    }
    public override string ToString()
    {
        return $"Id={id}\tName={name}\tAge={age}";
    }
}
class Bike : Vehicle
{
    public Bike(int id) : base(id) { 
    }
    public override void ab()
    {
        
    }
    //virtual methods can be overriden
    public override void fg()
    {
        Console.WriteLine("fg called from bike");
    }
}