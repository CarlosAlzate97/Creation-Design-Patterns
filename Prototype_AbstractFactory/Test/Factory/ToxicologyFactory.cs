using Prototype_AbstractFactory.Test.Toxicology;

namespace Prototype_AbstractFactory.Test.Factory
{
    public class ToxicologyFactory : ITestFactory
    {
        public BloodTest CreateBloodTest()
        {
            return new ToxicologyBloodTest();
        }

        public UrineTest CreateUrineTest()
        {
            return new ToxicologyUrineTest();
        }
    }
}
