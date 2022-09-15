using System;

namespace Arv_och_objektorientering
{
    class Program
    {
        static void Main(string[] args)
        {
            int Loop = 0;
            while(Loop < 1){
                int height = int.Parse(Console.ReadLine());
                int width = int.Parse(Console.ReadLine());
                Console.WriteLine("Choose one Triangle or Rectangle. Answer with t or r: ");
                string shape = Console.ReadLine();
                if (shape == "t"){
                    Console.WriteLine("Please input a height and a width (height first, width last)");
                    Triangle triangle = new Triangle(height, width);
                    triangle.Area();
                    triangle.Omkrets();
                    Loop++;
                }
                else if (shape == "r"){
                    Console.WriteLine("Please input a height and a width (height first, width last)");
                    Rectangle rectangle = new Rectangle(height, width);
                    Loop++;
                }
                else{
                    Console.WriteLine("invalid input");
                }            
            }
            Console.ReadKey();
        }
    }
}
