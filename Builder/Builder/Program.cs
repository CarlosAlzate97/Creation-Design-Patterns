using System;

using System;

using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Training_C_.Builder;

internal class Program
{
    private static void Main(string[] args)
    {
        var director = new Director();
        var orderWithoutMedical = director.OrderWithoutMedician(new OrderConcreteBuilder());
        var orderWithMedical = director.OrderWithtMedician(new OrderConcreteBuilder());


    }
}