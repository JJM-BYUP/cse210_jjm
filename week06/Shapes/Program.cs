using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("yellow", 4);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("blue", 5, 8);
        shapes.Add(s2);

        Circle s3 = new Circle("green", 6);
        shapes.Add(s3);
    
        foreach (Shape s in shapes)
        {
            Console.WriteLine($"This is a {s.GetColor()} shape with an area of {s.GetArea()}");
        }
    }
}