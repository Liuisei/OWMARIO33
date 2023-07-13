using UnityEngine;

[RequireComponent (typeof(Collider2D))]
/// <summary>アイテムのベースとなるスクリプト</summary>
public abstract class ItemBase : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            GetItem();
            Destroy(gameObject);
        }
    }

    public abstract void GetItem();
}
