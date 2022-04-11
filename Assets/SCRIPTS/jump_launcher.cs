using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump_launcher : MonoBehaviour
{
    public MovementController MC;

    void Start()
    {
        
        MC = FindObjectOfType<MovementController>();
    
    }


    void OnTriggerEnter(Collider collision){

           Vector3 rocketJumpVector = new Vector3(0f, 40f, 0f);
            MC.m_Rigidbody.velocity = MC.m_Rigidbody.velocity + rocketJumpVector; 
        
    }


}
