using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class EnemyBase : MonoBehaviour
{
    [SerializeField] float _moveSpeed = 2;
    public Rigidbody2D _rb;
    int _dirX = 1;
    public bool _stop;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (!_stop)
        {
            _rb.velocity = new Vector2(_moveSpeed * _dirX, _rb.velocity.y);
            Vector2 start = transform.position;
            start += Vector2.right * _dirX * 0.509f;
            Vector2 end = start + Vector2.right * _dirX * 0.01f;
            Debug.DrawLine(start, end);
            if (Physics2D.Linecast(start, end, 1))
            {
                _dirX *= -1;
            }
        }
        if (_dirX != 0)
        {
            this.transform.localScale = new Vector3(_dirX*-1, 1, 1);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.TryGetComponent<PlayerController>(out PlayerController pc))
        {

            StapOn();
            pc.Jump();
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.TryGetComponent<PlayerStateController>(out PlayerStateController PSC))
        {
            PSC.GiveDamage();
        }
    }


    public virtual void GetDamage()
    {
        Collider2D[] Colliders = GetComponents<Collider2D>();

        foreach (Collider2D col in Colliders)
        {
            Destroy(col);
        }
        _rb.AddForce(transform.up * 100);
        Destroy(gameObject, 3);
    }


    public abstract void StapOn();
 
}
