using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float attackRate = 0.5f;
    public Animator animator;
    public Transform firePoint;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(showBullet());
    }

    // Update is called once per frame
    protected virtual void Attack()
    {
        animator.SetBool("isAttack", true);
        addBullet();
    }
    private void addBullet()
    {
        GameObject _bullet=(GameObject)Instantiate(bulletPrefab,firePoint.position,Quaternion.identity);
        Bullet bullet = _bullet.GetComponent<Bullet>();
         
    }
    IEnumerator showBullet() {
        while (true)
        {
            yield return new WaitForSeconds(attackRate);
            Attack();
        }
    }
}
