using Prototype_AbstractFactory.Shared;

namespace Prototype_AbstractFactory.Test.Toxicology
{
    public class ToxicologyUrineTest: UrineTest
    {
        private readonly string _area;

        public ToxicologyUrineTest()
        {
            _area = "Toxicology";
        }

        protected ToxicologyUrineTest(ToxicologyUrineTest urineTest)
        {
            this._area = urineTest._area;
        }

        public override ITest Clone()
        {
            return new ToxicologyUrineTest(this);
        }

        public override string GetInfo()
        {
            var info = base.GetInfo();
            return info + "\tarea: " + _area;
        }

    }
}
