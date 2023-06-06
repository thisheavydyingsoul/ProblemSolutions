namespace ProblemSolutionLibrary;
public abstract class Figure
{
    public abstract double Square();
}
public class Circle : Figure
{
    public Circle(double radius) => Radius = radius; 
       
    public double Radius { get;}
    public override double Square()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

public class Triangle : Figure
{
    public Triangle(double[] sides)
    {
        Array.Sort(sides);
        A = sides[0];
        B = sides[1];
        C = sides[2];
    }
    public double A { get; }
    public double B { get; }
    public double C { get; }
    public override double Square()
    {
        double halfPerimeter = (A+B+C)/2;
        return Math.Sqrt(halfPerimeter*(halfPerimeter - A)*(halfPerimeter - B)*(halfPerimeter-C));
    }

    public bool isRectangular() { return A * A + B * B == C * C; }
}
