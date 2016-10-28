using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{

    public float speed = 800;
    private Rigidbody2D rb2d;


    void Awake()
    {
        if (transform.localScale.x > 0)
            speed = 600;
        else
            speed = -600;
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce( new Vector2(speed,0 ));

    }
    void Update()
    {

       
    }
}