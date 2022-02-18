using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    //check whether Game is pause
    public static bool Gameispaused = false;

    //Gameobject for pausemenu ui
    public GameObject pauseMenuUI;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Gameispaused)
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
        //toggle pause menu ui to on / off
        pauseMenuUI.SetActive(false);
        //change time scale
        Time.timeScale = 1f;
        Gameispaused = false;
    }

    void Pause ()
    {
        //toggle pause menu ui to on / off
        pauseMenuUI.SetActive(true);
        //change time scale
        Time.timeScale = 0f;
        Gameispaused = true;
    }

    public void MenuLoad()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
