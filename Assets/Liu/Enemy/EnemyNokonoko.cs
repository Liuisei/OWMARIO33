using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class EnemyNokonoko : EnemyBase
{ 
    enum Nokonoko
    {
        nokonoko,
        koura,
    }

    Nokonoko nokonokoenum = Nokonoko.nokonoko;
    public override void StapOn()
    {
        if(nokonokoenum == Nokonoko.nokonoko)
        {
            nokonokoenum = Nokonoko.koura;
        }
    }

    public void SetKoura()
    {
        
    }
}
