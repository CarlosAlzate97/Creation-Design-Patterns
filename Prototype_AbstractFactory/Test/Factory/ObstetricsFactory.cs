using Prototype_AbstractFactory.Test.Obstetrics;

namespace Prototype_AbstractFactory.Test.Factory
{
    public class ObstetricsFactory : ITestFactory
    {
        public BloodTest CreateBloodTest()
        {
            return new ObstetricsBloodTest();
        }

        public UrineTest CreateUrineTest()
        {
            return new ObstetricsUrineTest();
        }
    }
}
