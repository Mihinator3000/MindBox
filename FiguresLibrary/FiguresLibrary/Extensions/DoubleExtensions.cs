using FiguresLibrary.Tools;
using System.Runtime.CompilerServices;

namespace FiguresLibrary.Extensions;

public static class DoubleExtensions
{
    public static void ThrowIfNotPositive(this double number, [CallerMemberName]string? name = null)
    {
        if (number < double.Epsilon)
            throw new FiguresLibraryException($"{name} can not be less than zero");
    }
}