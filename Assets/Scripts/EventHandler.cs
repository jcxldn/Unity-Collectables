using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EventHandler : MonoBehaviour
{

    // Quit the Game

    public void Exit()
    {
        Application.Quit();
    }

    // Loading Stats

    public Text HLCText;
    public bool statsOpen = false;
    private string statsText = "Levels Completed: ";

    private void Update()
    {
        if (statsOpen == true)
        {
            PlayerPrefs.Save();
            HLCText.text = statsText + PlayerPrefs.GetString("HLC");
            if (PlayerPrefs.GetString("HLC") == "")
            {
                HLCText.text = statsText + "0";
            }
        }
    }

    // Running Settings

    public Button settingsResetButton;
    public Color settingsHighlightOff = new Color(255, 255, 255, 255);
    // public GameObject levelID;

    public void Settings_ResetData()
    {
        PlayerPrefs.DeleteAll();
        Debug.LogWarning("All PlayerPrefs have been deleted.");
        // Fix Button Colour
        ColorBlock cb = settingsResetButton.colors;
        cb.highlightedColor = settingsHighlightOff;
        settingsResetButton.colors = cb;
    }

    // Scene Loader
    public void LoadScene(int scene)
    {
        SceneManager.LoadSceneAsync(scene, LoadSceneMode.Single);
    }
}