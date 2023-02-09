using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaLib
{
    public class Circle : Figure
    {
        //радиус
        public double Radius { get; set; }
        //длина окружности
        public double Lenght { get; set; }
        public override double Area { get; protected set; }

        //конструктор
        private Circle(double[] Args) : base(Args)
        {

        }
        //создание руга с радиусом
        public static Circle CircleWithRadius(double radius)
        {
            //полученные значения передаем в базовый конструктор для проверки 
            double[] args = { radius };
            //создаем круг
            Circle circle = new(args)
            {
                Radius = radius
            };                   
            return circle;
        }

        //создание руга с длинной
        public static Circle CircleWitmLenght(double lenght)
        {
            double[] args = { lenght };
            Circle circle = new(args)
            {
                Lenght = lenght
            };           
            return circle;
        }

        //вычислить площадь круга
        public override double GetArea()
        {
            //по радиусу
            if(Radius != 0)
            {
                Area = Math.PI * Math.Pow(Radius, 2);
            }
            //по длинне
            else if(Lenght != 0)
            {
                Area = Math.Pow(Lenght, 2) / (4 * Math.PI);
            }
            

            return Area;
        }
    }
}
