namespace _07_Interfaces_Homework_21._12._2022
{
 /*1. Написать иерархию классов «Фигуры».
Фигура -> Треугольник -> Прямоугольник -> Круг.
Реализовать ф-ю подсчета площади для каждого типа фигуры и подсчет
периметра.
Создать массив из 5 фигур.
Вывести на экран сумму периметра всех фигур в массиве.
*/
    internal class Program
    {
        public interface IShape
        {
            double GetPerimeter();
            double GetArea();
            string GetShapeName();
            string GetFullShapeInfo ();
        }

        public class Triangle : IShape
        {
            double a_side;
            double b_side;
            double c_side;
            public Triangle(double a, double b, double c)
            {
                a_side = a;
                b_side = b;
                c_side = c;
            }

            public double GetPerimeter()
            {
                return a_side + b_side + c_side;
            }
            // Used Heron's formula to get area
            public double GetArea()
            {
                double s = GetPerimeter() / 2;
                return Math.Sqrt(s * (s - a_side) * (s - b_side) * (s - c_side));
            }

            public string GetShapeName()
            {
                return "Triangle";
            }

            public string GetFullShapeInfo()
            {
                return ($"{GetShapeName()}\nSides: {a_side}, {b_side}, {c_side}\nPerimeter = {GetPerimeter()}\nArea = {GetArea()}");
            }

        }
        public class Rectangle : IShape
        {
            double a_side;
            double b_side;

            public Rectangle(double a, double b)
            {
                a_side = a;
                b_side = b;
            }

            public double GetPerimeter()
            {
                return (a_side + b_side) * 2;
            }
            public double GetArea()
            {
                return a_side * b_side;
            }

            public string GetShapeName()
            {
                return "Rectangle";
            }

            public string GetFullShapeInfo()
            {
                return ($"{GetShapeName()}\nSides: {a_side}, {b_side}\nPerimeter = {GetPerimeter()}\nArea = {GetArea()}");
            }
        }
        public class Circle : IShape
        {
            double radius;

            public Circle(double r)
            {
                radius = r;
            }

            public double GetPerimeter()
            {
                return 2 * Math.PI * radius;
            }

            public double GetArea()
            {
                return Math.PI * radius * radius;
            }

            public string GetShapeName()
            {
                return "Circle";
            }

            public string GetFullShapeInfo()
            {
                return ($"{GetShapeName()}\nRadius: {radius}\nPerimeter = {GetPerimeter()}\nArea = {GetArea()}");
            }
        }
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3, 5, 7);
            Rectangle rectangle = new Rectangle(10, 20);
            Circle circle = new Circle(10);
            Circle circle2 = new Circle(20);
            Rectangle rectangle2 = new Rectangle(40, 80);
            Triangle triangle2 = new Triangle(4, 6, 8);

            List <IShape> shapes = new List<IShape>() {triangle, rectangle, circle, circle2, rectangle2, triangle2 };

            for (int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine(shapes[i].GetFullShapeInfo());
                Console.WriteLine();
            }


        }
    }
}