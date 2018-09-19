using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Tween))]
public class TweenEditor : Editor
{
    bool isUseInspector = false;

    public override void OnInspectorGUI()
    {
        Tween tween = target as Tween;

        isUseInspector = EditorGUILayout.ToggleLeft("Use Inspector" , isUseInspector);

        if(isUseInspector)
        {
            EditorGUILayout.LabelField("- Tween -");
            tween.curve = EditorGUILayout.CurveField("Curve" , tween.curve , null);
            tween.toMove = EditorGUILayout.Vector3Field("To Move" , tween.toMove , null);
            tween.toMove = EditorGUILayout.Vector3Field("To Rotate" , tween.toRotate , null);
            tween.toMove = EditorGUILayout.Vector3Field("To Scale" , tween.toScale , null);
        }
    }
}
