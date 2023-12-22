using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 1.0f;
    private float horizantalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveGameObject();
    }
    private void MoveGameObject()
    {
        horizantalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.transform.Translate(Vector2.right * horizantalInput * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            rb.transform.Translate(Vector2.up * verticalInput * Time.deltaTime * moveSpeed);
        }
        //rb.velocity = Vector2.zero;
        //rb.velocity = new Vector2(direction * Time.fixedTime * moveSpeed, 0);

    }
}
