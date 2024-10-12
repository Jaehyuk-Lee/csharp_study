class Point3D : Point2D
{
    private int z;
    public int Z
    {
        get
        {
            return this.z;
        }
        set
        {

            this.z = value;
        }
    }

    public Point3D() : this(10, 20, 30)
    {

    }

    public Point3D(int x, int y, int z) : base(x, y)
    {
        this.z = z;
    }

    public new void print()
    {
        base.print();
        Console.WriteLine("z: " + this.z);
    }
}