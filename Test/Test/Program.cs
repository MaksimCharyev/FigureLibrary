using SquareLibrary;
using SquareLibrary.Figures;
using SquareLibrary.Figures.Circle;

namespace Test.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Triangle triangle = new Triangle(5, 10, 12);
            ConsoleWriter<Circle> consoleCircleWriter = new ConsoleWriter<Circle>(circle);
            consoleCircleWriter.Write();
            ConsoleWriter<Triangle> consoleTriangleWriter = new ConsoleWriter<Triangle>(triangle);
            consoleTriangleWriter.Write();
            circle.SetChorde(1, 2, 3, 4);
            consoleCircleWriter.Write();
        }
    }
}