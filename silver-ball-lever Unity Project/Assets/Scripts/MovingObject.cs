using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{

    public float moveSpeed = 1f;
    private Rigidbody2D rigidbody;
    private float verticalInput;
    public string inputAxis;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        
    }

    /*use fixed update for physics code to be careful
   * about how often we call expensive, hardcore intersive 
   * physics stuff */
    private void Update()
    {
        verticalInput = Input.GetAxis(inputAxis);
    }
    private void FixedUpdate()
    {
        if (!GameOver.isGameOver)
        rigidbody.velocity = new Vector2(0, verticalInput * moveSpeed);


    }
}
