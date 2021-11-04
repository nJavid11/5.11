using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.Name = Console.ReadLine();
            Console.WriteLine(d.Name);
            Console.WriteLine(d.Eat());
        }
    }
}
