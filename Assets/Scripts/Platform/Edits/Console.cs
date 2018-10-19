using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platform.Edits
{
    public class Console : MonoBehaviour
    {
        // Instancing
        private Elements.global global;
        private Elements.scene scene;
        private PlatformManager PlatformManager;
        private Elements.global.sub sub;
        
        public static Console Instance;

        void Awake()
        {
            Instance = this;
        }

        public void scalingSetup()
        {
            Debug.Log("Scaling Setup");
            // 1.5f Scaling
            Platform.Elements.global.Instance.canvas.scaleFactor = 1.5f;
            Platform.Elements.scene.Instance.canvas.scaleFactor = 1.5f;
            Platform.PlatformManager.Instance.scalingInfo.text = global.canvas.scaleFactor.ToString();
        }

        // Move UI to fix any overscan visibility conflicts
        public void OverScanUISetup()
        {
            sub.FPS.transform.position = new Vector3(sub.FPS.transform.position.x + 100, sub.FPS.transform.position.y + 100, sub.FPS.transform.position.z);
            sub.version.transform.position = new Vector3(sub.version.transform.position.x + 100, sub.version.transform.position.y + 100, sub.version.transform.position.z);
            sub.panel.SetActive(true);

        }
    }

}
