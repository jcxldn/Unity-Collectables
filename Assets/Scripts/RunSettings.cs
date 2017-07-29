using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class RunSettings : MonoBehaviour {

    // Define Public Variables
    public Button resetButton;
    
    void Start () {
		
	}
	
	void Update () {
        resetButton.onClick.AddListener(resetTask);
	}

    void resetTask()
    {
        PlayerPrefs.DeleteAll();
        Debug.LogWarning("All PlayerPrefs have been deleted.");
    }
}
