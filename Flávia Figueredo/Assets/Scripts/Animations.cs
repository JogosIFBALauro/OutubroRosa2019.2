using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        if ((Input.GetKey(KeyCode.LeftArrow) || (Input.GetKey(KeyCode.RightArrow)))){
            
            anim.SetBool("isRun", true);
        }
        else{
            anim.SetBool("isRun", false);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow)){
            anim.SetTrigger("jumping");
        }
    }
}
