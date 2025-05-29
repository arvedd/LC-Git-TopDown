using System;
using System.Collections.Generic;
using UnityEngine;

public class MyWeapon : MonoBehaviour
{
    public float fireRate;
    private float timer = 0;
    public MyPoolObjectType type;
    public List<float> fireRateModifiers;

    void Start()
    {

    }

    void Update()
    {
        timer = timer - Time.deltaTime > 0 ? timer - Time.deltaTime : 0f;
    }

    public void shoot()
    {
        if (timer == 0f)
        {
            var obj = MyObjectPool.GetInstance()?.requestObject(type);
            if (obj != null)
            {
                obj.activate(transform.position, transform.rotation);
                timer = fireRate / getFireRateModifier();
            }
            else
            {
                Debug.LogWarning("No object available in pool of type " + type);
            }
        }
    }

    private float getFireRateModifier()
    {
        float mod = 1;

        foreach(float f in fireRateModifiers) 
        {
            mod += f;
        }

        return mod;
    }

    internal void AddFireRateModifier(float modifier)
    {
        fireRateModifiers.Add(modifier);
    }

    internal void ClearModifier() 
    {
        fireRateModifiers.Clear();
    }

    internal void RemoveFireRateModifier(float modifier)
    {
        fireRateModifiers.Remove(modifier);
    }
}
