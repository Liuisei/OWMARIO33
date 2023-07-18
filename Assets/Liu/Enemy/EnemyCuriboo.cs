using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyCuriboo : MonoBehaviour
{
    [SerializeField] float _moveSpeed = 2;
    Rigidbody2D _rb;
    int _dirX = 1;

  

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _rb.velocity = new Vector2(_moveSpeed * _dirX, _rb.velocity.y);

        Vector2 start = transform.position;
        start += Vector2.right * _dirX * 0.509f;
        Vector2 end = start + Vector2.right * _dirX * 0.01f;
        Debug.DrawLine(start, end);
        if (Physics2D.Linecast(start, end, 1) )
        {
            _dirX *= -1;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.TryGetComponent<PlayerController>(out PlayerController pc))
        {
            Destroy(gameObject,1);
        }
    }
}
