using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Interaction))]
public class InteractionEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        // Reference to the inspected script (target)
        Interaction _cc = (Interaction)target;

        // Displays a button with the name "Apply Color Pattern"
        if (GUILayout.Button("Cut"))
        {
            _cc.TrySplitObject();
        }
    }
}
