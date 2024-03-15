using Prototype_AbstractFactory.Shared;

namespace Prototype_AbstractFactory.Test.Obstetrics
{
    public class ObstetricsBloodTest : BloodTest
    {
        private readonly string _area;
        public ObstetricsBloodTest()
        {
            _area = "Obstetrics";
        }

        protected ObstetricsBloodTest(ObstetricsBloodTest bloodTest):base(bloodTest)
        {
           this._area = bloodTest._area;
        }

        public override string GetInfo()
        {
            var info = base.GetInfo();
            return info + "\tarea: " + _area;
        }

        public override ITest Clone()
        {
            return new ObstetricsBloodTest(this);
        }
    }
}