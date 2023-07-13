using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MushroomController : ItemBase
{
    [SerializeField] float _moveSpeed = 2;
    Rigidbody2D _rb;
    int _dirX = 1;

    public override void GetItem()
    {
        Debug.Log("ƒLƒmƒR‚ðŽæ‚Á‚½");
    }

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _rb.velocity = new Vector2(_moveSpeed * _dirX, _rb.velocity.y);

        Vector2 start = transform.position;
        Vector2 end = start + Vector2.right * _dirX * 0.51f;
        Debug.DrawLine(start, end);
        if (Physics2D.Linecast(start, end, 1))
        {
            _dirX *= -1;
        }
    }
}
