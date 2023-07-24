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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GiveDamage(collision);

    }
    public void GiveDamage(Collision2D collision)
    {
        if (!_stop)
        {
            if (collision.transform.TryGetComponent<EnemyBase>(out EnemyBase enemyBase))
            {
                enemyBase.GetDamage();
                Debug.Log(name + collision + "godamege");
            }
        }

    }
}
