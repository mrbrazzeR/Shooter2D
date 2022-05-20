using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speedBullet = 10f;
    public float damage = 10;
    public GameObject target;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, speedBullet * Time.deltaTime, 0));
        if (transform.position.y >= Camera.main.ViewportToWorldPoint(new Vector2(1, 1)).y)
        {
            Destroy(gameObject);
        }
    }
    public void hitTarget()
    {
        target.gameObject.GetComponent<Enemy>().TakeDamage(damage);
    }
}
