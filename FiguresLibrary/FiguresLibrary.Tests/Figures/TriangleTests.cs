using FiguresLibrary.Figures;
using FiguresLibrary.Tools;
using NUnit.Framework;

namespace FiguresLibrary.Tests.Figures;

public class TriangleTests
{
    [Test]
    [TestCase(4, 4, 6)]
    [TestCase(5, 3.5, 6)]
    [TestCase(5, 10, 10)]
    public void CalculateArea_EqualsToTriangleArea(double a, double b, double c)
    {
        IFigure triangle = new Triangle(a, b, c);

        double p = (a + b + c) / 2;
        double expected = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        double actual = triangle.CalculateArea();

        Assert.That(actual, Is.EqualTo(expected).Within(1).Percent);
    }

    [Test]
    [TestCase(0, 4, 6)]
    [TestCase(5, -3.5, 6)]
    [TestCase(-5, 10, -10)]
    public void AnyNonPositiveSides_ThrowFiguresLibraryException(double a, double b, double c)
    {
        Assert.Throws<FiguresLibraryException>(() =>
        {
            _ = new Triangle(a, b, c);
        });
    }

    [Test]
    [TestCase(1.3, 2.7, 4)]
    [TestCase(50, 5, 6)]
    [TestCase(10, 500, 100)]
    public void TriangleCannotBeConstructed_ThrowFiguresLibraryException(double a, double b, double c)
    {
        Assert.Throws<FiguresLibraryException>(() =>
        {
            _ = new Triangle(a, b, c);
        });
    }
}