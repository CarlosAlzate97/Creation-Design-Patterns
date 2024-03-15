namespace Prototype_AbstractFactory.Test.Factory
{
    public interface ITestFactory
    {
        BloodTest CreateBloodTest();
        UrineTest CreateUrineTest();
    }
}
