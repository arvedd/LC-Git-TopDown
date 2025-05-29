using UnityEngine;

[RequireComponent(typeof(MyMoveable))]
public class MyPlayerController : MonoBehaviour
{
    public MyInputHandler myInputHandler;
    private MyMoveable moveable;

    void Awake()
    {
        moveable = GetComponent<MyMoveable>();
    }

    void Update()
    {

    }

    private void OnSetDirect(Vector3 direction)
    {
        Debug.Log("OnSetDirect");
        moveable.setDirection(direction);
    }

    private void OnEnable()
    {
        myInputHandler.OnSetDirectionAction += OnSetDirect;
    }

    private void OnDisable()
    {
        myInputHandler.OnSetDirectionAction -= OnSetDirect;
    }
}
