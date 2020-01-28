using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CabecaRun : MonoBehaviour
{
    float axis;
    Rigidbody2D rb;
    public float movespeed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        float X = Input.GetAxis("Vertical");

        rb.transform.Translate(new Vector2(0, X * Time.deltaTime * movespeed));;
        
        
    }

    void OnTriggerEnter2D (Collider2D col){
		if (col.CompareTag("dead")){
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
}
