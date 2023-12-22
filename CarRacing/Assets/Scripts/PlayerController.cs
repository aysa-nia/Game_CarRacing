using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 1.0f;
    private float direction;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");


    }
    private void FixedUpdate()
    {
        rb.velocity = Vector2.zero;
        rb.velocity = new Vector2(direction * Time.fixedTime * moveSpeed, 0);
    }
}
