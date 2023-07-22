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
            Jump();
        }
    }


    public void Jump()
    {


        rb.velocity = new Vector2 ( 0,1*jampSpeed );
        
    }
    private void FixedUpdate()
    {
    
        float h = Input.GetAxisRaw("Horizontal"); // …•½•ûŒü‚Ì“ü—Í‚ğŒŸo‚·‚é

        // “ü—Í‚É‰‚¶‚Äƒpƒhƒ‹‚ğ…•½•ûŒü‚É“®‚©‚·
        rb.AddForce(new Vector2(h * moveSpeed, 0),ForceMode2D.Force);

 

        if(h !=0)
        {
            this.transform.localScale = new Vector3(h, 1, 1);
        }
        
        

    }
    bool Ground()
    {
        Vector2 start = this.transform.position;
        Vector2 end = start + Vector2.down * raycastRenge;

        bool isGround = Physics2D.Linecast(start, end,1);

        return isGround;
    }



}
