using PhoneNumberAnalysis1;
namespace PhoneNumberAnalysis1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var (nyCode, isFake, lastDigits) = PhoneNumber.Analyze("631-555-1234");

            Assert.AreEqual(nyCode, false);
            Assert.AreEqual(isFake, true);
            Assert.AreEqual(lastDigits, "1234");
        }

        [TestMethod]
        public void TestMethod2()
        {
            var isFake = PhoneNumber.isFake(PhoneNumber.Analyze("631-555-1234"));

            
            Assert.AreEqual(isFake, true);
           
        }
    }
}