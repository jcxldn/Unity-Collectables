using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    // Define Private Variables

    // Level Settings
    private Rigidbody rb;
    private int count;
    private string levelNumber;
    private bool isPaused = false;

    // Define Public Variables

    // Level GUI/Settings
    public float speed;
    public Text countText;
    public Text levelText;
    public GameObject levelInfo;
    // Level Pause/End
    public GameObject levelCompleted;
    public GameObject levelPaused;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        LevelCompleted();
        levelCompleted.SetActive(false);
        levelPaused.SetActive(false);
        LevelInfo();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement);

        // Pause Menu
        KeyCode pause = KeyCode.Escape;
        if (isPaused == false)
        {
            if (Input.GetKeyDown(pause))
            {
                levelPaused.SetActive(true);
                isPaused = true;
            }
        } else if (isPaused == true)
        {
            if (Input.GetKeyDown(pause))
            {
                levelPaused.SetActive(false);
                isPaused = false;
            }
        }
    }

    public void ReturnGameClicked()
    {
        levelPaused.SetActive(false);
        isPaused = false;
    }

    void OnTriggerEnter(Collider other)
    {
        // Destroy(other.gameObject);
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            LevelCompleted();
        }
    }

    void LevelCompleted()
    {
        countText.text = "Count: " + count.ToString();

        // Level 1 - 4 PickUps
        if (levelNumber == "L1")
        {
            if (count == 4)
            {
                levelCompleted.SetActive(true);

                // Save string when level is completed
                if (PlayerPrefs.GetString("HLC") == "")
                {
                    PlayerPrefs.SetString("HLC", "Level 1");
                    Debug.Log("Set HLC to 1.");
                }
            }
        }

        // Level 2 - 4 PickUps
        else if (levelNumber == "L2")
        {
            if (count == 4)
            {
                levelCompleted.SetActive(true);

                // Save string when level is completed
                if (PlayerPrefs.GetString("HLC") == "Level 1")
                {
                    PlayerPrefs.SetString("HLC", "Level 2");
                    Debug.Log("Set HLC to 2.");
                }
            }
        }

        // Level 3 - 8 PickUps
        else if (levelNumber == "L3")
        {
            if (count == 8)
            {
                levelCompleted.SetActive(true);

                // Save string when level is completed
                if (PlayerPrefs.GetString("HLC") == "Level 2")
                {
                    PlayerPrefs.SetString("HLC", "Level 3");
                    Debug.Log("Set HLC to 3.");
                }
            }
        }
    }

    void LevelInfo()
    {
        levelNumber = levelInfo.transform.name;
        Debug.Log("levelNumber: " + levelNumber);

        // Level 1
        if (levelNumber == "L1")
        {
            levelText.text = "Level 1";
        }

        // Level 2
        else if (levelNumber == "L2")
        {
            levelText.text = "Level 2";
        }

        // Level 3
        else if (levelNumber == "L3")
        {
            levelText.text = "Level 3";
        }
        else
        {
            Debug.LogError("Valid Level Number not found!\nLevel Info will now be disabled.");
            levelText.text = "";
        }
    }
}
