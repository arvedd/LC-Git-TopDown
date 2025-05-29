using UnityEngine;

public class MyAutoShoot : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        foreach (MyWeapon w in GetComponentsInChildren<MyWeapon>())
        {
            w.shoot();
        }
    }
}
