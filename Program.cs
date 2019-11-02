using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name! ");
            string name=Console.ReadLine();
            Console.Write("Enter your old! ");
            int old=Int16.Parse(Console.ReadLine());


            FileReader file=new FileReader(@"C:\Users\HP\Documents\C#\Databases\Task\names.txt");

            file.WriteName(name,old);

            Console.WriteLine($"Hello {name}");
        }
    }
}
