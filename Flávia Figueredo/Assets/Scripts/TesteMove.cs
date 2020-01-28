using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TesteMove : MonoBehaviour
{
    Animator animator;
	Rigidbody2D rb;
	public float axis;
	Vector2 velocidade;
	bool ladoDireito = true;
	public bool isGround;
	public Transform groundCheck;
	public float checkRadius;
	public LayerMask whatIsGround;
	public float jumpForce;
	private int extrajump;
	public int extrajumpValue;
	public float MaxVelocidade = 10;
    public AudioSource pulo;
	bool andou;
	bool pulou;

	GameObject levelitens;

	// Use this for initialization
	void Start () {
		extrajump = extrajumpValue;
		animator = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody2D>();
		andou = false;
		pulou = false;
	}

	void FixedUpdate()
	{
		

	}

	// Update is called once per frame
	void Update () {
		
		axis = Input.GetAxis ("Horizontal");

		if (axis > 0 && !ladoDireito)
			Vire ();
		if (axis < 0 && ladoDireito)
			Vire ();
		
		velocidade = new Vector2 (axis * MaxVelocidade, rb.velocity.y);
        animator.SetFloat ("Velocidade", Mathf.Abs(axis));

		rb.velocity = velocidade;
		
		
		pular();
	}

	public void Vire(){
		ladoDireito = !ladoDireito;

		transform.Rotate(0f, 180f, 0f);
		
		}
	public void pular(){
		
		isGround = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
		if (isGround == true){
				extrajump = extrajumpValue;
			}
			
			if (Input.GetKeyDown(KeyCode.UpArrow) && extrajump > 0){
				rb.velocity = Vector2.up * jumpForce;
				extrajump--;
                pulo.Play();
				//animator.SetFloat ("Vel", Mathf.Abs(axis));
				animator.SetBool ("pulou", true);
				
								
				}
						
			
	}

	

	/*void OnTriggerEnter2D (Collider2D col){
		if (col.CompareTag("junkfood")){
			Debug.Log("Comida ruim!");
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}*/

	
}