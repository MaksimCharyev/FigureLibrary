using System.Text;
namespace SquareLibrary.Figures.Circle
{
    public class Circle : Figure
    {
        private float _radius;
        private Chorde[] _chordes;
        private int NumberOfChorde=0;
        public void SetChorde(float Ax, float Ay, float Bx, float By)
        {
            Chorde chorde = new Chorde(Ax, Ay, Bx, By);
            _chordes[NumberOfChorde] = chorde;
            NumberOfChorde++;
        }
        public string GetChordes()
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i<_chordes.Length; i++)
            {
                if (_chordes[i] != null)
                {
                    sb.Append(_chordes[i].ToString());
                    sb.Append("; ");
                }
            }
            if (sb.Length > 0)
            {
                return sb.ToString();
            }
            else
                return "Хорд нет";
            
        }
        public float Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
        public Circle(float radius)
        {
            if(radius < 0)
            {
                throw new ArgumentException("Значение не может быть отрицательным.");
            }
            
            Radius = radius;
            _chordes = new Chorde[10];
        }
        public override float CalculateSquare()
        {
            return (float)(Math.PI * Radius * Radius);
        }
        public override float CalculatePerimeter()
        {
            return (float)(2*Math.PI * Radius);
        }
        public override string ToString()
        {
            return $"Фигура - круг, длина радиуса:{Radius}, хорды: {GetChordes()} Площадь - {CalculateSquare()}, Периметр - {CalculatePerimeter()}";
        }
    }
}
