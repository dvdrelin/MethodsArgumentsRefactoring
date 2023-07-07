
using MethodArgumentsRefactoring.BL.Contracts;
using MethodArgumentsRefactoring.DAL;
using MethodArgumentsRefactoring.DAL.Contracts;

namespace MethodArgumentsRefactoring.BL;

internal sealed class SomeBusinessLayer : ISomeBusinessLayer
{
    public void SomeMethod(SomeMethodArguments arguments)
    {
        ValidateArguments(arguments);

        var dataLayerArguments = new DataLayerMethodArguments(
            100, 
            arguments.b, 
            arguments.DateRange.Start, 
            arguments.DateRange.End, 
            arguments.d, 
            arguments.e);

        new SomeDataLayer().SomeMethod(dataLayerArguments);
    }

    private static void ValidateArguments(SomeMethodArguments arguments)
    {
        if (arguments.DateRange.Start > arguments.DateRange.End)
        {
            throw new ArgumentException("Bull shit in dates))");
        }
    }
}

 