using UnityEngine;
using System.Collections;

public class ChangeToScene : MonoBehaviour {


	
	// Update is called once per frame
	public void ChangeScene()
    {
        Application.LoadLevel("UI_FIRST");
	}
}
