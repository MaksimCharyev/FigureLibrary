namespace SquareLibrary.Figures.Circle
{
    internal class Chorde
    {
        private float _pointAx;
        private float _pointAy;
        private float _pointBx;
        private float _pointBy;
        public float PointAx
        {
            set { _pointAx = value; }
            get { return _pointAx; }
        }
        public float PointAy
        {
            set { _pointAy = value; }
            get { return _pointAy; }
        }
        public float PointBx
        {
            set { _pointBx = value; }
            get { return _pointBx; }
        }
        public float PointBy
        {
            set { _pointBy = value; }
            get { return _pointBy; }
        }
        public Chorde(float Ax, float Ay, float Bx, float By)
        {
            _pointAx = Ax;
            _pointAy = Ay;
            _pointBx = Bx;
            _pointBy = By;
        }
        public override string ToString()
        {
            return $"Хорда с начальной координатой:({PointAx},{PointAy}) и конечной:({PointBx},{PointBy})";
        }
    }
}
