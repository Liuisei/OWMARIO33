using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickController : MonoBehaviour
{
    [SerializeField] bool _canBreak = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_canBreak)
        {
            Destroy(this.gameObject);
            collision.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }
    }
}
