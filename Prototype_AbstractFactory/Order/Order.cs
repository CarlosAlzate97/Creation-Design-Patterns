using Prototype_AbstractFactory.Shared;
using Prototype_AbstractFactory.Test;

namespace Prototype_AbstractFactory.Order
{
    public class Order : IMyCloneable<Order>
    {
        private readonly string _patientName;
        private IList<ITest> _tests;

        public Order(string patientName)
        {
            _tests = [];
            _patientName = patientName;
        }

        public Order(Order order) : this(order._patientName)
        {
            foreach (ITest test in order._tests)
                AddTest(test.Clone());
        }

        public void AddTest(ITest test)
        {
            _tests.Add(test);
        }

        public Order Clone()
        {
            return new Order(this);
        }

        public void PrintInfo()
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("Patien name: " + _patientName);
            Console.WriteLine("Information about tests:");

            foreach (ITest test in _tests)
                Console.WriteLine(test.GetInfo());

            Console.WriteLine("===========================================");
        }
    }
}