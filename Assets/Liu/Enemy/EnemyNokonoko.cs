using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class EnemyNokonoko : EnemyBase
{
    [SerializeField] GameObject koura;
    [SerializeField] Transform kouratTransform;
    public override void StapOn()
    {
        GameObject newkoura = Instantiate(koura,transform);
        newkoura.transform.parent = null;
        Debug.Log(newkoura);
        Destroy(gameObject);
    }

}
