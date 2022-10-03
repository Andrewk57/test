using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    //the header of a function
    // this function takes no arguements/parameters but you must still include the parentheses
    public void ExitGame()
    {
        Debug.Log("Quitted");
        Application.Quit();



    } //every { must have a } to match it
    // We added a string arguement to this one, so it can be reused for other scenes
    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);


    }
}
