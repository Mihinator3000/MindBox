using FiguresLibrary.Figures;
using FiguresLibrary.Tools;
using NUnit.Framework;

namespace FiguresLibrary.Tests.Figures;

public class CircleTests
{
    [Test]
    [TestCase(5)]
    [TestCase(14.5)]
    [TestCase(10e6)]
    public void CalculateArea_EqualsToCircleArea(double radius)
    {
        IFigure circle = new Circle(radius);

        double expected = Math.PI * Math.Pow(radius, 2);
        double actual = circle.CalculateArea();

        Assert.That(actual, Is.EqualTo(expected).Within(1).Percent);
    }

    [Test]
    [TestCase(0)]
    [TestCase(-4.6)]
    public void NonPositiveRadius_ThrowFiguresLibraryException(double radius)
    {
        Assert.Throws<FiguresLibraryException>(() =>
        {
            _ = new Circle(radius);
        });
    }
}