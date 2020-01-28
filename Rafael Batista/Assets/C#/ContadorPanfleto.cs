using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorPanfleto : MonoBehaviour
{
    [SerializeField]
    private Text panfletoCounter;
    public int collidPanfletoValue;
    private int panfletoAmount;
    //public AudioSource coletouItem;

    void Start()
    {
        panfletoAmount = 0;
    }

    
    void OnTriggerEnter2D(Collider2D col){
        if (col.CompareTag("panfleto")){
                collidPanfletoValue = col.gameObject.GetComponent<ValorPanfleto>().panfletoValue;
                panfletoAmount += collidPanfletoValue;
                Destroy(col.gameObject);
                //coletouItem.Play();
        }
        
    }
    void Update()
    {
        panfletoCounter.text = "Panfletos Entregues: " + panfletoAmount;
    }

}
