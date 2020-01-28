using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveVelma : MonoBehaviour
{
    Rigidbody2D rb;
	private float axis;
	Vector2 velocidade;
	bool ladoDireito = true;
	public float MaxVelocidade = 10;
	

	
	void Start () {
		rb = GetComponent<Rigidbody2D>();	
	}

	void Update () {
		
		andar();
		
	}

	public void Vire(){
		ladoDireito = !ladoDireito;

		transform.Rotate(0f, 180f, 0f);
		
		}

	void andar()
	{
			axis = Input.GetAxis("Horizontal");
			if (axis > 0 && !ladoDireito)
			Vire ();
			if (axis < 0 && ladoDireito)
			Vire ();
		
		velocidade = new Vector2 (axis * MaxVelocidade, rb.velocity.y);
	
		rb.velocity = velocidade;
	}

	void OnTriggerEnter2D (Collider2D col){
		if (col.CompareTag("dead")){
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
}
