using UnityEngine;
using System.Collections;
using UnityEditor;


[CustomEditor(typeof(CharacterAttributes))]
class CharacterAttributesEditor : Editor
{
    // specify bounds for attributes
    int attributeMax = 100;
    int attributeMin = 0;

    public override void OnInspectorGUI()
    {
        CharacterAttributes character = (CharacterAttributes)target;

        // class
        EditorGUILayout.EnumPopup("Class", character.characterClass, EditorStyles.popup);

        // experience and level
        character.experience = EditorGUILayout.IntField("Experience", character.experience);
        EditorGUILayout.LabelField("Level", character.level.ToString());

        // attributes
        EditorGUILayout.PrefixLabel("Attributes:");
        EditorGUI.indentLevel++;
        character.stamina = EditorGUILayout.IntSlider(new GUIContent("Stamina"), character.stamina, attributeMin, attributeMax);
        character.agility = EditorGUILayout.IntSlider(new GUIContent("Agility"), character.agility, attributeMin, attributeMax);
        character.intelligence = EditorGUILayout.IntSlider(new GUIContent("Intelligence"), character.intelligence, attributeMin, attributeMax);

        // resources (based on attributes)
        EditorGUI.indentLevel--;
        EditorGUILayout.PrefixLabel("Resources:");
        EditorGUI.indentLevel++;
        EditorGUILayout.LabelField("Health", character.maxHealth.ToString());
        EditorGUILayout.LabelField("Energy", character.maxEnergy.ToString());
        EditorGUILayout.LabelField("Mana", character.maxMana.ToString());

    }
    
}
