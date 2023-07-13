using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickController : BlockBase
{
    [SerializeField] bool _canBreak = true;
    [SerializeField] Sprite _onHitSprite;

    public override void HitBottom()
    {
        if (_canBreak)
        {
            Destroy(gameObject);
        }
        else if (_onHitSprite != null)
        {
            GetComponent<SpriteRenderer>().sprite = _onHitSprite;
        }
    }
}
