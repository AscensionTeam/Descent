
using UnityEngine;
using System;
using UnityEngine.Assertions;

namespace Descent.Test
{
    /// <summary>
    /// Test Example3 Class.
    /// </summary>
    public class TestExample3 : ITest
    {
        /// <summary>
        /// Run Method.
        /// </summary>
        public void Run()
        {
            int x = 0;

            int ExpectedValue = 10;

            Assert.AreEqual(ExpectedValue, x);
        }
    }
}
