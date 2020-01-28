using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mensagem1 : MonoBehaviour
{
    public Text texto;
    [Range (0.1f,10.0f)] public float distance=3;
    private GameObject jogador;

    // Start is called before the first frame update
    void Start()
    {
        texto.enabled = false;
        jogador = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, jogador.transform.position) < distance)
        {
            texto.enabled = true;
        }
        else
        {
            texto.enabled = false;
        }
    }
}
