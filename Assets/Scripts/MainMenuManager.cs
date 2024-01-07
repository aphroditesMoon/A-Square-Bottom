using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject mainMenuObject;
    public GameObject creditsObject;
    
    public void Play()
    {
        SceneManager.LoadScene(Random.Range(1,7));
    }

    public void OpenCredits()
    {
        mainMenuObject.SetActive(false);
        creditsObject.SetActive(true);
    }
    
    public void CloseCredits()
    {
        mainMenuObject.SetActive(true);
        creditsObject.SetActive(false);
    }

    public void AppQuit()
    {
        Application.Quit();
    }
}
