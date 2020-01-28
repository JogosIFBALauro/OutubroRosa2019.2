using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
     public float JForce;
    public float moveInput;

    private Rigidbody2D rb;

    private bool IsGrounded;
    public Transform GroundCheck;
    public float getRadius;
    public LayerMask whatsGrounded;
    //Verificar se tem chão usando um circulo pra esconder depois
    private int NJump;
    public int NJJumpValue;
    //Tive que fazer assim pra não gerar bugs
    public bool OlharDireita = true;
    public Animator Pulo;
    //tive que colocar em pt pra nao ter dificuldade    
    public AudioSource Jump;
    //Localizar o som de pulo

    public ParticleSystem dust;

    void Start()
    {
        NJump = NJJumpValue;
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (IsGrounded == true)
        {
            NJump = NJJumpValue;
        }
        if ((Input.GetKeyDown(KeyCode.UpArrow) || (Input.GetKeyDown(KeyCode.Joystick1Button0)) || (Input.GetKeyDown(KeyCode.W))) && NJump > 0)
        {
           
            rb.velocity = Vector2.up * JForce;
            NJump--;
            Pulo.SetBool("Jump", true ); 
            Playjump();
            CreatDust();
            
        } else if ((Input.GetKeyDown(KeyCode.UpArrow) || (Input.GetKeyDown(KeyCode.Joystick1Button0)) || (Input.GetKeyDown(KeyCode.W))) && NJump == 0 && IsGrounded == true)
        {
            rb.velocity = Vector2.up * JForce;
            Pulo.SetBool("Jump", true);
            Playjump();
        } else if (IsGrounded == true)
        {
            Pulo.SetBool("Jump", false);
        }
    }
    void FixedUpdate()
    {
        IsGrounded = Physics2D.OverlapCircle(GroundCheck.position, getRadius, whatsGrounded);

        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if(moveInput < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
            
        }
        else if (moveInput > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            
        }
        //teoricamente, não precisava dessas linhas de codigo, mas por algum motivo a animação do jogador só funciona se ela estiver ai


        if (OlharDireita == false && moveInput > 0)
        {
            flip();
        } else if (OlharDireita == true && moveInput < 0)
        {
            flip();
        }

    }
    void flip()
    {
        OlharDireita = !OlharDireita;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
        //fiz isso pra facilitar na hora de chamar pra nao ter que escrever varias vezes, sou preguiçoso
    }
    public void Playjump()
    {
        Jump.Play();
    }

    public void CreatDust()
    {
        dust.Play();
    }
}
