using System;
using System.Collections.Generic;

// Interface
public interface IArea
{
    double GetArea();
}

// Abstract Base Class
public abstract class Shape : IArea
{
    public abstract double GetArea();
}

// Circle
public class Circle : Shape
{
    private double r;

    public Circle(double radius)
    {
        r = radius;
    }

    public override double GetArea()
    {
        return Math.PI * r * r;
    }
}

// Rectangle
public class Rectangle : Shape
{
    private double w, h;

    public Rectangle(double width, double height)
    {
        w = width;
        h = height;
    }

    public override double GetArea()
    {
        return w * h;
    }
}

// Triangle
public class Triangle : Shape
{
    private double b, h;

    public Triangle(double baseVal, double height)
    {
        b = baseVal;
        h = height;
    }

    public override double GetArea()
    {
        return 0.5 * b * h;
    }
}

// Main Program
public class Program
{
    public static void Main()
    {
        string[] shapes = {
            "C 3",
            "R 4 5",
            "T 6 2"
        };

        double totalArea = ComputeTotalArea(shapes);
        Console.WriteLine("Total Area = " + totalArea);
    }

    public static double ComputeTotalArea(string[] shapes)
    {
        List<Shape> shapeList = new List<Shape>();

        foreach (var s in shapes)
        {
            string[] parts = s.Split(' ');
            string type = parts[0];

            if (type == "C")
            {
                double r = double.Parse(parts[1]);
                shapeList.Add(new Circle(r));
            }
            else if (type == "R")
            {
                double w = double.Parse(parts[1]);
                double h = double.Parse(parts[2]);
                shapeList.Add(new Rectangle(w, h));
            }
            else if (type == "T")
            {
                double b = double.Parse(parts[1]);
                double h = double.Parse(parts[2]);
                shapeList.Add(new Triangle(b, h));
            }
        }

        double total = 0;
        foreach (var shape in shapeList)
        {
            total += shape.GetArea();
        }

        // Round to 2 decimals (Away from Zero)
        return Math.Round(total, 2, MidpointRounding.AwayFromZero);
    }
}
