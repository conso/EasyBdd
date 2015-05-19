using System;
using NUnit.Framework;

namespace EasyBdd
{
    public abstract class BddSpecification 
    {
        [TestFixtureSetUp]
        public void TestFixtureSetup()
        {
            BeforeAll();
        }

        [SetUp]
        public void Setup()
        {
            Before();
        }

        protected virtual void BeforeAll()
        {
        }

        protected virtual void Before()
        {
        }

        public void Given(Action action)
        {
            action.Invoke();
        }

        public void When(Action action)
        {
            action.Invoke();
        }

        public void Then(Action action)
        {
            action.Invoke();
        }

        public void And(Action action)
        {
            action.Invoke();
        }

        [TearDown]
        public void TearDown()
        {
            After();
        }

        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {
            AfterAll();
        }

        protected virtual void After()
        {

        }

        protected virtual void AfterAll()
        {
        }
    }
}
