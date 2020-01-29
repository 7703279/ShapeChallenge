using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapetest2;
using NUnit.Framework;

namespace TestShape
{
    [TestFixture]
    public class Tests
    {
        
        Square s1 { get; set; }
        Square s2 { get; set; }
        Square s3 { get; set; }

       Rectangle r1 { get; set; }
       Rectangle r2 { get; set; }
       Rectangle r3 { get; set; }
                   
        RightAngle ra1 { get; set; }
        RightAngle ra2 { get; set; }
        RightAngle ra3 { get; set; }

        Equilateral e1 { get; set; }
        Equilateral e2 { get; set; }
        Equilateral e3 { get; set; }


        Circle c1 { get; set; }

        Circle c2 { get; set; }
        Circle c3 { get; set; }


        [SetUp]
        public void Init()
        {
            s1 = new Square("white", 5);
            s2 = new Square("white", 15);
            s3 = new Square("white", 7);

            r1 = new Rectangle("white", 5, 10);
            r2 = new Rectangle("white", 4, 6);
            r3 = new Rectangle("white", 9, 7);

            c1 = new Circle("White", 5);
            c2 = new Circle("White", 15);
            c3 = new Circle("White", 7);

            e1 = new Equilateral("White", 5);
            e2 = new Equilateral("White", 15);
            e3 = new Equilateral("White", 7);

            ra1 = new RightAngle("White", 5, 10);
            ra2 = new RightAngle("White", 4, 6);
            ra3 = new RightAngle("White", 9, 7);
        }

        [Test]
        public void SquareTest()
        {
            double area = 25;
            double perimeter = 20;
            Assert.AreEqual(Math.Round(area, 2), Math.Round(s1.getArea(), 2));
            Assert.AreEqual(Math.Round(perimeter, 2), Math.Round(s1.getPerimeter(), 2));

            area = 225;
            perimeter = 60;
            Assert.AreEqual(Math.Round(area, 2), Math.Round(s2.getArea(), 2));
            Assert.AreEqual(Math.Round(perimeter, 2), Math.Round(s2.getPerimeter(), 2));

            area = 49;
            perimeter = 28;
            Assert.AreEqual(Math.Round(area, 2), Math.Round(s3.getArea(), 2));
            Assert.AreEqual(Math.Round(perimeter, 2), Math.Round(s3.getPerimeter(), 2));
        }

        [Test]
        public void RectangleTest()
        {
            double area = 50;
            double perimeter = 30;
            Assert.AreEqual(Math.Round(area, 2), Math.Round(r1.getArea(), 2));
            Assert.AreEqual(Math.Round(perimeter, 2), Math.Round(r1.getPerimeter(), 2));

            area = 24;
            perimeter = 20;
            Assert.AreEqual(Math.Round(area, 2), Math.Round(r2.getArea(), 2));
            Assert.AreEqual(Math.Round(perimeter, 2), Math.Round(r2.getPerimeter(), 2));

            area = 63;
            perimeter = 32;
            Assert.AreEqual(Math.Round(area, 2), Math.Round(r3.getArea(), 2));
            Assert.AreEqual(Math.Round(perimeter, 2), Math.Round(r3.getPerimeter(), 2));
        }

        [Test]
        public void CircleTest()
        {
            double area = 78.54;
            double perimeter = 31.42;
            Assert.AreEqual(Math.Round(area, 2), Math.Round(c1.getArea(), 2));
            Assert.AreEqual(Math.Round(perimeter, 2), Math.Round(c1.getPerimeter(), 2));
          
            area = 706.86;
            perimeter = 94.25;
            Assert.AreEqual(Math.Round(area, 2), Math.Round(c2.getArea(), 2));
            Assert.AreEqual(Math.Round(perimeter, 2), Math.Round(c2.getPerimeter(), 2));

            area = 153.94;
            perimeter = 43.98;
            Assert.AreEqual(Math.Round(area, 2), Math.Round(c3.getArea(), 2));
            Assert.AreEqual(Math.Round(perimeter, 2), Math.Round(c3.getPerimeter(), 2));      
        }

        [Test]
        public void EquilateralTest()
        {
            double area = 10.83;
            double perimeter = 15;
            Assert.AreEqual(Math.Round(area, 2), Math.Round(e1.getArea(), 2));
            Assert.AreEqual(Math.Round(perimeter, 2), Math.Round(e1.getPerimeter(), 2));

            area = 97.43;
            perimeter = 45;
            Assert.AreEqual(Math.Round(area, 2), Math.Round(e2.getArea(), 2));
            Assert.AreEqual(Math.Round(perimeter, 2), Math.Round(e2.getPerimeter(), 2));

            area = 21.22;
            perimeter = 21;
            Assert.AreEqual(Math.Round(area, 2), Math.Round(e3.getArea(), 2));
            Assert.AreEqual(Math.Round(perimeter, 2), Math.Round(e3.getPerimeter(), 2));
        }


        [Test]
        public void RightAngleTest()
        {
            double area = 25;
            double perimeter = 26.18;
            Assert.AreEqual(Math.Round(area, 2), Math.Round(ra1.getArea(), 2));
            Assert.AreEqual(Math.Round(perimeter, 2), Math.Round(ra1.getPerimeter(), 2));

            area = 12;
            perimeter = 17.21;
            Assert.AreEqual(Math.Round(area, 2), Math.Round(ra2.getArea(), 2));
            Assert.AreEqual(Math.Round(perimeter, 2), Math.Round(ra2.getPerimeter(), 2));

            area = 31.5;
            perimeter = 27.4;
            Assert.AreEqual(Math.Round(area, 2), Math.Round(ra3.getArea(), 2, MidpointRounding.AwayFromZero));
            Assert.AreEqual(Math.Round(perimeter, 2), Math.Round(ra3.getPerimeter(), 2));
        }
    }
}
