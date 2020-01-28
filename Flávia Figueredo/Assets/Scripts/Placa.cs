using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Placa : MonoBehaviour
{
    public GameObject dialogBox;
    public Text dialogText;
    public string dialog;
    public bool playerInRange;
    void Start()
    {
        dialogBox.SetActive(false);
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerInRange){
            if (dialogBox.activeInHierarchy){
                dialogBox.SetActive(false);
            }
            else{
                dialogBox.SetActive(true);
                dialogText.text = dialog;
            }
        }
    }

    void OnTriggerEnter2D (Collider2D obj){
        if (obj.CompareTag("Player")){
            playerInRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D obj){
        if (obj.CompareTag("Player")){
            playerInRange = false;
            dialogBox.SetActive(false);
        }
    }
}
