using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MovementController : MonoBehaviour
{

    public float SpeedMovement;
    public Rigidbody m_Rigidbody;
    public Vector3 movement;
    public Vector3 jump;

    private bool isGrounded;

    private float jumpHeight;

    private float gravity;

    void Start()
    {
       m_Rigidbody = GetComponent<Rigidbody>();
       SpeedMovement = 4.00f;
       jumpHeight = 16.5f;
       gravity = 12.5f;

    }

    private void FixedUpdate()
    {
        GravityHandler();
        PlayerMovement();
    }


    void PlayerMovement(){

        //WSAD
        float HorizontalMovement = Input.GetAxis("Horizontal");
        float VerticalMovement = Input.GetAxis("Vertical");
        Vector3 movement  = new Vector3(HorizontalMovement, 0.0f, VerticalMovement).normalized;
        m_Rigidbody.AddForce(movement * SpeedMovement,ForceMode.Impulse);

        //shift
        if (Input.GetKey(KeyCode.LeftShift) == true ){

            SpeedMovement = 0.1f;
        }
        else if (Input.GetKey(KeyCode.LeftShift) == false) {
            SpeedMovement = 0.5f;

        }
        else SpeedMovement = 1.75f;

        
        //JUMPING
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1f);

        if (Input.GetKeyDown ("space") && isGrounded == true){
            Vector3 jumpVector = new Vector3(0f, jumpHeight, 0f);
            m_Rigidbody.velocity = m_Rigidbody.velocity + jumpVector;        
        }

    }

    void GravityHandler()
    {
       m_Rigidbody.AddForce(Vector3.down * gravity * m_Rigidbody.mass);
    }
} 


