using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UP_DOWN_walls : MonoBehaviour
{

    private float wallSpeed = 3f;

    Rigidbody walls_rb;

    void Update()
    {

         float y = Mathf.PingPong(Time.time * wallSpeed, 6 ) * 8;
         transform.position = new Vector3(transform.position.x, y, transform.position.z);

    }
}
