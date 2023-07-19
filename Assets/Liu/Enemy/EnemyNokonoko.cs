using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class EnemyNokonoko : EnemyBase
{
    [SerializeField] GameObject koura;

    public override void StapOn()
    {
        Instantiate(koura,transform);
        koura.transform.SetParent(null);
    }

}
