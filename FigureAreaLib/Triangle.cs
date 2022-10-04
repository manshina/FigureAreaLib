using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaLib
{
    public class Triangle : Figure
    {
        //сторона а
        public double A { get; private set; }
        //сторона б
        public double B { get; private set; }
        //сторона с
        public double C { get; private set; }
        //является ли прямоугольным
        public bool IsRight { get; private set; }
        //конструктор
        private Triangle(double[] Args, string name) : base(Args, name)
        {

        }
        //статический фабричный метод
        public static Triangle AreaFrom3Sides(double a, double b, double c, string name = "Triangle")
        {
            //полученные значения передаем в базовый конструктор для проверки 
            double[] args = { a, b, c };
            //создаем треугольник
            Triangle triangle = new(args, name)
            {
                A = a,
                B = b,
                C = c
            };
            //полупериметр
            double semPer = (a + b + c) / 2;
            //выражение под корнем для последующей проверки на существование треугольника 
            double toSqrt = semPer * (semPer - a) * (semPer - b) * (semPer - c);
            //проверка на возможность существования треугольника
            if (toSqrt <= 0)
            {
                throw new Exception("No such triangle exists");
            }
            //площадь треугольника
            triangle.Area = Math.Sqrt(toSqrt);
            //проверка на прямоугльный треугольник
            if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a))
            {
                triangle.IsRight = true;
            }
            else
            {
                triangle.IsRight = false;
            }

            return triangle;
        }

    }
}
