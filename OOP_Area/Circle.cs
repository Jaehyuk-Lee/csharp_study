namespace Shape
{
    class Circle : Shape, IShape
    {
        int r = 5;
        public override void Area()
        {
            res = 3.14 * r * r;
        }
    }
}