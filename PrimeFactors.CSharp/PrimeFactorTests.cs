using System.Collections.Generic;
using Xunit;

namespace PrimeFactors.CSharp
{
    public class PrimeFactorTests
    {
        [Fact]
        public void TestOne()
        {
            Assert.Equal(new List<int>(), PrimeFactor.Generate(1));
        }
    }
}
