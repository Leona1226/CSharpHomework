using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    public abstract class Shape
    {
        private string myId;
        public Shape(string s)
        {
            Id = s;
        }
        public string Id
        {
            get
            {
                return myId;
            }
            set
            {
                myId = value;
            }
        }
        public abstract double Area
        {
            get;
        }
        public virtual void Draw()
        {
            Console.WriteLine("Draw Shape Icon");
        }
    }
    //三角形
    public class Triangle : Shape
    {
        private int side1, side2, side3;
        double c;
        double p;
        public Triangle(int sideA, int sideB, int sideC, string id) : base(id)
        {
            if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
            {
                side1 = sideA;
                side2 = sideB;
                side3 = sideC;
                c = side1 + side2 + side3;
                p = c / 2;
            }
            else
            {
                Console.WriteLine("不能构成三角形");

            }
        }
        public override void Draw()
        {
            Console.WriteLine("Draw triangle:" + side1 + side2 + side3);
        }

        public override double Area
        { 
             get
            {
                return Math.Sqrt(p* (p - side1) * (p - side2) * (p - side3));
            }
        }
    }
    //圆形
    public class Circle : Shape
    {
        private int myRadius;
        public Circle(int radius, string id) : base(id)
        {
            myRadius = radius;
        }
        public override void Draw()
        {
            Console.WriteLine("Draw Circle:" + myRadius);
        }
        public override double Area
        {
            get
            {
                return myRadius * myRadius * System.Math.PI;
            }
        }
    }
    //正方形
    public class Square : Shape
    {
        private int mySide;
        public Square(int side, string id) : base(id)
        {
            mySide = side;
        }
        public override void Draw()
        {
            Console.WriteLine("Draw Square:" + mySide);
        }
        public override double Area
        {
            get
            {
                return mySide * mySide;
            }
        }
    }
    //长方形
    public class Rectangle : Shape
    {
        private int myWidth;
        private int myHeight;
        public Rectangle(int width,int height, string id) : base(id)
        {
            myWidth = width;
            myHeight = height;
        }
        public override void Draw()
        {
            Console.WriteLine("Draw Rectangle");
        }
        public override double Area
        {
            get
            {
                return myWidth * myHeight;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape triangle = new Triangle(1, 1, 1, "triangle");
            Shape circle = new Circle(1, "circle");
            Shape square = new Square(1, "square");
            Shape rectangle = new Rectangle(1,2, "rectangle");
            Console.WriteLine(triangle.Area);
            Console.WriteLine(circle.Area);
            Console.WriteLine(square.Area);
            Console.WriteLine(rectangle.Area);
        }
    }
}
