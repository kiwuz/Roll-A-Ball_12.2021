using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    private Transform player;
    public Vector3 offset;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        offset = player.position - transform.position;
    }

    void Update()
    {
        
        transform.position = player.position - offset;
        transform.LookAt(player);

    }

}
