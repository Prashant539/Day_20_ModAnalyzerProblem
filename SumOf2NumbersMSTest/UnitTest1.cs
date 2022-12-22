
namespace SumOf2NumbersMSTest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly SumOf2NumbersDemo.Program program;
        public UnitTest1()
        {
            program = new SumOf2NumbersDemo.Program();
        }
        [TestMethod]
        public void TestMethod1()
        {
            int valueOne = 5;
            int valueTwo = 10;
            var result = program.Add(valueOne, valueTwo);   
            Assert.AreEqual(15, result);
        }
    }
}