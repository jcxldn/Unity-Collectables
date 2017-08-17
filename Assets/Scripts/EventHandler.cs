using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EventHandler : MonoBehaviour {

    // Quit the Game

    public void Exit()
    {
        Application.Quit();
    }

    // Loading Stats

    public Text Stats_HLCText;

    public void Stats()
    {
        PlayerPrefs.Save();
        Stats_HLCText.text = PlayerPrefs.GetString("HLC");
        if (PlayerPrefs.GetString("HLC") == "")
        {
            Stats_HLCText.text = "No Levels Completed";
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

// Loading Scenes

// Menu - 0
// Stats - 6
// Settings - 1
// About - 4
// L1 - 2
// L2 - 3
// L3 - 5
public void Scene_Menu()
    {
        SceneManager.LoadSceneAsync(0, LoadSceneMode.Single);
    }
    public void Scene_Stats()
    {
        SceneManager.LoadSceneAsync(6, LoadSceneMode.Single);
    }
    public void Scene_Settings()
    {
        SceneManager.LoadSceneAsync(1, LoadSceneMode.Single);
    }
    public void Scene_About()
    {
        SceneManager.LoadSceneAsync(4, LoadSceneMode.Single);
    }
    public void Scene_L1()
    {
        SceneManager.LoadSceneAsync(2, LoadSceneMode.Single);
    }
    public void Scene_L2()
    {
        SceneManager.LoadSceneAsync(3, LoadSceneMode.Single);
    }
    public void Scene_L3()
    {
        SceneManager.LoadSceneAsync(5, LoadSceneMode.Single);
    }
}
