namespace TestProject
{
    [TestClass]
    public class EPrimoTest
    {
        [TestMethod]
        public void TesteEPrimoParaNumeroPequeno()
        {
            Assert.AreEqual(true, Program.EPrimo(7));
        }

        [TestMethod]
        public void TesteEPrimoParaNumeroGrande()
        {
            Assert.AreEqual(false, Program.EPrimo(100000));
        }

        [TestMethod]
        public void TesteEPrimoParaNumeroComposto()
        {
            Assert.AreEqual(false, Program.EPrimo(15));
        }

        [TestMethod]
        public void TesteEPrimoParaNumeroNegativo()
        {
            Assert.AreEqual(false, Program.EPrimo(-15));
        }
    }
}
