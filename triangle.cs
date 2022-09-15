using System;
class Triangle : Shape{
    public Triangle(int height, int width): base(height, width){
        
    }
    public void Omkrets(){
        int Omkrets = width+height*2;
        Console.Write("The circumferance of this shape is: " + Omkrets);
    }
    public void Area(){
        int area = width * height /2;
        Console.WriteLine("The area of this shape is: " + area);
    }
}