using UnityEngine;

public class FireBallController : MonoBehaviour
{
    [SerializeField] float _speed = 10;
    float bounsPower = 8;
    Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _speed *= Mathf.Sign(GameObject.Find("Player").transform.localScale.x); 
    }

    private void Update()
    {
        Vector2 velo = new Vector2(_speed, _rb.velocity.y);
        _rb.velocity = velo;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _rb.AddForce(Vector2.up * bounsPower, ForceMode2D.Impulse);
    }
}
