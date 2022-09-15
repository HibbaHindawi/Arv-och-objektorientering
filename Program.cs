using System;

namespace Arv_och_objektorientering
{
    class Program
    {
        static void Main(string[] args)
        {
            int Loop = 0;
            int height;
            int width;
            while(Loop < 1){
                Console.WriteLine("Choose one Triangle or Rectangle. Answer with t or r: ");
                string shape = Console.ReadLine();
                if (shape == "t"){
                    Console.WriteLine("Please input a height and a width (height first, width last)");
                    height = int.Parse(Console.ReadLine());
                    width = int.Parse(Console.ReadLine());
                    Triangle triangle = new Triangle(height, width);
                    triangle.Area();
                    triangle.Omkrets();
                    Loop++;
                }
                else if (shape == "r"){
                    Console.WriteLine("Please input a height and a width (height first, width last)");
                    height = int.Parse(Console.ReadLine());
                    width = int.Parse(Console.ReadLine());
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
