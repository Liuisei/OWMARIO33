using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;

public class EnemyCuriboo : EnemyBase
{
    [SerializeField] GameObject curiboo2;
    public override void StapOn()
    {
        GameObject newkoura = Instantiate(curiboo2, transform);
        newkoura.transform.parent = null;
        Debug.Log(newkoura);
        Destroy(gameObject);
    }

}
