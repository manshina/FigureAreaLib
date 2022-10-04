namespace FigureAreaLib
{
    public abstract class Figure
    {
        //название фигуры
        public string Name { get; }
        //площадь фигуры
        public double Area { get; protected set; }      
        //базовый конструктор с провекой значений
        public Figure(double[] Args, string name)
        {
            Name = name;
            foreach (var value in Args)
            {
                if (!Double.IsNormal(value))
                {
                    throw new ArgumentOutOfRangeException("Value isn't normal (is neither zero, subnormal, infinite, nor NaN)");
                }
                if (Double.IsNegative(value))
                {
                    throw new ArgumentOutOfRangeException("Value cant be negative");
                }
            }
        }
        //метод вывода информации о фигуре
        public string Print()
        {
            return $"{Name}, {Area}";
        }
    }
}