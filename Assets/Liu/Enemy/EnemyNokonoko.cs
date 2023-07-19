using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class EnemyNokonoko : EnemyBase
{
    [SerializeField] GameObject _koura;
 
    bool _iskoura = false;
    public override void StapOn()
    {
        _iskoura = true;
        base.StapOn();
    }
}
