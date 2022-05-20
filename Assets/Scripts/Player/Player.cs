using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int playerHealth;
    public static int playerScore;
    public int health;
    private void Start()
    {
        playerHealth = health;
        playerScore = 0;
    }
    private void Update()
    {
        if(playerHealth<=0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col != null)
        {
            if (col.tag == "EnemyBullet")
            {
                playerHealth -= col.GetComponent<EnemyBullet>().damage;
                Destroy(col.gameObject);
            }
            if (col.tag == "Enemy")
            {
                playerHealth -= 10;
            }
        }
    }
}
