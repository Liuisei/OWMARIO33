using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemBlockController : BlockBase
{
    /// <summary>叩いたときに出てくるアイテム</summary>
    [SerializeField] GameObject _item;
    /// <summary>叩かれた後のスプライト</summary>
    [SerializeField] Sprite _onHitSprite;
    Vector3 _itemPosition;

    private void Start()
    {
        if (_item)
        {
            _itemPosition = transform.position + Vector3.up;
        }
    }

    public override void HitBottom()
    {
        Instantiate(_item, _itemPosition, _item.transform.rotation);
        if (_onHitSprite != null)
        {
            GetComponent<SpriteRenderer>().sprite = _onHitSprite;
        }
        else
        {
            GetComponent<SpriteRenderer>().color = new Color(0.3f, 0.17f, 0, 1);
        }
    }
}
