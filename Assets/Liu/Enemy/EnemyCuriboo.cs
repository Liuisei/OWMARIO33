using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;

public class EnemyCuriboo : EnemyBase
{
    [SerializeField] GameObject curibooStapOn;

    [SerializeField] GameObject curibooGetDamage;
    public override void StapOn()
    {
        GameObject newkoura = Instantiate(curibooStapOn, transform);
        newkoura.transform.parent = null;
        Debug.Log(newkoura);
        Destroy(gameObject);
    }
}
