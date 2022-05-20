using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public List<GameObject> positionSpawn;
    public List<GameObject> enemySpawn;
    public float spawnTime = 0.1f;
    public float cooldown = 0.1f;
    void Start()
    {
        spawnTime = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(spawnWave());
    }

    IEnumerator spawnWave()
    {
        if(cooldown<=0f)
        {
            spawn();
            cooldown = spawnTime;
            yield return new WaitForSeconds(spawnTime);
        }
        cooldown-=Time.deltaTime;
    }
    protected virtual void spawn()
    {
        GameObject positionToSpawn = positionSpawn[Random.Range(0, positionSpawn.Count-1)];
        GameObject enemy = Instantiate(enemySpawn[Random.Range(0, enemySpawn.Count - 1)], positionToSpawn.transform.position, Quaternion.identity);
    }
}
