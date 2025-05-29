using UnityEngine;

public class MyTravelDistanceLimit : MonoBehaviour
{
    public float maxTravelDistance;

    private float travelDistance;
    private MyMoveable moveable;
    private MyPoolObject poolObject;

    private void Awake()
    {
        moveable = GetComponent<MyMoveable>();
        poolObject = GetComponent<MyPoolObject>();
    }

    void Start()
    {

    }

    void Update()
    {
        if (travelDistance >= maxTravelDistance)
        {
            if (poolObject != null)
            {
                poolObject.deactivate();
            }
            else
            {
                Destroy(gameObject);
            }
        }

        travelDistance += moveable.newPosition().magnitude;
    }
    
    private void OnEnable() {
        travelDistance = 0;
    }
}
