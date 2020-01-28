using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuReturn : MonoBehaviour
{
    private int currentSceneIndex;

    public void LoadMainMenu(){
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedScene", currentSceneIndex);
        SceneManager.LoadScene(0);
    }
    /*public void ReturnMenu()
    {
        SceneManager.LoadScene(0);
    }*/

}
