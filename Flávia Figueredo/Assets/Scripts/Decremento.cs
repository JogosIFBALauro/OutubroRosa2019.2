using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decremento : MonoBehaviour
{
    
        public GameObject levelJunk;
        [SerializeField]
        /*private AudioSource coletouItem;*/

        private void OnTriggerEnter2D(Collider2D colisao)
        {

            if (colisao.CompareTag("Player"))
            {
                levelJunk.GetComponent<LevelManager>().foodPontos -= 5;
                Destroy(gameObject);
            }
        }

    

}
