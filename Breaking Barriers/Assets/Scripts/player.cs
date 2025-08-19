using UnityEngine;

public class Player : MonoBehaviour

{


    private float horizontal;

    private float vertical;

    public float speed;

    Rigidbody2D body;


    void Start()

    {

        body = GetComponent<Rigidbody2D>();

    }


    void Update()

    {

        horizontal = Input.GetAxisRaw("Horizontal");

        vertical = Input.GetAxisRaw("Vertical");

        body.linearVelocity = new Vector2(horizontal, vertical) * speed;

        {

        }


    }
}

