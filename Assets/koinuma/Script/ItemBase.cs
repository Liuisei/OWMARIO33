using UnityEngine;

[RequireComponent (typeof(Collider2D))]
/// <summary>�A�C�e���̃x�[�X�ƂȂ�X�N���v�g</summary>
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
