using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace Platform.Edits
{
    public class Console
    {   
        public void scalingSetup()
        {
            Debug.Log(PlatformManager.Instance.Global.canvas.scaleFactor);
            Debug.Log("Scaling Setup");
            // 1.5f Scaling
            PlatformManager.Instance.Global.canvas.scaleFactor = 1.5f;
            PlatformManager.Instance.Scene.canvas.scaleFactor = 1.5f;
            try
            {
                PlatformManager.Instance.scalingInfo.text = ("Scaling :" + PlatformManager.Instance.Global.canvas.scaleFactor.ToString());
            }
            catch (Exception e)
            {
                Debug.LogWarning("Error on Text, Continuing... : " + e);
            }
        }

        // Move UI to fix any overscan visibility conflicts
        public void OverScanUISetup()
        {
            PlatformManager.Instance.Global.elements.FPS.transform.position = new Vector3(110, 115, 0);
            PlatformManager.Instance.Global.elements.version.transform.position = new Vector3(110, 110, 0);
            PlatformManager.Instance.Global.elements.panel.SetActive(true);
        }
    }

}
