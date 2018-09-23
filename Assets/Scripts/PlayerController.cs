using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour {

    // Define EventHandler
    public EventHandler EventHandler;

    // Define Private Variables

    // Level Settings
    private Rigidbody rb;
    private int count;
    //private string levelNumber;
    private bool isPaused = false;

    // Define Public Variables

    // Level GUI/Settings
    public float speed;
    public Text countText;
    public Text levelText;
    //public GameObject levelInfo;
    // Level Pause/End
    public GameObject levelCompleted;
    public GameObject levelPaused;

    // Controller Selection
    public GameObject pauseButton;
    public GameObject completeButton;
    public EventSystem eventSystem;

    public bool movementEnabled = true;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        LevelCompleted();
        levelCompleted.SetActive(false);
        levelPaused.SetActive(false);
        // Set level text
        levelText.text = "Level " + SceneManager.GetActiveScene().name;
        eventSystem = EventSystem.current;
    }

    void FixedUpdate()
    {
        if (movementEnabled)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

            rb.AddForce(movement);

            if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
            {
                rb.angularVelocity = rb.angularVelocity / 2;
                rb.velocity = rb.velocity / 2;
                StartCoroutine(waitForSeconds(0.5f));

            }
        }

        // Pause Menu
        KeyCode pause = KeyCode.Escape;
        if (isPaused == false)
        {
            if (Input.GetKeyDown(pause))
            {
                movementEnabled = false;
                levelPaused.SetActive(true);
                isPaused = true;
                eventSystem.SetSelectedGameObject(pauseButton);
            }
        } else if (isPaused == true)
        {
            if (Input.GetKeyDown(pause))
            {
                movementEnabled = true;
                levelPaused.SetActive(false);
                isPaused = false;
            }
        }

        // Below map detection
        if (this.transform.position.y < 0.49)
        {
            //SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
            // Reload Active Scene
            EventHandler.LoadScene(SceneManager.GetActiveScene().buildIndex);
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
        if (SceneManager.GetActiveScene().name == "1")
        {
            if (count == 4)
            {
                onLevelComplete();
                // Save string when level is completed
                if (PlayerPrefs.GetString("HLC") == "")
                {
                    PlayerPrefs.SetString("HLC", SceneManager.GetActiveScene().name);
                    Debug.Log("Set HLC to 1.");
                }
            }
        }

        // Level 2 - 4 PickUps
        else if (SceneManager.GetActiveScene().name == "2")
        {
            if (count == 4)
            {
                onLevelComplete();
                // Save string when level is completed
                if (PlayerPrefs.GetString("HLC") == "1")
                {
                    PlayerPrefs.SetString("HLC", SceneManager.GetActiveScene().name);
                    Debug.Log("Set HLC to 2.");
                }
            }
        }

        // Level 3 - 8 PickUps
        else if (SceneManager.GetActiveScene().name == "3")
        {
            if (count == 8)
            {
                onLevelComplete();
                // Save string when level is completed
                if (PlayerPrefs.GetString("HLC") == "2")
                {
                    PlayerPrefs.SetString("HLC", SceneManager.GetActiveScene().name);
                    Debug.Log("Set HLC to 3.");
                }
            }
        }

        // Level 4 - 4 PickUps
        else if (SceneManager.GetActiveScene().name == "4")
        {
            if (count == 4)
            {
                onLevelComplete();
                // Save string when level is completed
                if (PlayerPrefs.GetString("HLC") == "3")
                {
                    PlayerPrefs.SetString("HLC", SceneManager.GetActiveScene().name);
                    Debug.Log("Set HLC to 4.");
                }
            }
        }

        // Level 5 - 4 PickUps
        else if (SceneManager.GetActiveScene().name == "5")
        {
            if (count == 4)
            {
                onLevelComplete();
                // Save string when level is completed
                if (PlayerPrefs.GetString("HLC") == "4")
                {
                    PlayerPrefs.SetString("HLC", SceneManager.GetActiveScene().name);
                    Debug.Log("Set HLC to 5.");
                }
            }
        }
    }

    void onLevelComplete()
    {
        levelCompleted.SetActive(true);
        movementEnabled = false;
        eventSystem.SetSelectedGameObject(completeButton);
        rb.angularVelocity = new Vector3(0, 0, 0);
        rb.velocity = new Vector3(0, 0, 0);
    }

    IEnumerator waitForSeconds(float seconds)
    {
        //print(Time.time);
        yield return new WaitForSeconds(seconds);
        //print(Time.time);
    }
}
