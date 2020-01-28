using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class andando : MonoBehaviour
{
    
        float movimento = 10f;
        bool lookingRight = true;
        private Rigidbody2D rb2d;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
        

    }

    // Update is called once per frame
    void Update()
    {
        
        move ();
        
    }

    
    void move(){
        float horizontalForceButton = Input.GetAxis ("Horizontal")* movimento * Time.deltaTime;
        if ((horizontalForceButton > 0 && !lookingRight) || (horizontalForceButton < 0 && lookingRight))
            Flip();
            transform.position = new Vector2(transform.position.x + horizontalForceButton, transform.position.y);

                }
    void Flip(){
        lookingRight = !lookingRight;
        Vector3 myScale = transform.localScale;
        myScale.x *= -1;
        transform.localScale = myScale;
        
    }


   
    
}
