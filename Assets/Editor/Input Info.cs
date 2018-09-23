using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class InputInfo : EditorWindow {

    bool showPosition0 = true;
    bool showPosition1 = true;
    bool groupEnabled;

    // InputInfo
    [MenuItem("Game/Input Info")]
    static void Init()
    {
        // Get existing open window or if none, make a new one:
        InputInfo window = (InputInfo)EditorWindow.GetWindow(typeof(InputInfo));
        window.Show();
    }

    void OnGUI()
    {
        GUILayout.Label("Input Infomation", EditorStyles.boldLabel);
        GUILayout.Label("One input for each method.");

        showPosition0 = EditorGUILayout.Foldout(showPosition0, "Horizontal");
        if (showPosition0)
        {
            // Double tab indent
            GUILayout.Label("       A - D");
            GUILayout.Label("       Controller Axis X (JoyLeft)");
            GUILayout.Label("       Controller Axis 6 (DPad)");
        }

        showPosition1 = EditorGUILayout.Foldout(showPosition1, "Vertical");
        if (showPosition1)
        {
            // Double tab indent
            GUILayout.Label("       W - S");
            GUILayout.Label("       Controller Axis Y (JoyLeft)");
            GUILayout.Label("       Controller Axis 7 (DPad)");
        }
    }
}