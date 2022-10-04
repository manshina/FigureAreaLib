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
        //конструктор
        private Circle(double[] Args, string name) : base(Args, name)
        {

        }
        //статический фабричный метод
        public static Circle AreaFromRadius(double radius, string name = "Circle")
        {
            //полученные значения передаем в базовый конструктор для проверки 
            double[] args = { radius };
            //создаем круг
            Circle circle = new(args, name)
            {
                Radius = radius
            };
            //площадь круга
            circle.Area = Math.PI * Math.Pow(radius, 2);
            return circle;
        }

        //пример другого варианта нахождения площади через длину окружности
        public static Circle AreaFromLenght(double lenght, string name = "Circle")
        {
            double[] args = { lenght };
            Circle circle = new(args, name)
            {
                Lenght = lenght
            };
            circle.Area = Math.Pow(lenght, 2) / (4 * Math.PI);
            return circle;
        }

    }
}
