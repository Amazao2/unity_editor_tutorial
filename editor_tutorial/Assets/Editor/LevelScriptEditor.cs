using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(LevelScript))] // attribute to tell it what script we are customizing
public class LevelScriptEditor : Editor
{
    public override void OnInspectorGUI() // called every time the inspector is drawn
    {
        LevelScript myTarget = (LevelScript)target; // cast the target (the script we are overriding) to type LevelScript

        myTarget.experience = EditorGUILayout.IntField("Experience", myTarget.experience); // create an integer field named Experience which writes to the experience variable
        EditorGUILayout.LabelField("Level", myTarget.Level.ToString()); // read only field representing the level
    }
}