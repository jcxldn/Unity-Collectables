using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    // Define Private Variables
    private Rigidbody rb;
    private int count;
    private string levelNumber;

    // Define Public Variables
    public float speed;
    public Text countText;
    public Text winText;
    public GameObject menuButton;
    public Text levelText;
    public GameObject levelInfo;
    public GameObject nextLevelButton;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        LevelCompleted();
        winText.text = "";
        menuButton.SetActive(false);
        nextLevelButton.SetActive(false);
        LevelInfo();
    }

	void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement);
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
                winText.text = "You Win!";
                menuButton.SetActive(true);
                nextLevelButton.SetActive(true);
            }
        }
        // Level 2 - 4 PickUps
        else if (levelNumber == "L2")
        {
            if (count == 4)
            {
                winText.text = "You Win!";
                menuButton.SetActive(true);
                nextLevelButton.SetActive(true);
            }
        }
        // Level 3 - 8 PickUps
        else if (levelNumber == "L3")
        {
            if (count == 8)
            {
                winText.text = "You Win!";
                menuButton.SetActive(true);
                nextLevelButton.SetActive(true);
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
