using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank;

namespace bank_2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void debit_withvalidAmount_UpdateBalance()
        {
            // arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("weil", beginningBalance);
            // act
            account.debit(debitAmount);

            // assert 
            double actual = account.Balance;

        }
    }
}
