namespace Shape
{
    class Rectangle : Shape
    {
        int w = 10;
        int h = 5;
        public override void Area()
        {
            res = w * h;
        }
    }
}