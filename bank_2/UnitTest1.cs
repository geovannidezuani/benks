using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank;


namespace bank_2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
       
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Geovanni", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Débito não ocorreu corretamente.");
        }




        [TestMethod]
        public void debit_whenAmountIslessThanZero_ShouldThrowArgumentOutofRanger()
        {
            double beginniBalace = 11.99;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("Well", beginniBalace);
            // act and assert 
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));

        }


        //credit


        [TestMethod]
        public void credit_WithValidAmount_UpdateBalance()
            {
                // Arrange
                double beginningBalance = 140.00;
                double creditAmount = 20.00;
                double expected = 160.00;
                BankAccount account = new BankAccount("Geovanni", beginningBalance);

                // Act
                account.Credit(creditAmount);

                // Assert
                double actual = account.Balance;
                Assert.AreEqual(expected, actual, "Credito não ocorreu corretamente.");
            }


        [TestMethod]
        public void credit_whenAmountIslessThanZero_ShouldThrowArgumentOutofRanger()
        {
            double beginniBalace = 11.99;
            double creditAmount = 100.00;
            BankAccount account = new BankAccount("Well", beginniBalace);
            // act and assert 
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Credit(creditAmount));

        }




    }

    }
    

