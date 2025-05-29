using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class MyFireRateModifier : MonoBehaviour
{
    public float modifier = 0.2f;
    private List<MyWeapon> weapons;

    private void Awake()
    {
        weapons = GetComponentsInChildren<MyWeapon>().ToList<MyWeapon>();
    }

    void Start()
    {
        foreach (MyWeapon w in weapons)
        {
            w.AddFireRateModifier(modifier);
        }
    }

    private void OnDestroy()
    {
        foreach (MyWeapon w in weapons)
        {
            w.RemoveFireRateModifier(modifier);
        }
    }
    
    public void AddComponentToObject(GameObject go) 
	{
        go.AddComponent<MyFireRateModifier>();
    }
}
