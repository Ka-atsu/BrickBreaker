using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public float maxX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        if (x == 0)
        {
            idle();
        }
        if (x < 0)
        {
            moveLeft();
        }
        if (x > 0)
        {
            moveRight();
        }
        limitSpace();
    }
    void limitSpace()
    {
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -maxX, maxX);
        transform.position = pos;
    }
    void moveLeft()
    {
        rb.velocity = new Vector2(-speed, 0);
    }

    void moveRight()
    {

        rb.velocity = new Vector2(speed, 0);
    }

    void idle()
    {
        rb.velocity = Vector2.zero;
    }
}
