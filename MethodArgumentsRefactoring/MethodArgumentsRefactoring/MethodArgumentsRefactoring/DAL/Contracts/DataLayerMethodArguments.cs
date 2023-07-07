using Microsoft.VisualBasic;

namespace MethodArgumentsRefactoring.DAL.Contracts;

public record struct DataLayerMethodArguments(int a, int b, DateTime start, DateTime end, string d, byte[] e);