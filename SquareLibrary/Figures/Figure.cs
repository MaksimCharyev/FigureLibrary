namespace SquareLibrary.Figures
{
    public abstract class Figure
    {
        private float _square;
        private float _perimeter;
        public float Square
        {
            get { return _square; }
            set { if(_square > 0) _square = value; 
                else {throw new ArgumentException("Значение не может быть отрицательным.", nameof(value));}
            }
        }
        public float Perimeter
        {
            get { return _perimeter; }
            set { if(_perimeter > 0) _perimeter = value;
            else { throw new ArgumentException("Значение не может быть отрицательным.",nameof(value));}
            }
        }
        public abstract float CalculateSquare();
        public abstract float CalculatePerimeter();
    }
}
