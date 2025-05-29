using UnityEngine;
using UnityEngine.Events;

public class MyTriggerEvent : MonoBehaviour
{
    public UnityEvent OnTrigger;
    public string targetTag;

    private void OnTriggerEnter2D (Collider2D col)
    {
        if (col.tag == targetTag )
        {
            OnTrigger?.Invoke(); 
        }
    }
}
