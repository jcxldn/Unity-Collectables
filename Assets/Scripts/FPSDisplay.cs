using UnityEngine;
using UnityEngine.UI;

public class FPSDisplay : MonoBehaviour {

    private Text fpsDisplay;
    private int avgFPS;

    void Start () {
        fpsDisplay = GetComponent<Text>();
    }

    void Update () {
        float current = 0;
        //current = (int)(1f / Time.unscaledDeltaTime);
        current = Time.frameCount / Time.time;
        avgFPS = (int)current;
        fpsDisplay.text = avgFPS.ToString() + " FPS";
	}
}
