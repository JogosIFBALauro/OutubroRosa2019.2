using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverBala : MonoBehaviour
{
    public float vel = 10f;
    

    void Update()
    {
            transform.Translate(new Vector2(vel * Time.deltaTime, 0));
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("inimigo1"))
        {
            Destroy(this.gameObject);
            GetComponent<Enemy>().life--;
        }

        if (collision.gameObject.CompareTag("inimigo2"))
        {
            Destroy(this.gameObject);
            GetComponent<Enemy>().life--;
        }

        if (collision.gameObject.CompareTag("inimigo3"))
        {
            Destroy(this.gameObject);
            GetComponent<Enemy>().life--;
        }
    }
}
