using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed;
    private bool MoverDireita;
    public Transform DetChao;
    public float distancia;
    public AudioSource Enemy;
   
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        //aqui e so para ele andar no eixo x

        RaycastHit2D chaoInfo = Physics2D.Raycast(DetChao.position, Vector2.down, distancia);
        //Aqui serve pra atirar o Raycast em direção ao chão na distancia que eu quiser com base na distancia

        if (chaoInfo.collider == false)
        {
            //se o raycast náo detectar chao
            if (MoverDireita == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                MoverDireita = false;
                //se ele estiver se movendo pra direita, vai pra esquerda
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                MoverDireita = true;
                //e vice versa
            }
        }
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == ("Player"))
        {
            PlayEnemy();
        }
    }
    public void PlayEnemy()
    {
        Enemy.Play();
    }
}
