using Entitas;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(TestController))]
public class TestControllerEditor: Editor
{
    public override void OnInspectorGUI()
    {
        TestController Script = (TestController)target;

        /* Load Level Inspector Code */
        GUILayout.BeginHorizontal();
        Script.Level = EditorGUILayout.TextField("Level", Script.Level);
        if (GUILayout.Button("Load Level", GUILayout.MaxWidth(90)))
        {
            if (Application.isPlaying)
            {
                if (Pools.sharedInstance.gameboard.count > 0) {
                    Descent.Helper.Occurrence.Level.UnloadLevel();
                }

                Descent.Helper.Occurrence.Level.LoadLevel(Script.Level);
            }
        }

        GUILayout.EndHorizontal();
    }
}