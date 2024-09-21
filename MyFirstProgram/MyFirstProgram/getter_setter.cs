using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class getter_setter
    {
        public static void Main(String[] args)
        {
            abcd obj = new abcd(400);
            Console.WriteLine(obj.Speed);
            abcd obj1 = new abcd(1000);
            Console.WriteLine(obj1.Speed);
        }
    }
}
class abcd
{
    //speed - field
    //Speed - property
    private int speed;
    public abcd(int speed)
    {
        Speed = speed;
    }

    public int Speed
    {
        // getter and setter are accessors
        get { return speed; }
        set
        {
            if (value > 500) speed = 500;
            else
                speed=value;
        }
    }
}
