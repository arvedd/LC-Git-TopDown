using UnityEngine;
using UnityEngine.Events;

public class MyTriggerEvent : MonoBehaviour
{
    public UnityEvent OnTrigger;
    public string targetTag;
    public UnityEvent<GameObject> OnTriggerWithGameobject;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == targetTag)
        {
            Debug.Log($"{col.tag} is Triggered by {targetTag}");
            OnTrigger?.Invoke();

            OnTriggerWithGameobject?.Invoke(col.gameObject);
        }
    }
}
