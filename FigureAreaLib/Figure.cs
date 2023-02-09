namespace FigureAreaLib
{
    public abstract class Figure
    {
        
        //площадь фигуры
        public abstract double Area { get; protected set; }
        //базовый конструктор с провекой значений
        public Figure(double[] Args)
        {
            
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
        //вычисление площади
       
        public abstract double GetArea();

    }
}