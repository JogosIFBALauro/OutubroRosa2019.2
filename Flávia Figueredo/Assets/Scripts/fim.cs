using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fim : MonoBehaviour
{
    public void OnTriggerEnter2D (Collider2D col){
        if (col.gameObject.CompareTag("cabeca"))
        {
            SceneManager.LoadScene(6);

        }
    }
    
}
