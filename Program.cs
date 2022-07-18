public abstract class GeomettriObject
{
    protected string color;
    protected double weight;
    // Default construct
    protected GeotricOblect()
    {
        color = "white";
        weight = 1.0;
    }
    // Contruct a geometric object
    protected GeomettriObject(string color, double weight)
    {
        this.color = color;
        this.weight = weight;
    }
    //properties
    publicstring PColor
    {
        get { return color; }
        set { color = value; }
    }
    public double PWeight
    {
        get { return weight; }
        set { weight = value; }
    }
    // Abtract method 
    public abstract double findArea();
    // Abtract method
    public abstract double findPerimeter();
}
