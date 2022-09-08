using System;

namespace Arv_och_objektorientering
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            Rectangle rectangle = new Rectangle();
            
            Console.WriteLine("Choose one Triangle or Rectangle. Answer with t or r" + " ");
            string shape = Console.ReadLine();
            if (shape == "t"){
                Console.WriteLine("triangle");
            }
            else if (shape == "r"){
                Console.WriteLine("rectangle");
            }
            else{
                Console.WriteLine("invalid input");
            }
            Console.ReadKey();
        }
    }
}
