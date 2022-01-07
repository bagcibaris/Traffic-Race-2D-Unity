using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;

    public float speed;
    public AudioSource carMoveUD;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        Boundry();
    }

    void Boundry()
    {
        Vector2 temp = transform.position;
        if (temp.x < -1)
        {
            temp.x = -1;
            transform.position = temp;
        }
        if (temp.x > 1)
        {
            temp.x = 1;
            transform.position = temp;
        }
        if (temp.x < -2.2f)
        {
            temp.x = -2.2f;
            transform.position = temp;
        }
        if (temp.x > 2.2f)
        {
            temp.x = 2.2f;
            transform.position = temp;
        }
    }
    public void Left()
    {
        Vector2 temp = transform.position;
        temp.x -= 1;
        transform.position = temp;
    }

    public void Right()
    {
        Vector2 temp = transform.position;
        temp.x += 1;
        transform.position = temp;
    }

    public void Up()
    {
        rb.velocity = new Vector2(0, speed * Time.deltaTime);
        carMoveUD.Play();

    }

    public void Down()
    {
        rb.velocity = new Vector2(0, (-1) * speed * Time.deltaTime);
        carMoveUD.Play();
    }

    public void Stop()
    {
        carMoveUD.Stop();
        rb.velocity = new Vector2(0, 0);
        
    }
}
