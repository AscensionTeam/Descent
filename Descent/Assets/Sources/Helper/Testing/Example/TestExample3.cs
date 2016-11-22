
using UnityEngine;
using System;
using NUnit.Framework;

namespace Descent.Test
{
    /// <summary>
    /// Test Example3 Class.
    /// </summary>
    [TestFixture]
    public class TestExample3 : ITest
    {
        /// <summary>
        /// Run Method.
        /// </summary>
        [Test]
        public void Run()
        {
            int x = 0;

            int ExpectedValue = 10;

            Assert.AreEqual(ExpectedValue, x);
        }
    }
}
