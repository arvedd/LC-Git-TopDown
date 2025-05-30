using UnityEngine;

public class MyWeaponUpgrade : MonoBehaviour
{
    public void AddComponentToObject(GameObject go)
    {
        go.AddComponent<MyWeaponUpgrade>();
        go.GetComponent<MyWeaponSetController>().WeaponUpgradeCheck();
    }
}
