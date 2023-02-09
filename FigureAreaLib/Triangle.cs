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

        public double H { get; private set; }
        //является ли прямоугольным
        public bool IsRight { get; private set; }

        

        public override double Area { get; protected set; }

        //конструктор
        private Triangle(double[] args) : base(args)
        {
           

        }
        //создание треугольника с 3 сторонами
        public static Triangle CreateWith3Sides(double a, double b, double c)
        {
            double[] args = { a, b, c };
            //создаем треугольник
            Triangle triangle = new(args)
            {
                A = a,
                B = b,
                C = c
            };
            return triangle;
        }
        //создание тругольника со стороной и высотой
        public static Triangle CreateWithSideAndHeight(double a, double h)
        {
            double[] args = { a, h};
            //создаем треугольник
            Triangle triangle = new(args)
            {
                A = a,                
                H = h
            };
            return triangle;
        }

        //вычисление площади
        public override double GetArea()
        {
            //по высоте и стороне
            if(H != 0)
            {
                Area = A * H / 2 ;
            }
            //по 3 сторонам
            else if(A != 0 && B !=0 && C!=0)
            {
                //полупериметр
                double semPer = (A + B + C) / 2;
                //выражение под корнем для последующей проверки на существование треугольника 
                double toSqrt = semPer * (semPer - A) * (semPer - B) * (semPer - C);
                //проверка на возможность существования треугольника
                if (toSqrt <= 0)
                {
                    throw new Exception("No such triangle exists");
                }
                //площадь треугольника
                Area = Math.Sqrt(toSqrt);
                //проверка на прямоугльный треугольник
                if ((A * A + B * B == C * C) || (A * A + C * C == B * B) || (C * C + B * B == A * A))
                {
                    IsRight = true;
                }
                else
                {
                    IsRight = false;
                }
            }
                      
            return Area;
        }
    }
}
