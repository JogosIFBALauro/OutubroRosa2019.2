using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMov : MonoBehaviour
{
    private Vector2 velocity;
    public float STimeY;
    public float STimeX;
    public Vector2 minimumBoundary;
    public Vector2 maximumBoundary;

    public GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, STimeX);
        float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y, STimeY);

        transform.position = new Vector3(posX, posY, transform.position.z);

        //Uma pequena formulinha pra camera seguir o objeto com a tag de player, a matematica e linda.
    }

    void Update()
    {
        transform.position = new Vector3
        (
     Mathf.Clamp(transform.position.x, minimumBoundary.x, maximumBoundary.x),
     Mathf.Clamp(transform.position.y, minimumBoundary.y, maximumBoundary.y),
     transform.position.z
        );
        //Aqui foi quase igual ao codigo de cima, mas para definir um limite na camera com base nos valores publicos acima.
    }
}
