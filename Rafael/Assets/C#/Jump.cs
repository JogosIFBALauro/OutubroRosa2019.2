using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    
    public bool isGrounded;
    public int doublejump;
    public int doublejumpValor;
    public float forcaPulo;
    private Rigidbody2D rb;
    private Animator anim;
    public AudioSource pulo;


    void Start(){

        doublejump = doublejumpValor;
        rb = GetComponent<Rigidbody2D>();
        
    }


    void Update()
    {
        Pular();
           
    }

    private void Pular(){
        if (isGrounded == true)
            {
                doublejump = doublejumpValor;
                
                
            }
            if ((Input.GetKeyDown(KeyCode.UpArrow)) && doublejump > 0 || (Input.GetKeyDown(KeyCode.Joystick1Button0)) && doublejump > 0)
                {
                    rb.velocity = Vector2.up * forcaPulo;
                    doublejump--; 
                    pulo.Play();
                                    
                }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.CompareTag("chao")){
           isGrounded = true;
       } 
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
            if (collision.gameObject.CompareTag("chao")) 
        {
            isGrounded = false;
        }
        
    }
}
