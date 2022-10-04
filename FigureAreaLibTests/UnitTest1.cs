using FigureAreaLib;

namespace FigureAreaLibTests
{
    public class UnitTest1
    {
        [Fact]
        public void TriangleAreaFrom3Sides_4and3and5_6return()
        {
            //arrange
            double a = 4;
            double b = 3;
            double c = 5;
            double expected = 6;

            //act

            double actual = Triangle.AreaFrom3Sides(a, b, c).Area;

            //assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void TriangleAreaFrom3Sides_minus4and3and5_ArgumentOutOfRangeExceptionreturn()
        {
            //arrange
            double a = -4;
            double b = 3;
            double c = 5;


            //act



            //assert

            Assert.Throws<ArgumentOutOfRangeException>(() => Triangle.AreaFrom3Sides(a, b, c));
        }

        [Fact]
        public void TriangleAreaFrom3Sides_minus4and3and0_ArgumentOutOfRangeExceptionreturn()
        {
            //arrange
            double a = -4;
            double b = 3;
            double c = 0;


            //act



            //assert

            Assert.Throws<ArgumentOutOfRangeException>(() => Triangle.AreaFrom3Sides(a, b, c));
        }

        [Fact]
        public void TriangleAreaFrom3Sides_4and3and0_ArgumentOutOfRangeExceptionreturn()
        {
            //arrange
            double a = 4;
            double b = 3;
            double c = 0;


            //act



            //assert

            Assert.Throws<ArgumentOutOfRangeException>(() => Triangle.AreaFrom3Sides(a, b, c));
        }

        [Fact]
        public void TriangleAreaFrom3Sides_1and2and3_exceptionreturn()
        {
            //arrange
            double a = 1;
            double b = 2;
            double c = 3;


            //act



            //assert

            Assert.Throws<Exception>(() => Triangle.AreaFrom3Sides(a, b, c));
        }

        [Fact]
        public void AreaFromRadius_4_50and26548245743669return()
        {
            //arrange
            double radius = 4;
            double expected = 50.26548245743669;

            //act

            double actual = Circle.AreaFromRadius(radius).Area;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AreaFromRadius_minus4_ArgumentOutOfRangeExceptionreturn()
        {
            //arrange
            double radius = -4;



            //act



            //assert

            Assert.Throws<ArgumentOutOfRangeException>(() => Circle.AreaFromRadius(radius));
        }


        [Fact]
        public void AreaFromRadius_0_ArgumentOutOfRangeExceptionreturn()
        {
            //arrange
            double radius = 0;



            //act



            //assert

            Assert.Throws<ArgumentOutOfRangeException>(() => Circle.AreaFromRadius(radius));
        }
    }
}