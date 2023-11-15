namespace MiniPriceApp.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCalculerPrixFutur()
        {
            var miniPrix = new MiniPrice
            {
                PrixInitial = 100,
                Taux = 0.1,
                Jour = new DateTime(2023, 11, 12)

            };
            var prixFuture = miniPrix.CalculerPrixFutur(miniPrix);

            Assert.AreEqual(121,prixFuture);
        }
    }
}
