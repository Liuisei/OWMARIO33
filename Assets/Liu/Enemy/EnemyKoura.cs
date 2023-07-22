using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKoura : EnemyBase
{
    public override void StapOn()
    {
        if (!_stop)
        {
            _stop = true;
            _rb.velocity = new Vector2(0,0);
        }
        else
        {
            _stop = false;
        }
    }
}
