namespace TestProject
{
    [TestClass]
    public class ConverteTemperaturaTest
    {
        [TestMethod]
        public void TesteConverteZeroCelsiusParaFahrenheit()
        {
            Assert.AreEqual(32, Program.ConverteTemperatura(0));
        }

        [TestMethod]
        public void TesteConverteVinteCelsiusParaFahrenheit()
        {
            Assert.AreEqual(68, Program.ConverteTemperatura(20));
        }

        [TestMethod]
        public void TesteConverteTrintaECincoCelsiusParaFahrenheit()
        {
            Assert.AreEqual(95, Program.ConverteTemperatura(35));
        }

        [TestMethod]
        public void TesteConverteDuzentosCelsiusNegativosParaFahrenheit()
        {
            Assert.AreEqual(-328, Program.ConverteTemperatura(-200));
        }
    }
}
