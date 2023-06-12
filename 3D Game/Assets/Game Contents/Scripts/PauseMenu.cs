using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // Public so can see from elsewhere, static because not about referencing this script, just checking
    public static bool gamePaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // If its already paused then resume
            if (gamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1.0f; // Continues in background in slow mo

        gamePaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0.0f; // Continues in background in slow mo

        gamePaused = true;
    }

    public void LoadMenu()
    {

    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
    }

}
