using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCoin : MonoBehaviour
{
    [SerializeField]
    private AudioSource coletouIten;
    void OnTriggerEnter2D (Collider2D obj){
        if(obj.CompareTag("Player")){
        coletouIten.Play();

        }
    }
}
