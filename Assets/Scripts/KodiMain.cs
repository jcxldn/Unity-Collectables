using UnityEngine;

// Random namespace for Misc stuff
namespace Kodi.Internal.Log
{
    // Class to expose to Mono
    public class KodiMain : MonoBehaviour
    {
        // Instancing
        public static KodiMain Instance;

        void Awake()
        {
            Instance = this;
        }


        public Prefix logPrefixes = new Prefix();
    }

    // Class to store prefixes
    [System.Serializable]
    public class Prefix
    {
        public string debug = "[Debug]";

        // Platform subclass
        public Platform platform;
        [System.Serializable]
        public class Platform
        {
            public string manager = "[Platform Manager]";
            public string debug = "[P.Info Debug]";
            public string XDK = "[P.XDK Debug]";
        }
    }

    // Class to be used instead of Debug.Log for easy logging with prefixes
    public class LP
    {
        public void platform(string message)
        {
            Debug.Log(KodiMain.Instance.logPrefixes.platform.manager + " " + message);
        }

        public void platformXDK(string message)
        {
            Debug.Log(KodiMain.Instance.logPrefixes.platform.XDK + " " + message);
        }

        public void platformWarning(string message)
        {
            Debug.LogWarning(KodiMain.Instance.logPrefixes.platform.debug + " " + message);
        }
    }
}

namespace Kodi
{
    public class Log
    {
        public static Internal.Log.LP type = new Internal.Log.LP();
    }
}