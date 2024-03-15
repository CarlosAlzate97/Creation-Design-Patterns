using Prototype_AbstractFactory.Shared;

namespace Prototype_AbstractFactory.Test.Toxicology
{
    public class ToxicologyBloodTest: BloodTest
    {
        private readonly string _area;
        public ToxicologyBloodTest()
        {
            _area = "Toxicology";
        }

        protected ToxicologyBloodTest(ToxicologyBloodTest bloodTest):base(bloodTest)
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
            return new ToxicologyBloodTest(this);
        }
    }
}
