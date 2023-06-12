using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayDayGame ()
    {
        // Give the function the build index you want to load
        SceneManager.LoadScene(1);
    }

    public void PlayNightGame()
    {
        // Give the function the build index you want to load
        SceneManager.LoadScene(2);
    }

    public void PlayNYGame()
    {
        // Give the function the build index you want to load
        SceneManager.LoadScene(3);
    }
}
