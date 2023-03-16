using System.Runtime.Intrinsics.Arm;

namespace FiguresLibrary;

public class Triangle: IFigure
{
    private double firstSide;
    private double secondSide;
    private double thirdSide;

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        this.firstSide = firstSide;
        this.secondSide = secondSide;
        this.thirdSide = thirdSide;
    }

    public double GetArea()
    {
        double temp = (firstSide + secondSide + thirdSide) / 2;
        return Math.Sqrt(temp * (temp - firstSide) * (temp - secondSide) * (temp - thirdSide));
    }

    public bool IsRightAngled()
    {
        return (Math.Pow(firstSide,2) + Math.Pow(secondSide,2) == Math.Pow(thirdSide,2)) ||
              (Math.Pow(firstSide,2) + Math.Pow(thirdSide,2) == Math.Pow(secondSide,2)) ||
              (Math.Pow(secondSide,2) + Math.Pow(thirdSide,2) == Math.Pow(firstSide,2));
    }
}