using UnityEngine;

public class MyWeapon : MonoBehaviour
{
    public float fireRate;
    private float timer = 0;
    public MyPoolObjectType type;

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
            Debug.Log("fire!!");
            obj.activate(transform.position, transform.rotation);
            timer = fireRate;
        }
        else
        {
            Debug.LogWarning("No object available in pool of type " + type);
        }
    }
    }
}
