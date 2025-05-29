using UnityEngine;

[RequireComponent(typeof(MyMoveable))]
public class NewMonoBehaviourScript : MonoBehaviour
{
    private MyMoveable moveable;
    private void Awake()
    {
        moveable = GetComponent<MyMoveable>();
    }

    void Start()
    {
        moveable.setDirection(randomDirection(), randomDirection());
    }

    private float randomDirection()
    {
        return Random.Range(-1f, 1);
    }
}
