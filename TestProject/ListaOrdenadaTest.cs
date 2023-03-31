namespace TestProject
{
    [TestClass]
    public class ListaOrdenadaTest
    {

        [TestMethod]
        public void TesteListaVazia()
        {
            List<int> numeros = new List<int>();
            Assert.AreEqual(true, Program.ListaOrdenada(numeros));
        }

        [TestMethod]
        public void TesteListaCrescente()
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
            Assert.AreEqual(true, Program.ListaOrdenada(numeros));
        }

        [TestMethod]
        public void TesteListaDecrescente()
        {
            List<int> numeros = new List<int> { 5, 4, 3, 2, 1 };
            Assert.AreEqual(true, Program.ListaOrdenada(numeros));
        }

        [TestMethod]
        public void TesteListaNaoOrdenada()
        {
            List<int> numeros = new List<int> { 3, 5, 1, 4, 2 };
            Assert.AreEqual(false, Program.ListaOrdenada(numeros));
        }
    }
}
