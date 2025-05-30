using UnityEngine;

public class MyWeaponSetController : MonoBehaviour
{
    public GameObject[] weaponSet;

    void Start()
    {
        DeactivateAllWeapon();
        ActivateWeaponSet(0);

        WeaponUpgradeCheck();
    }

    private void DeactivateAllWeapon()
    {
        foreach (GameObject go in weaponSet)
        {
            go.SetActive(false);
        }
    }

    public void ActivateWeaponSet(int upgradeLevel)
    {
        for (int i = 0; i < weaponSet.Length; i++)
        {
            if (i == upgradeLevel)
            {
                weaponSet[i].SetActive(true);
            }
            else
            {
                weaponSet[i].SetActive(false);
            }
        }
    }

    public void WeaponUpgradeCheck()
    {
        int upgradeLevel = GetComponents<MyWeaponUpgrade>().Length;

        if (upgradeLevel >= weaponSet.Length)
        {
            upgradeLevel = weaponSet.Length - 1;
        }

        ActivateWeaponSet(upgradeLevel);
        FireRateUpdate();
    }

    private void FireRateUpdate()
    {
        foreach (MyWeapon w in GetComponentsInChildren<MyWeapon>())
        {
            w.ClearModifier();

            foreach (MyFireRateModifier f in GetComponents<MyFireRateModifier>())
            {
                w.AddFireRateModifier(f.modifier);
            }
        }
    }
}
