using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlane : MonoBehaviour
{

    public float moveSpeed = 6.0f;
    private float moveInput;
    private float moveInput2;
    public Rigidbody Rigidbody;


    public bool secondLife = false;

    

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        moveInput2 = Input.GetAxisRaw("Vertical");

        Rigidbody.velocity = new Vector3(moveInput * moveSpeed, moveInput2 * moveSpeed, 0);

        //Rigidbody.velocity = new Vector3(moveInput2 * moveSpeed, Rigidbody.velocity.y, 0);
        //Rigidbody.velocity = new Vector3(moveInput * moveSpeed, Rigidbody.velocity.x, 0);
    }
}
