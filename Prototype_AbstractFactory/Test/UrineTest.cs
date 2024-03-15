
using Prototype_AbstractFactory.Shared;

namespace Prototype_AbstractFactory.Test
{
    public class UrineTest : ITest
    {
        private readonly string _name;

        public UrineTest()
        {
            _name = "Urine test";
        }
        protected UrineTest(string name)
        {
            _name = name;
        }
        public virtual ITest Clone()
        {
            return new UrineTest(_name);
        }

        public virtual string GetInfo()
        {
            return "test name: " + _name;
        }
    }
}
