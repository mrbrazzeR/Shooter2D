using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : Enemy
{
    void Start()
    {
        enemySpeed = 1f;
        attackRate = 3f;
        health = 40;
        maxHealth = 40;
        score = 1;
        StartCoroutine(addBullet());
    }
    protected override void Attack()
    {
        GameObject _bullet = (GameObject)Instantiate(enemyBulletPrefab, attackPoint.position, Quaternion.identity);
        EnemyBullet bullet = _bullet.GetComponent<EnemyBullet>();
    }
    protected override IEnumerator addBullet()
    {
        while (true)
        {
            yield return new WaitForSeconds(attackRate);
            Attack();
        }
    }

}
