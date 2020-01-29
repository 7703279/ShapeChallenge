using System;
using System.Collections.Generic;
using System.Text;


namespace Shapetest2
{
    public abstract class Shape
    {
        public string Colour;
        public Shape(string colour)
        {
            this.Colour = colour;
        }
    }

    public abstract class Quadliteral : Shape, IShapeCalc
    {
        public double SideLength1 { get; set; }
        public double SideLength2 { get; set; }
        public double SideLength3 { get; set; }
        public double SideLength4 { get; set; }

        public Quadliteral(string colour, double side1, double side2, double side3, double side4) : base(colour)
        {
            this.SideLength1 = side1;
            this.SideLength2 = side2;
            this.SideLength3 = side3;
            this.SideLength4 = side4;
        }

        public virtual double getPerimeter()
        {
            return SideLength1 + this.SideLength2 + this.SideLength3 + this.SideLength4;
        }
        public abstract double getArea();

    }

    public abstract class Triangle : Shape
    {
        public double SideLength1 { get; set; }
        public double SideLength2 { get; set; }
        public double SideLength3 { get; set; }

        public Triangle(string colour, double side1, double side2, double side3) : base(colour)
        {
            this.SideLength1 = side1;
            this.SideLength2 = side2;
            this.SideLength3 = side3;
        }
        public virtual double getPerimeter()
        {
            return this.SideLength1 + this.SideLength2 + this.SideLength3;
        }
        public abstract double getArea();
    }

    public class Circle : Shape, IShapeCalc
    {
        public readonly double PI = Math.PI;

        public double Radius { get; set; }
        public Circle(string colour, int radius) : base(colour)
        {
            this.Radius = radius;
        }
        public double getPerimeter()
        {
            return this.Radius * 2 * PI;
        }
        public double getArea()
        {
            return this.Radius * this.Radius * PI;
        }
    }

    public class Square : Quadliteral
    {
        public Square(string colour, double side1) : base(colour, side1, 0, 0, 0)
        {
        }

        public override double getArea()
        {
            return this.SideLength1 * this.SideLength1;
        }

        public override double getPerimeter()
        {
            return this.SideLength1 *4;
        }
    }

    public class Rectangle : Quadliteral
    {
        public Rectangle(string colour, double side1, double side2) : base(colour, side1, side2, 0, 0)
        {
        }

        public override double getArea()
        {
            return this.SideLength1 * this.SideLength2;
        }

        public override double getPerimeter()
        {
            return (this.SideLength1 * 2) + (this.SideLength2 * 2);
        }
    }
    public class Equilateral : Triangle, IShapeCalc
    {
        public Equilateral(string colour, double side1) : base(colour, side1, 0, 0)
        {
        }
        
        public override double getArea()
        {
            return Math.Sqrt(3) / 4 * this.SideLength1 * this.SideLength1;
        }
               
        public override double getPerimeter()
        {
            return this.SideLength1 + this.SideLength1 + this.SideLength1;
        }
    }

    public class RightAngle : Triangle, IShapeCalc
    {
        public RightAngle(string colour, double side1, double side2) : base(colour, side1, side2, 0)
        {
        }
        public override double getArea()
        {
            return this.SideLength1 * this.SideLength2 * 1 / 2;
        }

        protected double SL3;
                      
        protected void SetHypotenuse()
        {
            
            SL3 = Math.Sqrt(SideLength1 * SideLength1 + SideLength2 * SideLength2);
        }
        
        
        public override double getPerimeter()
        {
            SetHypotenuse();    
            return this.SideLength1 + this.SideLength2 + SL3;
        }
    }
}
