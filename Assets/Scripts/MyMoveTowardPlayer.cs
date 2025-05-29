using UnityEngine;

[RequireComponent(typeof(MyMoveable))]
public class MyMoveTowardPlayer : MonoBehaviour
{
    private MyMoveable moveable;

    private void Awake()
    {
        moveable = GetComponent<MyMoveable>();
    }

    void Start()
    {
        moveable.setDirection(getDirection());
    }

    void Update()
    {

    }
    
    private Vector3 getDirection()
    {
        Vector3 dir;
        dir = MyCode.GameManager.GetInstance().getPlayerPosition() - transform.position;
        dir = dir.normalized;

        return dir;
    }
}
