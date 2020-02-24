using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
           
            Assert.IsNotEmpty(Program.Prefix("Hello"));
        }

        [Test]
        public void IsNull()
        {
            object nada = null;

            // Classic syntax
            Assert.IsNull(nada);

            // Constraint Syntax
            //Assert.That(nada, Is.Null);
        }

          [Test]
        public void Test2()
        {
           
            Assert.IsNotEmpty(Program.Prefix("4"));
        }

          [Test]
        public void Test3()
        {
           
            Assert.IsNotEmpty(Program.Prefix("what ... did you say??")); 
        }


        

        

    }
}