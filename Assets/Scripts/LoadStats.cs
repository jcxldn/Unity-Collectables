using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadStats : MonoBehaviour {

    // Define Public Variables
    public Text HLCText;
    
    void Start () {
        PlayerPrefs.Save();
        HLCText.text = PlayerPrefs.GetString("HLC");
    }
	
	void Update () {
		
	}
}
