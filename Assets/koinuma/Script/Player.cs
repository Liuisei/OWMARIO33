using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D _rb;
    float moveSpeed = 10;
    float jumpPower = 10;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        _rb.velocity = new Vector2(h * moveSpeed, _rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            _rb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        }
    }
}
