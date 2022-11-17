using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salto : MonoBehaviour
{
    private Rigidbody rb;             //rigibody de la esfera

    public float jumpHeight = 100;    // fuerza de salto

    public bool grounded;             //indica si esta en el suelo

    public LayerMask Mask;            //layer de suelo para detectar si esta en el suelo

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        CheckGround();

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            Jump();
            rb.mass = 1;
        }   
       
    }

    private void CheckGround()
    {
        RaycastHit hitInfo = new RaycastHit();
        Debug.DrawRay(transform.position, Vector3.down * 1.2f, Color.red);

        if (Physics.Raycast(transform.position, Vector3.down, out hitInfo, 1.2f, Mask))
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }
    }

    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpHeight);
        
    }
}