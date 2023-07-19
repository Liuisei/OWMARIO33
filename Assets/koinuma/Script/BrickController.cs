using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickController : BlockBase
{
    [SerializeField] bool _canBreak = true;
    [SerializeField] Sprite _onHitSprite;
    [SerializeField] GameObject _breakEffect;

    public override void HitBottom()
    {
        if (_canBreak)
        {
            if (_breakEffect)
            {
                GameObject effect = Instantiate(_breakEffect);
                effect.transform.position = this.transform.position;
            }
            Destroy(gameObject);
        }
        else if (_onHitSprite != null)
        {
            GetComponent<SpriteRenderer>().sprite = _onHitSprite;
        }
        else
        {
            GetComponent<SpriteRenderer>().color = new Color(0.3f, 0.17f, 0, 1);
        }
    }
}
