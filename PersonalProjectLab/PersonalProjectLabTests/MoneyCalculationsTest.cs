using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalProjectLab;
namespace PersonalProjectLabTests
{
    [TestClass]
    public class MoneyCalculationsTest
    {
        [TestMethod]
        public void MoneyCalculations_CalculationDivisionOfCheck()
        {
            //Arange
            MoneyCalculations Numbers = new MoneyCalculations();
            //Acting
            decimal DOC = Numbers.CalculatesDivisionOfCost(8, 64);

            //Asserting
            Assert.AreEqual(8, DOC);
        }
        [TestMethod]
        public void moneycalculations_CalculatesTipAmount()
        {
            MoneyCalculations TipAmount = new MoneyCalculations();
            decimal Tip = TipAmount.CalculatesTipAmount(20, "5");

            Assert.AreEqual(6, Tip);
        }
    }
}
