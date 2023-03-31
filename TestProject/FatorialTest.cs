namespace TestProject
{
    [TestClass]
    public class FatorialTest
    {
        [TestMethod]
        public void TesteFatorialDe1()
        {
            Assert.AreEqual(1, Program.Fatorial(1));
        }

        [TestMethod]
        public void TesteFatorialDe5()
        {
            Assert.AreEqual(120, Program.Fatorial(5));
        }

        [TestMethod]
        public void TesteFatorialDe8()
        {
            Assert.AreEqual(40320, Program.Fatorial(8));
        }

        [TestMethod]
        public void TesteFatorialDe10()
        {
            Assert.AreEqual(3628800, Program.Fatorial(10));
        }
    }
}
