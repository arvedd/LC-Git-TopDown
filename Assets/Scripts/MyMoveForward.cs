using UnityEngine;

[RequireComponent(typeof(MyMoveable))]
public class MyMoveForward : MonoBehaviour
{
    private MyMoveable moveable;
    private Collider col;

    private void Awake()
    {
        moveable = GetComponent<MyMoveable>();
    }

    void Update()
    {
        moveable.setDirection(transform.up);
    }
}
