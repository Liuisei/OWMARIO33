using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb;

    [SerializeField] int jampSpeed = 10;
    [SerializeField] int moveSpeed = 10;
    [SerializeField] float raycastRenge = 1.1f;




    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump") && Ground())
        {
            rb.AddForce(Vector2.up * jampSpeed , ForceMode2D.Impulse);
        }
    }
    private void FixedUpdate()
    {
    
        float h = Input.GetAxisRaw("Horizontal"); // 水平方向の入力を検出する

        // 入力に応じてパドルを水平方向に動かす
        rb.AddForce(new Vector2(h * moveSpeed, 0),ForceMode2D.Force);
         
    }
    bool Ground()
    {
        Vector2 start = this.transform.position;
        Vector2 end = start + Vector2.down * raycastRenge;

        bool isGround = Physics2D.Linecast(start, end,1);

        return isGround;
    }



}
