using Prototype_AbstractFactory.Shared;

namespace Prototype_AbstractFactory.Test
{
    public interface ITest : IMyCloneable<ITest>
    {
        string GetInfo();
    }
}
