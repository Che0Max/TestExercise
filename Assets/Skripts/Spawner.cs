
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Spawner : MonoBehaviour
{
    [SerializeField]
    public GameObject Small;
    [SerializeField]
    public GameObject Medium;
    [SerializeField]
    public GameObject Large;

    private float GameTime;

    //¬еро€тность спавна определенного типа
    float timeSpawn = 2f;
    int chance;

    private float nextTime = 0.0f;

    void Update()
    {
        GameTime += Time.deltaTime;
        while (Time.time > nextTime)
        {
            chance = Random.Range(0, 100);
            nextTime = Time.time + timeSpawn;
            if (chance < 10)
            {
                StartCoroutine(spawnEnemy(timeSpawn, Large));
            }
            if (chance >= 10 && chance <= 30)
            {
                StartCoroutine(spawnEnemy(timeSpawn, Medium));
            }
            if (chance > 30)
            {
                StartCoroutine(spawnEnemy(timeSpawn, Small));
            }
        }

        
        if (GameTime > 10 && timeSpawn > 0.5) 
        {
            GameTime = 0;
            timeSpawn -= 0.1f;
            Debug.Log(timeSpawn);
        }
        
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3
            (
            Random.Range(Random.Range(-15f, -10f), Random.Range(10f, 15f)),//X
            0,//Y
            Random.Range(Random.Range(-10f, -6f), Random.Range(6f, 10f))//Z
            ),
            Quaternion.identity);
    }
}
