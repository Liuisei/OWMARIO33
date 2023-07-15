using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFlowerController : ItemBase
{
    public override void GetItem()
    {
        GameObject.Find("Player").GetComponent<PlayerStateController>().GetFireFlower();
    }
}
