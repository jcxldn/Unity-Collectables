using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class RunSettings : MonoBehaviour {

    // Define Public Variables
    public bool resetData = false;
    public Button resetButton;
    public Color highlightOff;
    
    void Start () {
		
	}
	
	void Update () {
        if (resetData == true)
        {
            PlayerPrefs.DeleteAll();
            Debug.LogWarning("All PlayerPrefs have been deleted.");
            // Fix Button Colour
            ColorBlock cb = resetButton.colors;
            cb.highlightedColor = highlightOff;
            resetButton.colors = cb;
            // Set resetData to false to prevent a loop
            resetData = false;
        }
	}
}
