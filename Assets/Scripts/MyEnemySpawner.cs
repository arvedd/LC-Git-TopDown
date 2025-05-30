using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEnemySpawner : MonoBehaviour
{
    [Header("Nilai x kiri dan kanan spawner")]
    public float leftX;
    public float rightX;
    public MyObjectSpawnRate[] enemies;
    [SerializeField] List<GameObject> enemyList;

    [Header("Delay Waktu Spawn")]
    public int delay;

    void Start()
    {
        enemyList = new List<GameObject>();
        StartCoroutine(spawner());
    }

    private IEnumerator spawner()
    {
        while (true)
        {
            if (MyCode.GameManager.GetInstance().isPlaying == true)
            {
                Spawn();
                yield return new WaitForSeconds(delay);
            } 
            else
            {
                 yield return new WaitForSeconds(delay);
            }
        }
    }

    public void Spawn()
    {
        Vector3 newPosition = transform.position;
        newPosition.x = Random.Range(leftX, rightX);

        enemyList.Add(Instantiate(getEnemy(), newPosition, transform.rotation));
    }

    private GameObject getEnemy()
    {
        int limit = 0;

        foreach (MyObjectSpawnRate osr in enemies)
        {
            limit += osr.rate;
        }

        int random = Random.Range(0, limit);

        foreach (MyObjectSpawnRate osr in enemies)
        {
            if (random < osr.rate)
            {
                return osr.prefab;
            }
            else
            {
                random -= osr.rate;
            }
        }

        return null;
    }
}
