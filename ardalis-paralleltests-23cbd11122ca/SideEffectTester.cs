using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParallelTests
{
    public class Foo
    {
        public Foo() : this("Default Name")
        {

        }

        public Foo(string Name)
        {
            this.Name = Name;
        }

        public string Name { get; set; }
    }

    [TestClass]
    public class SideEffectTester
    {
        private static Foo _foo;

        [ClassInitialize]
        public static void SetUp(TestContext context)
        {
            _foo = new Foo();
        }

        [TestMethod]
        public void FooNameShouldDefaultToDefaultName()
        {
            Thread.Sleep(100);
            Assert.AreEqual("Default Name", _foo.Name);
        }

        [TestMethod]
        public void FooNameShouldShowNewValueOnceSet()
        {
            _foo.Name = "New Name";
            Thread.Sleep(100);
            Assert.AreEqual("New Name", _foo.Name);
        }
    }
}