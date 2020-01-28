using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animacao : MonoBehaviour
{
    Animator anima;
    void Start()
    {
        anima = GetComponent<Animator>();
    }

    
    void Update()
    {
        if ((Input.GetKey(KeyCode.LeftArrow)) || (Input.GetKey(KeyCode.RightArrow))){
            anima.SetBool("andou", true);
        }
        else{
            anima.SetBool("andou", false);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow)){
            anima.SetTrigger("pulou");
        }
    }
}
