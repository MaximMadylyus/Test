using NUnit.Framework;
using TestApplication1;
using TestApplication1.Fold;

namespace TestApplication1Tests
{
    [TestFixture]
    public class Class1Test
    {
        [Test]
        public void ControlTest()
        {
            Assert.AreNotEqual(null, new Class1().SomeControl);
        }

    }
}
