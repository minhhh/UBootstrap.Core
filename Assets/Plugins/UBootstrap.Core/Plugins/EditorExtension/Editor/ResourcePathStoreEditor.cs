using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace UBootstrap.Editor
{
    [CustomEditor (typeof(ResourcePathStore))]
    public class ResourcePathStoreEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI ()
        {
            serializedObject.Update ();
            ResourcePathStore component = (ResourcePathStore)target;

            GUILayout.BeginVertical (GUI.skin.box);

            GUILayout.BeginHorizontal ();

            GUILayout.Label ("Number of Assets", EditorStyles.boldLabel, GUILayout.MinWidth (100));

            GUILayout.Label (
                new GUIContent (component.GetNumberOfAssets ().ToString ()), 
                GUILayout.Height (14), 
                GUILayout.Width (100)
            );

            GUILayout.EndHorizontal ();

            if (GUILayout.Button ("Refresh")) {
                component.Populate ();
                EditorUtility.SetDirty (target);
            }

            GUILayout.EndVertical ();

            serializedObject.ApplyModifiedProperties ();
        }


    }
}
