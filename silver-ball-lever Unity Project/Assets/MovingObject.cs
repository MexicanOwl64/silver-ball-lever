using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{

    public float moveSpeed = 0.1f;
    private Rigidbody2D rigidbody;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        
    }

    /*use fixed update for physics code to be careful
   * about how often we call expensive, hardcore intersive 
   * physics stuff */

    private void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");
        rigidbody.velocity = new Vector2(0, verticalInput);


    }
}
