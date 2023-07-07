



using MethodArgumentsRefactoring.BL;
using MethodArgumentsRefactoring.BL.Contracts;

var b=-1;
var c = new DateRange(DateTime.MinValue, DateTime.MaxValue);
var d=string.Empty;
byte[] e = {};
var f = "hi dude";


new SomeBusinessLayer()
    .SomeMethod(new (b, c, d, e, f));