using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FoodHealth : MonoBehaviour
{
    
    public GameObject levelItens;
    [SerializeField]
    /*private AudioSource coletouItem;*/

    private void OnTriggerEnter2D(Collider2D colisao)
    {
        
        if (colisao.CompareTag("Player"))
        {
            
            levelItens.GetComponent<LevelManager>().food++;
            levelItens.GetComponent<LevelManager>().foodPontos += 5;
            Destroy(gameObject);
            
            
        
            
        }
        if (colisao.CompareTag("junkfood"))
        {
            levelItens.GetComponent<LevelManager>().foodPontos -= 5;
            Destroy(gameObject);
        }
    }

    
}
