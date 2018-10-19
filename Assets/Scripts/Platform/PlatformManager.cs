using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Platform;

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
        public Text scalingInfo;

        // Hidden Instancing
        //[System.NonSerialized]
        Edits.Console Console = new Edits.Console();


        void Start()
        {
            // Apply scaling options if on console (XDK)
            //if (SystemInfo.deviceType == DeviceType.Console)
            //{
            //    console.OverScanUISetup();
            //    console.scalingSetup();
            //}
            Debug.Log("testing");
            Console.scalingSetup();
            Console.OverScanUISetup();
            Console.OverScanLevelUISetup();
        }
    }
}


