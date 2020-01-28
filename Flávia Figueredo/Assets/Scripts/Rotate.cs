using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        
        speed = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(new Vector3(0, speed * transform.position.y, transform.position.z));
    }
}
