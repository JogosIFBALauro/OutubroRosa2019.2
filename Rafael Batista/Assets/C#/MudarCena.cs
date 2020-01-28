using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudarCena : MonoBehaviour
{
    public void voltarMenu(){
        SceneManager.LoadScene(0);
    }

    public void credits(){
        SceneManager.LoadScene(2);
    }

    

    public void start(){
        SceneManager.LoadScene(1);
    }
    public void proximo(){
        SceneManager.LoadScene(4);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(3);

        }
    }
}
