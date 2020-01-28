using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseUI;
    public static bool gamePause = false;
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.P)) || (Input.GetKeyDown(KeyCode.Joystick1Button7)))
        {
            if (gamePause)
            {
                Resume();
                if ((Input.GetKeyDown(KeyCode.P)) || (Input.GetKeyDown(KeyCode.Joystick1Button7)))
                {
                    Resume();
                }
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
        gamePause = false;
    }

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }

    void Pause()
    {
        PauseUI.SetActive(true);
        Time.timeScale = 0f;
        gamePause = true;
    }

}
