namespace TestProject
{
    [TestClass]
    public class CalculaMediaTest
    {
        [TestMethod]
        public void TestMediaListaVazia()
        {
            var numeros = new List<int>();
            double media = Program.CalculaMedia(numeros);
            Assert.AreEqual(0.0, media);
        }

        [TestMethod]
        public void TestMediaListaUmaPosicao()
        {
            var numeros = new List<int>() { 10 };
            double media = Program.CalculaMedia(numeros);
            Assert.AreEqual(10.0, media);
        }

        [TestMethod]
        public void TestMediaListaDoisValores()
        {
            var numeros = new List<int>() { 10, 20 };
            double media = Program.CalculaMedia(numeros);
            Assert.AreEqual(15.0, media);
        }

        [TestMethod]
        public void TestMediaListaValoresIguais()
        {
            var numeros = new List<int>() { 5, 5, 5, 5, 5 };
            double media = Program.CalculaMedia(numeros);
            Assert.AreEqual(5.0, media);
        }

        [TestMethod]
        public void TestMediaListaValoresNegativos()
        {
            var numeros = new List<int>() { -10, -20, -30 };
            double media = Program.CalculaMedia(numeros);
            Assert.AreEqual(-20.0, media);
        }
    }
}