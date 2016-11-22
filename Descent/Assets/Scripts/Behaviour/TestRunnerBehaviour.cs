using UnityEngine;
using Descent.Test;

/// <summary>
/// Test Runner Behaviour Class.
/// </summary>
public class TestRunnerBehaviour : MonoBehaviour
{
    /// <summary>
    /// Start Method.
    /// </summary>
    void Start()
    {
        TestRunner.Run<TestExample1>();
        TestRunner.Run<TestExample2>();
        TestRunner.Run<TestExample3>();

        // TestRunner.Run<MyOtherTest1>();
        // TestRunner.Run<MyOtherTest2>();
        // TestRunner.Run<MyOtherTest3>();
        // ...
    }
}