using System;
using NUnit.Framework;
using IDEducation.Utils;
using System.Threading;

namespace IDEducation.UnitTests
{
    [TestFixture]
    public class DbUtilsTest
    {
        [Test]
        public void TestCreateGuidComb()
        {
            var x = 10;
            var y = 195;

            x = x ^ y;
            y = x ^ y;
            x = x ^ y;
        }
    }
}
