using System;

using System;

using System.IO;
using System.Reflection;
using System.Collections.Generic;

namespace Training_C_.Builder;

internal class Program
{
    private static void Main(string[] args)
    {
        var director = new Director();
        var construct = director.OrderWithoutMedician(new OrderConcreteBuilder());
    }
}