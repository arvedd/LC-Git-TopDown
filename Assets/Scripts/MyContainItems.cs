using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;

public class MyContainItems : MonoBehaviour
{
    public List<MyObjectSpawnRate> objects;

    void Start()
    {

    }

    void Update()
    {

    }

    public void SpawnItemOnDeath()
    {
        GameObject go = getItem();
        Instantiate(go);
    }

    private GameObject getItem()
    {
        int limit = 0;

        foreach (MyObjectSpawnRate osr in objects)
        {
            limit += osr.rate;
        }

        int random = Random.Range(0, limit);

        foreach (MyObjectSpawnRate osr in objects)
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
