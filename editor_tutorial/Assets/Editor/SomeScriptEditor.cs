using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(SomeScript))]
public class SomeScriptEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector(); // display the default inspector since we only want to add to it.

        EditorGUILayout.HelpBox("This is a help box", MessageType.Info);
    }
}