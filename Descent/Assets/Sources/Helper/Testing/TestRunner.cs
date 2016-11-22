using System;
using UnityEngine;

namespace Descent.Test
{
    /// <summary>
    /// Test Runner Class.
    /// </summary>
    public static class TestRunner
    {
        /// <summary>
        /// Run Method.
        /// </summary>
        /// <typeparam name="T">Test.</typeparam>
        public static void Run<T>() where T : ITest
        {
            /* Create Instance. */
            T Test = Activator.CreateInstance<T>();

            try
            {
                /* Run Instance. */
                Test.Run();

                /* Sucess. */
                Debug.Log("[TestRunner] " + Test.ToString() + ": Sucess.");
            }
            catch (Exception Ex)
            {
                /* Fail. */
                Debug.Log("[TestRunner] " + Test.ToString() + ": Fail. \n" + Ex.ToString());
            }
        }
    }
}
