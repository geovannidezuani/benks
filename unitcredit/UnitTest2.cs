using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace unitcredit
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void credit_WithValidAmount_UpdateBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double creditAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Brenda", beginningBalance);
            // Act
            account.Debit(creditAmount);
            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, account, "Crédito não ocorreu corretamente.");

        }
    }
}
