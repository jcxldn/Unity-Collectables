using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour {

    // Define Loadable Scenes
    public bool Menu = false;
    public bool Stats = false;
    public bool Settings = false;
    public bool About = false;
    public bool L1 = false;
    public bool L2 = false;
    public bool L3 = false;

    void Update () {

        if (Menu == true)
        {
            SceneManager.LoadSceneAsync(0, LoadSceneMode.Single);
        }

        if (Stats == true)
        {
            SceneManager.LoadSceneAsync(6, LoadSceneMode.Single);
        }

        else if (Settings == true)
        {
            SceneManager.LoadSceneAsync(1, LoadSceneMode.Single);
        }

        else if (About == true)
        {
            SceneManager.LoadSceneAsync(4, LoadSceneMode.Single);
        }

        else if (L1 == true)
        {
            SceneManager.LoadSceneAsync(2, LoadSceneMode.Single);
        }

        else if (L2 == true)
        {
            SceneManager.LoadSceneAsync(3, LoadSceneMode.Single);
        }
        else if (L3 == true)
        {
            SceneManager.LoadSceneAsync(5, LoadSceneMode.Single);
        }
    }
}
