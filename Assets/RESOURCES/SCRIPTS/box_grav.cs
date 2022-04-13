using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box_grav : MonoBehaviour
{
    public int gravity;
    public Rigidbody box_Rigidbody;

    public Transform BOX;
    public Vector3 boxStartPosition;

    void Start()
    {

    box_Rigidbody = GetComponent<Rigidbody>();
    gravity = 4;
    savePosition();
        
    }
    void Update()
    {
        GravityHandler();
        CheckHeight();
    }

 
    void GravityHandler()
    {
       box_Rigidbody.AddForce(Vector3.down * gravity * box_Rigidbody.mass);
    }


    void CheckHeight(){
        if (box_Rigidbody.position.y <= 10){
            box_Rigidbody.position = boxStartPosition;
            box_Rigidbody.velocity = Vector3.zero;
        }
    } 

    void savePosition(){
        boxStartPosition = BOX.position;
    }

}
