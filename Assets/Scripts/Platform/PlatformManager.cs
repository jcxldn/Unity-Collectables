using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Platform;

namespace Platform
{

    public class PlatformManager : MonoBehaviour
    {

        // Visible Refrences
        public Elements.global global;
        [Space]
        public Elements.scene scene;
        [Space]
        public Text scalingInfo;

        // Instancing
        //Edits.Console console;


        public static PlatformManager Instance;
        
        void Awake()
        {
            Instance = this;
        }

        void Start()
        {
            // Apply scaling options if on console (XDK)
            if (SystemInfo.deviceType == DeviceType.Console)
            {
                console.OverScanUISetup();
                console.scalingSetup();
            }
            Debug.Log("testing");
            console.scalingSetup();
            //console.OverScanUISetup();
        }
    }
}


