using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Maptester))]
public class MapTesterEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        var script = (Maptester)target;

        if(GUILayout.Button("Generate Island"))
        {
            if (Application.isPlaying)
            {
                script.MakeMap();
            }
        }
    }
}
