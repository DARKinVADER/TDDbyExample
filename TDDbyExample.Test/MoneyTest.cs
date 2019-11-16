using TDDbyExample.Services;
using Xunit;

namespace TDDbyExample.Test
{
    public class MoneyTest
    {
        [Fact]
        public void testMultiplication()
        {
            Money five = Money.Dollar(5);
            Assert.True(Money.Dollar(10).Equals(five.Times(2)));
            Assert.True(Money.Dollar(15).Equals(five.Times(3)));
        }

        [Fact]
        public void TestEquality()
        {
            Assert.True(Money.Dollar(5).Equals(Money.Dollar(5)));
            Assert.False(Money.Dollar(5).Equals(Money.Dollar(6)));
            Assert.True(Money.Franc(5).Equals(Money.Franc(5)));
            Assert.False(Money.Franc(5).Equals(Money.Franc(6)));
            Assert.False(Money.Franc(5).Equals(Money.Dollar(5)));
        }

        [Fact]
        public void testFrancMultiplication()
        {
            Money five = Money.Franc(5);
            Assert.True(Money.Franc(10).Equals(five.Times(2)));
            Assert.True(Money.Franc(15).Equals(five.Times(3)));
        }

    }
}
