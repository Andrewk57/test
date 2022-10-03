using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PauseMenuScript : MonoBehaviour
{
    public GameObject menu;
    public KeyCode testingKey;
    public TextMeshProUGUI testingText;
    public bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        menu.SetActive(false);  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(testingKey))
        { //Debug.Log("Down");
            testingText.text = "Down";
            testingText.color = Color.red;
        }
        else if (Input.GetKey(testingKey))
        {
            //Debug.Log("Hold");
            testingText.text = "Hold";
            testingText.color = Color.magenta;
        }
        else if (Input.GetKeyUp(testingKey))
        {
            //Debug.Log("Up");
            testingText.text = "Up";
            testingText.color = Color.yellow;
        }
        else
        {
          
        }
        if (Input.GetButtonDown("Cancel"))
        {
            
                TogglePauseGame(); 
        }
    }

    public void TogglePauseGame()
    {
       // if (Input.GetButtonDown("Cancel"))
        
        isPaused = !isPaused;

        menu.SetActive(isPaused);
        // if (isPaused == true
        if (isPaused)
        {
            Time.timeScale = 0f;

        }
        else
        {
            Time.timeScale = 1f;
        }
        
    }
    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);


    }
}
