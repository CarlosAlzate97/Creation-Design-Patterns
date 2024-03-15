using Prototype_AbstractFactory.Shared;

namespace Prototype_AbstractFactory.Test.Obstetrics
{
    public class ObstetricsUrineTest: UrineTest
    {
        private readonly string _area;

        public ObstetricsUrineTest()
        {
            _area = "Obstetrics";
        }

        protected ObstetricsUrineTest(ObstetricsUrineTest urineTest)
        {
            this._area = urineTest._area;
        }

        public override ITest Clone()
        {
            return new ObstetricsUrineTest(this);
        }

        public override string GetInfo()
        {
            var info = base.GetInfo();
            return info + "\tarea: " + _area;
        }
    }
}
