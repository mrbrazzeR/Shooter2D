using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public abstract class Enemy : MonoBehaviour
{
    public float enemySpeed;
    public float attackRate;
    public float health;
    public float maxHealth;
    public int score;
    public Transform attackPoint;
    public GameObject enemyBulletPrefab;

    public Image healthBar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,-(enemySpeed * Time.deltaTime), 0);
        if (transform.position.y < Camera.main.ViewportToWorldPoint(new Vector2(0, 0)).y)
        {
            Destroy(gameObject);
        }
    }
    protected abstract void Attack();
    protected abstract IEnumerator addBullet();
    public void TakeDamage(float damage)
    {
        health -= damage;      
        if (health <= 0)
        {
            Player.playerScore += score;
            Destroy(gameObject);
        }
        healthBar.fillAmount = health / maxHealth;
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col != null)
        {
            if (col.CompareTag("Bullet"))
            {
                TakeDamage(col.GetComponent<Bullet>().damage);
                Destroy(col.gameObject);
            }
            if (col.CompareTag("Player"))
            {
                Destroy(gameObject);
            }
        }
    }
}
