using FiguresLibrary.Extensions;

namespace FiguresLibrary.Figures;

public class Circle : IFigure
{
    private readonly double _radius;

    public Circle(double radius)
    {
        radius.ThrowIfNotPositive();

        _radius = radius;
    }

    public double CalculateArea()
        => Math.PI * Math.Pow(_radius, 2);
}