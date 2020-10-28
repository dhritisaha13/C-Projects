using BankyStuffLibrary;
using System;
using Xunit;
using Xunit.Sdk;

namespace BankingTests
{
    public class UnitTest1
    {
        [Fact]
        public void TrueIsTrue()
        {
            Assert.True(true);
        }

        [Fact]
        public void CantTakeMoreThanYouHave()
        {
            var account = new BankAccount("Dhriti", 10000);
            Assert.Throws<InvalidOperationException>(
                    ()=> account.MakeWithdrawal(75000,
                            DateTime.Now,
                            "Attempt to overdraw")

                );
        }

        [Fact]
        public void NeedMoneyToStart()
        {
            Assert.Throws<ArgumentOutOfRangeException>(

                ()=> new BankAccount("Invalid", -55)
                );
        }
    }
}
