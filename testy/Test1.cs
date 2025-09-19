using app;
namespace testy
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Nwd_10_5_Returns5()
        {
            int result = Euclid.Nwd(10, 5);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Nwd_18_24_Returns6()
        {
            int result = Euclid.Nwd(18, 24);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Nwd_48_18_Returns6()
        {
            int result = Euclid.Nwd(48, 18);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Nwd_7_13_Returns1()
        {
            int result = Euclid.Nwd(7, 13);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Nwd_0_5_Returns5()
        {
            int result = Euclid.Nwd(0, 5);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Nwd_5_0_Returns5()
        {
            int result = Euclid.Nwd(5, 0);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Nwd_0_0_ThrowsException()
        {
            Euclid.Nwd(0, 0);
        }

        [TestMethod]
        public void Nwd_NegativeValues_ReturnsPositiveGCD()
        {
            int result = Euclid.Nwd(-24, -18);
            Assert.AreEqual(6, result);
        }
    }
}
