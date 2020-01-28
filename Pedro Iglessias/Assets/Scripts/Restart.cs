using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private Scene scene;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
        //Pegar a cena ativa e armazenar em uma variavel cena pra poder chamar sempre.
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == ("Player"))
        {
            SceneManager.LoadScene(scene.name);
            //Quando colidir com um objeto que possua a tag player, ele chamara a cena ativa
        }
    }
}
