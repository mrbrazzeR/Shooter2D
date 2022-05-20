using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxolotBullet : EnemyBullet
{
    // Start is called before the first frame update
    void Start()
    {
        speedBullet = 1.5f;
        damage = 3;
    }

}
