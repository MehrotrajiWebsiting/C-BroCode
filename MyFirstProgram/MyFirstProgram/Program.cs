using System;

namespace MyFirstProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Om bhai");
            //int a=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(a*4);
            //Console.WriteLine(a.GetType());
            //String b=Console.ReadLine();
            //b=b.Replace('-', '/');
            //Console.WriteLine(b);
            //String c = "0123456789";
            //Console.WriteLine(c.Substring(3,4));
            //Console.WriteLine(Math.Max(1,2));
            //Random r=new Random();
            //Console.WriteLine(r.Next(0, 10));
            //Console.WriteLine(r.NextDouble());
            //bool sach = true;
            //if (sach) Console.WriteLine(!sach);
            //double a = 1.3;
            //double b = 2.4;
            //double c = Math.Round(Math.Sqrt(a*a+b*b));
            //Console.WriteLine(c);
            //int age=Convert.ToInt32(Console.ReadLine());
            //if (age > 18) Console.WriteLine("ADULT");
            //else if (age == 18) Console.WriteLine("Just adult");
            //else
            //{
            //    Console.WriteLine("CHILD");
            //}
            //String name=Console.ReadLine();
            //if (name == "OM")
            //{
            //    Console.WriteLine(name+" BHAI");
            //}
            //else if(name==""){
            //    Console.WriteLine("BRUH");
            //}
            //else
            //{
            //    Console.WriteLine(name);
            //}
            //Random random = new Random();
            //bool play = true;
            //while (play)
            //{
            //    int number = random.Next(1,101);
            //    int guess = -1;
            //    int counter = 10;
            //    while (guess != number && counter > 0)
            //    {
            //        guess = Convert.ToInt32(Console.ReadLine());
            //        counter--;
            //        if (guess < number)
            //        {
            //            Console.WriteLine("TOO SMALL");
            //        }
            //        else if (guess > number)
            //        {
            //            Console.WriteLine("TOO LARGE");
            //        }
            //    }
            //    if(guess == number)
            //        Console.WriteLine("CONGRATULATIONS YOU WIN\nThe number was "+number);
            //    else
            //        Console.WriteLine("YOU FAILED");
            //    Console.WriteLine("Enter 1 to play again");
            //    play = Console.ReadLine()=="1";
            //}
            //Random random = new Random();
            //bool play = true;
            //while (play)
            //{
            //    String user = "";
            //    String computer = "";
            //    while(user!="ROCK" && user!="PAPER" && user != "SCISSORS")
            //    {
            //        Console.WriteLine("Enter ROCK, PAPER, SCISSORS");
            //        user = Console.ReadLine().ToUpper();
            //    }
            //    switch (random.Next(1, 4))
            //    {
            //        case 1:
            //            computer = "ROCK";
            //            break;
            //        case 2:
            //            computer = "PAPER";
            //            break;
            //        case 3:
            //            computer = "SCISSORS";
            //            break;
            //    }
            //    Console.WriteLine("Player : " + user);
            //    Console.WriteLine("Computer : "+computer);

            //    switch (user)
            //    {
            //        case "ROCK":
            //            if(computer == "ROCK")
            //            {
            //                Console.WriteLine("It's a draw!");
            //            }
            //            else if(computer == "PAPER")
            //            {
            //                Console.WriteLine("You lose!");
            //            }
            //            else
            //            {
            //                Console.WriteLine("You win!");
            //            }
            //            break;
            //        case "PAPER":
            //            if (computer == "PAPER")
            //            {
            //                Console.WriteLine("It's a draw!");
            //            }
            //            else if (computer == "SCISSORS")
            //            {
            //                Console.WriteLine("You lose!");
            //            }
            //            else
            //            {
            //                Console.WriteLine("You win!");
            //            }
            //            break;
            //        case "SCISSORS":
            //            if (computer == "SCISSORS")
            //            {
            //                Console.WriteLine("It's a draw!");
            //            }
            //            else if (computer == "ROCK")
            //            {
            //                Console.WriteLine("You lose!");
            //            }
            //            else
            //            {
            //                Console.WriteLine("You win!");
            //            }
            //            break;
            //    }
            //    Console.WriteLine("Play again?(Y/N)");
            //    play=Console.ReadLine().ToUpper()=="Y";
            //}
            //Console.WriteLine("Thanks for playing!");
            //int x = 4;
            //Console.WriteLine($"x={x}");
            //String[] arr = new String[4];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = Console.ReadLine();
            //}
            //foreach (String s in arr)
            //{
            //    Console.WriteLine(s);
            //}
            Program obj=new Program();
            //staticSing();
            //obj.sing();
            //Console.WriteLine(obj.Cart());
            //Console.WriteLine(obj.Cart(1,2,3,4,5,6,90));
            //try
            //{
            //    int x=Convert.ToInt32(Console.ReadLine()); 
            //    Console.WriteLine(1/x);
            //}
            //catch (DivideByZeroException e){ 
            //    Console.WriteLine("WOW " + e.ToString());
            //}
            //catch(Exception e){
            //    Console.WriteLine($"Exception is {e.ToString()}");
            //}
            //finally
            //{
            //    Console.WriteLine("Bye");
            //}
            //int a = 12;
            //Console.WriteLine($"value is{a,4}:)");
            //Console.WriteLine($"value is{a,1}:)");
            //Console.WriteLine($"value is{a,-4}:)");
            //int[,] a = new int[2,4];
            //int[,] a ={ {1,2,3,4 },
            //     {5,6,7,8 } };
            //Console.WriteLine(a.Length);
            //Console.WriteLine(a.GetLength(0) + " " + a.GetLength(1));

            //for(int i = 0; i < a.GetLength(0); i++)
            //{
            //    for(int j = 0; j < a.GetLength(1); j++)
            //    {
            //        Console.Write(a[i, j]+ " ");
            //    }
            //    Console.WriteLine();
            //}
            //Inside.Hello();
            //Outside ob=new Outside();
            //ob.wait();
            //staticOutside.bye();

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);

            Console.WriteLine(list[1]);

            foreach (int i in list)
            {
                Console.Write(i + " -> ");
            }
            Console.WriteLine();
            list.Remove(3);

            foreach (int i in list)
            {
                Console.Write(i +" -> ");
            }
            Console.WriteLine();

            list.Insert(1, 3);
            foreach (int i in list)
            {
                Console.Write(i + " -> ");
            }
            Console.WriteLine();
            Console.WriteLine(list.Count);
            Console.WriteLine(list.IndexOf(3));
            Console.WriteLine(list.LastIndexOf(4));
            Console.WriteLine(list.Contains(2));
            list.Sort();
            foreach (int i in list)
            {
                Console.Write(i + " -> ");
            }
            Console.WriteLine();
            list.Reverse();
            foreach (int i in list)
            {
                Console.Write(i + " -> ");
            }
            Console.WriteLine();

            int[] arr = list.ToArray();
            foreach (int i in arr)
            {
                Console.Write(i + " -> ");
            }
            Console.WriteLine("list -");

            list.Clear();
            foreach (int i in list)
            {
                Console.Write(i + " -> ");
            }
            Console.WriteLine("Array - ");
            foreach (int i in arr)
            {
                Console.Write(i + " -> ");
            }
            Console.WriteLine();

            var a = 1;
            Console.WriteLine(a.GetType());
            Console.ReadKey();
        }

        double Cart(params double[] prices)
        {
            double total = 0;
            foreach (double price in prices)
            {
                total += price;
            }
            return total;
        }

        double mul(double x)
        {
            return x;
        }
        double mul(int x)
        {
            return x;
        }
        double mul(double x,double y)
        {
            return Convert.ToInt32(x);
        }
        
        void sing()
        {
            Console.WriteLine("Happy birthday");
        }
        static void staticSing()
        {
            Console.WriteLine("Static happy birthday");
        }
    }
    class Inside
    {
        //create object to use nonstatic function
        public static void Hello()
        {
            Console.WriteLine($"Hello");
        }
    }
}