class Point2D
{
    private int x { get; set; }
    private int y { get; set; }

    public Point2D() : this(10, 20)
    {

    }
    public Point2D(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void setX(int x)
    {
        this.x = x;
    }

    public int getX()
    {
        return this.x;
    }

    public void setY(int y)
    {
        this.y = y;
    }

    public int getY()
    {
        return this.y;
    }

    public virtual void print()
    {
        Console.WriteLine("x: " + this.x);
        Console.WriteLine("y: " + this.y);
    }
}