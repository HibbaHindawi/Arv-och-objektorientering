using System;

namespace Arv_och_objektorientering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose one Triangle or Rectangle. Answer with t or r" + " ");
            string shape = Console.ReadLine();
            if (shape == "t"){
                Console.WriteLine("triangle");
                Triangle triangle = new Triangle();

            }
            else if (shape == "r"){
                Console.WriteLine("rectangle");
                Rectangle rectangle = new Rectangle();
            }
            else{
                Console.WriteLine("invalid input");
            }
            Console.WriteLine("Please input the height and width of the shape by starting with the height first: ");
            double height = Convert.ToInt32(Console.ReadLine());
            double width = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
