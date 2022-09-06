using FiguresLibrary.Extensions;
using FiguresLibrary.Tools;

namespace FiguresLibrary.Figures;

public class Triangle : IFigure
{
    private readonly double _a;
    private readonly double _b;
    private readonly double _c;

    public Triangle(double sideA, double sideB, double sideC)
    {
        sideA.ThrowIfNotPositive();
        sideB.ThrowIfNotPositive();
        sideC.ThrowIfNotPositive();

        if (SidesSumIsLesserThanOther(sideA, sideB, sideC)
            || SidesSumIsLesserThanOther(sideB, sideC, sideA)
            || SidesSumIsLesserThanOther(sideC, sideA, sideB))
            throw new FiguresLibraryException("Invalid sides for triangle");

        _a = sideA;
        _b = sideB;
        _c = sideC;
    }

    public double CalculateArea()
    {
        double p = CalculateSemiPerimeter();

        return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
    }

    private double CalculateSemiPerimeter()
        => (_a + _b + _c) / 2;

    private static bool SidesSumIsLesserThanOther(double a, double b, double c)
        => a + b - c < double.Epsilon;
}