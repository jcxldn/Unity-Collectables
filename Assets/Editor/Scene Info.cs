using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SceneInfo : EditorWindow {

    bool showPosition = true;
    bool groupEnabled;

    // SceneInfo
    [MenuItem("Game/Scene Info")]
    static void Init()
    {
        // Get existing open window or if none, make a new one:
        SceneInfo window = (SceneInfo)EditorWindow.GetWindow(typeof(SceneInfo));
        window.Show();
    }

    void OnGUI()
    {
        GUILayout.Label("Scene Infomation", EditorStyles.boldLabel);
        GUILayout.Label("Menu - Scene ID 0");
        GUILayout.Label("Settings - Scene ID 1");
        GUILayout.Label("About - Scene ID 4");
        GUILayout.Label("Stats - Scene ID 6");
        // Levels

        showPosition = EditorGUILayout.Foldout(showPosition, "Levels");
        if (showPosition)
        {
            GUILayout.Label("Level 1 - Scene ID 2");
            GUILayout.Label("Level 2 - Scene ID 3");
            GUILayout.Label("Level 3 - Scene ID 5");
        }
    }
}

// Menu - 0
// Stats - 6
// Settings - 1
// About - 4
// L1 - 2
// L2 - 3
// L3 - 5
