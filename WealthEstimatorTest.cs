using Microsoft.VisualStudio.TestTools.UnitTesting;
using TEGFI_3;

namespace ExpensesTests
{
    [TestClass]
    public class WealthEstimatorTest
    {
        [TestMethod]
        public void CheckAmountsInWealthEstimator()
        {
            //Arrange
            double inputAmount = 100.0;
            double expectedOneTimeAmount = 201.0;
            double expectedMonthylAmount = 17308.0;

            //Act
            double actualAmount_OneTime = WealthEstimator.EstimateTenYearsAmount_OneTime(inputAmount);
            double actualAmount_Monthly = WealthEstimator.EstimateTenYearsAmount_Monthly(inputAmount);

            //Assert
            Assert.AreEqual(expectedOneTimeAmount, actualAmount_OneTime, 0.9, "Wrong amount for one time calculations");
            Assert.AreEqual(expectedMonthylAmount, actualAmount_Monthly, 0.9, "Wrong amount for monthly calculations");
        }

    
    }
}
