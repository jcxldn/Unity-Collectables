using UnityEngine;

// Objects for all platforms

namespace Platform.Elements
{
    public class Global : MonoBehaviour
    {
        public global global;
    }

    // Main Class - Global Canvas
    [System.Serializable]
    public class global
    {
        public Canvas canvas;
        public sub elements;

        // Subclass
        [System.Serializable]
        public class sub
        {
            public GameObject version;
            public GameObject FPS;
            public GameObject panel;

            // Instancing
            public static sub Instance;

            void Awake()
            {
                Instance = this;
            }
        }

        // Instancing
        public static global Instance;

        void Awake()
        {
            Instance = this;
        }
    }

    // Main Class - Level Canvas
    [System.Serializable]
    public class scene
    {
        public Canvas canvas;

        // Instancing
        public static scene Instance;

        void Awake()
        {
            Instance = this;
        }
    }
}