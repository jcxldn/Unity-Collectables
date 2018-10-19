using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Platform;
using Kodi;

namespace Platform
{

    public class PlatformManager : MonoBehaviour
    {
        // Instancing
        // ONLY MAKE ONE SET OF INSTANCES IN ALL FILES INVOLVED
        public static PlatformManager Instance;

        void Awake()
        {
            Instance = this;
        }

        // Visible Instancing
        public Elements.Global Global = new Elements.Global();
        [Space]
        public Elements.Scene Scene = new Elements.Scene();
        [Space]
        public PlatformDebug debugOverrides = new PlatformDebug();
        [Space]
        public Text scalingInfo;

        // Hidden Instancing
        //[System.NonSerialized]
        Edits.Console Console = new Edits.Console();


        void Start()
        {
            debugOverrides.Verify();
            // Apply scaling options if on console (XDK)
            if (SystemInfo.deviceType == DeviceType.Console || debugOverrides.XDKOptions)
            {
                // Use Kodi.Log (custom, see Misc.cs) to print with global prefix
                Log.type.platform("XDK or Eqivalent Console or Override Detected");
                Console.scalingSetup();
                Console.OverScanUISetup();
                Console.OverScanLevelUISetup();
            }
        }
    }

    // Debug class for platform overrides
    [System.Serializable]
    public class PlatformDebug
    {
        public bool disabled = true;
        public bool XDKOptions = false;

        // Verify options
        public void Verify()
        {
            if (disabled)
            {
                Kodi.Log.type.platform("All Platform Debug Overides Disabled.");
                XDKOptions = false;
            }
        }
    }
}


