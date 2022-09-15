using System;
class Rectangle: Shape{
    public Rectangle(int height, int width): base(height, width){
        
    }
    public void Omkrets(){
        int Omkrets = width*2 + height*2;
        Console.Write("The circumferance of this shape is: " + Omkrets);
    }
    public void Area(){
        int area = width * height;
        Console.Write("The Area of this shape is: " + area);
    }
}