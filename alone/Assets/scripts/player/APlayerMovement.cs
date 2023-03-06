using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APlayerMovement : MonoBehaviour
{
    [SerializeField]private float speed;
    private Rigidbody2D body;

    //for jump
    private bool grounded;
    
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2 (horizontalInput * speed, body.velocity.y);

        //jump
        if (Input.GetKey(KeyCode.Space) && (grounded)) {
            Jump(); }
        
    }

    //for jump//
    private void Jump() {
        body.velocity = new Vector2(body.velocity.x,speed);
        grounded = false; } 
    private void OnCollisionStay2D(Collision2D collision) { 
        if (collision.gameObject.tag == "Ground") {
            grounded = true;}
    }


}
