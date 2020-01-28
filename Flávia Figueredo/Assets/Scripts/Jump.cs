using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
	Rigidbody2D rb;
	public bool isGround;
	public float jumpForce;
	private int extrajump;
	public int extrajumpValue;
    public AudioSource pulo;

	void Start () {
		extrajump = extrajumpValue;
		rb = GetComponent<Rigidbody2D>();
	}

    void Update(){
        pular();
    }

    public void pular(){
		
		
		if (isGround == true){
				extrajump = extrajumpValue;
			}
			
		if (Input.GetKeyDown(KeyCode.UpArrow) && extrajump > 0){
				rb.velocity = Vector2.up * jumpForce;
				extrajump--;
                pulo.Play();
				}	
	}

	public void OnCollisionEnter2D (Collision2D obj){
		if (obj.gameObject.CompareTag("chao")){
			isGround = true;
			
		}
	}

	public void OnCollisionExit2D (Collision2D obj){
		if (obj.gameObject.CompareTag("chao")){
			isGround = false;
		}
	}
}
