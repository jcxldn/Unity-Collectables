using UnityEngine;

// Objects for all platforms

namespace Platform.Elements
{
    // Main Class - Global Canvas
    [System.Serializable]
    public class Global
    {
        public Canvas canvas;
        public Sub elements;

        // Subclass
        [System.Serializable]
        public class Sub
        {
            public GameObject version;
            public GameObject FPS;
            public GameObject panel;
        }
    }

    // Main Class - Level Canvas
    [System.Serializable]
    public class Scene
    {
        public Canvas canvas;
    }
}