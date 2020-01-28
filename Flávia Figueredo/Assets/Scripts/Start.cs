using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    
    public void StartMenu()
    {
        SceneManager.LoadScene(3);
    }

    public void CreditosMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void StartHistoria()
    {
        SceneManager.LoadScene(2);
    }


    
}
