using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class RunSettings : MonoBehaviour {

    // Define Public Variables
    public bool resetData = false;
    
    void Start () {
		
	}
	
	void Update () {
        if (resetData == true)
        {
            PlayerPrefs.DeleteAll();
            Debug.LogWarning("The HLC PlayerPref has been cleared.");
            resetData = false;
        }
	}
}
