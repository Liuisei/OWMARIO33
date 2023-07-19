using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;

public class EnemyCuriboo : EnemyBase
{
    public override void StapOn()
    {
        Destroy(gameObject);
    }
}
