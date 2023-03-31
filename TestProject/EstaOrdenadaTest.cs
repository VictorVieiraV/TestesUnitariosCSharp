namespace TestProject
{
    [TestClass]
    public class EstaOrdenadaTest
    {
        [TestMethod]
        public void TesteListaVazia()
        {
            List<int> lista = new List<int>();
            Assert.IsTrue(Program.EstaOrdenada(lista));
        }

        [TestMethod]
        public void TesteListaOrdenada()
        {
            List<int> lista = new List<int>() { 1, 2, 3, 4, 5 };
            Assert.IsTrue(Program.EstaOrdenada(lista));
        }

        [TestMethod]
        public void TesteListaDesordenada()
        {
            List<int> lista = new List<int>() { 1, 3, 2, 4, 5 };
            Assert.IsFalse(Program.EstaOrdenada(lista));
        }

        [TestMethod]
        public void TesteListaComElementosRepetidos()
        {
            List<int> lista = new List<int> { 1, 2, 2, 3, 3, 3, 4, 5 };
            Assert.IsTrue(Program.EstaOrdenada(lista));
        }
    }
}
