using Prototype_AbstractFactory.Test;
using Prototype_AbstractFactory.Test.Factory;
using Prototype_AbstractFactory.Order;

namespace Program
{
    public enum Area
    {
        OBSTETRICS,
        TOXICOLOGY
    }

    public class Example
    {
        public static void Main()
        {
             string PATIENT_NAME = "Pepito Pérez";
            
            var factory = GetFactory(Area.TOXICOLOGY);
            Order order = new Order(PATIENT_NAME);
            order.AddTest(factory.CreateUrineTest());
            order.AddTest(factory.CreateBloodTest());
            
            var temporalOrder = order.Clone();
            factory = GetFactory(Area.OBSTETRICS);
            temporalOrder.AddTest(factory.CreateBloodTest());
            temporalOrder.AddTest(factory.CreateUrineTest());

            Console.WriteLine("Original Order:");
            order.PrintInfo();
            Console.WriteLine("\nTemporal Order:");
            temporalOrder.PrintInfo();

            Console.WriteLine("moving temporal order to order after some validation...");
            order = temporalOrder;
            order.PrintInfo();
            
        }

        public static ITestFactory GetFactory(Area area)
        {
            if (area == Area.OBSTETRICS)
                return new ObstetricsFactory();
            else
                return new ToxicologyFactory();
        }
    }
}