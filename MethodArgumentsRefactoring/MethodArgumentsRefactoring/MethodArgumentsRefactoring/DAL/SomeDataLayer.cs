using MethodArgumentsRefactoring.DAL.Contracts;

namespace MethodArgumentsRefactoring.DAL;

internal sealed class SomeDataLayer : ISomeDataLayer
{
    public void SomeMethod(DataLayerMethodArguments arguments)
    {
        Console.WriteLine(arguments);
    }
}