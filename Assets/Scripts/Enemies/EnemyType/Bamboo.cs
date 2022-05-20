using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bamboo : Enemy
{
    void Start()
    {
        enemySpeed = 1f;
        attackRate = 4f;
        maxHealth = 100;
        health = 100;
        score = 3;
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
