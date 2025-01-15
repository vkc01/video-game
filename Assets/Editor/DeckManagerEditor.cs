using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cardsetup;

#if UNITY_EDITOR
using UnityEditor;
[CustomEditor(typeof(DeckManager))]
public class DeckManagerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        DeckManager deckManager = (DeckManager)target;
        if (GUILayout.Button("Draw Next Card")){
            handmanager handManager = FindFirstObjectByType<handmanager>();
            if (handManager != null){
                deckManager.DrawCard(handManager);
            }
        }
    }
}
#endif