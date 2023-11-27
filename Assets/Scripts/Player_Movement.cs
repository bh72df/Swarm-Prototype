using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
[RequireComponent(typeof(InputManager))]




public class PlayerController: MonoBehaviour
{

    [SerializeField] private Transform cameraOrientation; 

    private InputManager InputM;
    public float speed = 5.0f;
    public float mouseSensetivity = 2f;
    private CharacterController characterController;
    private Rigidbody rb;

    private Vector3 movedirection;

    private void Start()
    {
        InputM = GetComponent<InputManager>();
        rb = GetComponent<Rigidbody>(); 
        rb.freezeRotation = true;


    }

    private void Update()
    {
        speedcontroller();

    }
    
    private void speedcontroller()
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
        if (flatVel.magnitude > speed) 
        {
            Vector3 limitedVel = flatVel.normalized * speed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }
    }

    private void  FixedUpdate()
    {

        movedirection = cameraOrientation.forward * InputM.move.y + cameraOrientation.right * InputM.move.x;
        movedirection.y = 0f;
        rb.AddForce(movedirection.normalized * speed * 10f, ForceMode.Force);



        
       
    }
}
