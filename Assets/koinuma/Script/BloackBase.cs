using UnityEngine;

public abstract class BlockBase : MonoBehaviour
{
    bool _hit;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!_hit && collision.gameObject.name == "Player")
        {
            HitBottom();
            collision.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            _hit = true;
        }
    }

    public abstract void HitBottom();
}
