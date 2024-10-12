namespace Shape
{
    class Triangle : Shape
    {
        int w = 10;
        int h = 5;
        public override void Area()
        {
            res = 0.5 * w * h;
        }
    }
}