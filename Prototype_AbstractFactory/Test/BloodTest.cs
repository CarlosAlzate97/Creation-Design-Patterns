using Prototype_AbstractFactory.Shared;

namespace Prototype_AbstractFactory.Test
{
    public class BloodTest : ITest
    {
        private readonly string _name;

        public BloodTest()
        {
            _name = "Blood test";
        }

        protected BloodTest(BloodTest test)
        {
            _name = test._name;
        }

        public virtual ITest Clone()
        {
            return new BloodTest(this);
        }

        public virtual string GetInfo()
        {
            return "test name: " + _name;
        }
    }
}