using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataform : MonoBehaviour
{
    public Transform pos1, pos2;
    private float speed;
    public Transform StartPos;

    Vector3 nextPos;
    void Start()
    {
        nextPos = StartPos.position;
        speed = 2000;
        //tive que colocar esse valor absurdo por conta de um bug
    }
    void Update()
    {
        if(transform.position == pos1.position)
        {
            nextPos = pos2.position;
            speed = 5;
        }

        if(transform.position == pos2.position)
        {
            nextPos = pos1.position;
            speed = 5;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed*Time.deltaTime);
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos1.position, pos2.position);
    }
}