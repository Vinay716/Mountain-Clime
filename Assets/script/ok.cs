using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ok : MonoBehaviour
{
    private Transform player;
    [SerializeField]
    private float minX, maxX;
    private Vector3 tempPos;
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
       
    }

    private void LateUpdate()
    {
        tempPos = transform.position;
        tempPos.x = player.position.x;
        tempPos.y = player.position.y;

        if (tempPos.x < minX)
            tempPos.x = minX;
        else if (tempPos.x > maxX)
            tempPos.x = maxX;

        transform.position = tempPos;
       

    }
}
