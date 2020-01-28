using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    public float movespeed = -5f;
    void Start()
    {
        Destroy(gameObject, 9f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2 (transform.position.x + movespeed * Time.deltaTime, transform.position.y);
    }
}
