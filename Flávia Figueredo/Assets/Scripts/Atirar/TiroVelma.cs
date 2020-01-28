using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroVelma : MonoBehaviour
{
     public GameObject cano;
    public GameObject bala;

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bala, new Vector3(cano.transform.position.x, cano.transform.position.y, cano.transform.position.z), Quaternion.identity);
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("inimigo1"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("inimigo2"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("inimigo3"))
        {
            Destroy(collision.gameObject);
        }

    }
}
