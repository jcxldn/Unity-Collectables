using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XboxOneEdits : MonoBehaviour {

    public Canvas globalCanvas;
    public Canvas sceneCanvas;
    public Text test;

	// Use this for initialization
	void Start () {
        test.text = SystemInfo.deviceType.ToString();
        if (SystemInfo.deviceType == DeviceType.Console)
        {
            //Change the text of the label
            //test.text = "Console";
            globalCanvas.scaleFactor = 1.5f;
            sceneCanvas.scaleFactor = 1.5f;
            test.text = globalCanvas.scaleFactor.ToString();
        }
	}
}
