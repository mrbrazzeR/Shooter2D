using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speedBullet;
    public int damage;

    // Update is called once per frame
    public void Update()
    {
        bulletMoving();
    }
    public void bulletMoving()
    {
        transform.Translate(new Vector3(0, -(speedBullet * Time.deltaTime), 0));
        if (transform.position.y <= Camera.main.ViewportToWorldPoint(new Vector2(0, 0)).y)
        {
            Destroy(gameObject);
        }
    }
    
}
