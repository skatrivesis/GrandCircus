using System;
using Xunit;
using Lab4_3;

namespace TDD
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 5)]
        [InlineData(4, 7)]
        [InlineData(5, 11)]
        [InlineData(6, 13)]
        [InlineData(7, 17)]
        [InlineData(8, 19)]
        [InlineData(9, 23)]
        [InlineData(10, 29)]
        public void GeneratePrime(int a, int expected)
        {
            int actual = PrimeNumbers.GeneratePRime(a);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1,0)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(5, 3)]
        [InlineData(7, 4)]
        [InlineData(11, 5)]
        [InlineData(13, 6)]
        [InlineData(17, 7)]
        [InlineData(19, 8)]
        [InlineData(23, 9)]
        [InlineData(29, 10)]
        [InlineData(31, 11)]
        [InlineData(4, 0)]
        [InlineData(20, 0)]
        public void IndexOfTrue(int a, int expected)
        {
            int actual = PrimeNumbers.PrimeIndex(a);

            Assert.Equal(expected, actual);
        }

        //I know I have a lot of test cases here, but I was making a new [Fact] test case as I was
        //Itterating. I kept them just to show my though process.

        //I used the tests below to make sure I could get prime numbers, then I moved over to returning the prime number
        //parameter. I had to change the return type from bool to int. Keeping these in comments to show my work.
        [Fact]
        public void Two()
        {
            int a = 2;
            bool result = PrimeNumbers.CheckPrime(a);

            Assert.True(result);
        }

        [Fact]
        public void Three()
        {
            int a = 3;
            bool result = PrimeNumbers.CheckPrime(a);

            Assert.True(result);
        }

        [Fact]
        public void Nine()
        {
            int a = 9;
            bool result = PrimeNumbers.CheckPrime(a);

            Assert.False(result);
        }
        [Fact]
        public void NintySeven()
        {
            int a = 97;
            bool result = PrimeNumbers.CheckPrime(a);

            Assert.True(result);
        }
        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(11)]
        [InlineData(13)]
        [InlineData(17)]
        [InlineData(19)]
        public void PrimesUpTo20(int a)
        {
            Assert.True(PrimeNumbers.CheckPrime(a));
        }


    }
}
