using SquareLibrary.Figures;

namespace SquareLibrary.Figures
{
    public class Triangle :Figure
    {
        private float _sideA = 0;
        private float _sideB = 0;
        private float _sideC = 0;
        public float SideA { get { return _sideA; } set { _sideA = value; } }
        public float SideB { get { return _sideB; } set { _sideB = value; } }
        public float SideC { get { return _sideC; } set { _sideC = value; } }
        public Triangle(float sideA, float sideB, float sideC)
        {
            if(SideA < 0 || SideB < 0 || SideC < 0)
            {
                throw new ArgumentException("Значения не могут быть отрицательными");
            }
            if(!IsValidTriangle(sideA, sideB, sideC))
            {
                throw new ArgumentException("Треугольник с такими сторонами не существует.");
            }
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }
        private bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
        public override float CalculateSquare()
        {
            float halfPerimeter = (SideA + SideB + SideC) / 2;
            return (float)Math.Sqrt((double)(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC)));
        }
        public override float CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }
        public override string ToString()
        {
            return $"Фигура - треугольник, длины сторон: {SideA},{SideB},{SideC}. Площадь - {CalculateSquare()}, Периметр - {CalculatePerimeter()}";
        }
    }
}
