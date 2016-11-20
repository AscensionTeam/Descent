using UnityEngine;
using Entitas;

/// <summary>
/// TileBehaviour Class.
/// </summary>
public class TileBehaviour : MonoBehaviour {

    /// <summary>
    /// Start Method.
    /// </summary>
	void Start () {

        /* Get Behaviour Script. */
        var Script = GetComponent<DescentBehaviour>();

        /* Register Callback(s). */
        if (Script != null) {
            Script.OnInitialize += OnInitialize;
        }
	}

    /// <summary>
    /// OnInitialize Method.
    /// </summary>
    /// <param name="Entity">Entity.</param>
    /// <param name="Pool">Pool.</param>
    private void OnInitialize(Entity Entity, Pool Pool)
    {
     
    }
}
