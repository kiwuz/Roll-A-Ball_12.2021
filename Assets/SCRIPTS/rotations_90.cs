using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotations_90 : MonoBehaviour
{

    public int rotation_speed;

    void Update()
    {
        transform.Rotate(0 * Time.deltaTime,0* Time.deltaTime,rotation_speed* Time.deltaTime);   

    }
}
