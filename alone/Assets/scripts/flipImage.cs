using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipImage : MonoBehaviour
{
    public int boy = 1;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        //fliping the 2d left and right
        if (horizontalInput < 0f) // input ranges from -1 to 1, positive being right side
            if(boy == 1)
                spriteRenderer.flipX = false;
            else
                spriteRenderer.flipX = true;//picture default move left(do nothing)
        else if (horizontalInput >= 0f) 
            if(boy == 1)
                spriteRenderer.flipX = true;
            else
                spriteRenderer.flipX = false; //flip image when move right hence change x to -
    }
}
