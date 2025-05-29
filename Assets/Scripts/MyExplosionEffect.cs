using UnityEngine;

public class MyExplosionEffect : MonoBehaviour
{
    public void showExplosion() 
	{
        MyObjectPool.GetInstance().requestObject(MyPoolObjectType.EXPLOSION).activate(transform.position, Quaternion.identity);
    }
}
