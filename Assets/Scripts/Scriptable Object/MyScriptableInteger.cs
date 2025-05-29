using UnityEngine;

[CreateAssetMenu(fileName = "My New Scriptable Integer", menuName = "My Scriptable Variable/Integer")]
public class MyScriptableInteger : ScriptableObject
{
    public int value;
    public int defaultValue;
    public bool resetOnEnable;

    private void OnEnable() {
        if (resetOnEnable) {
            Reset();
        }
    }

    internal void Reset() 
    {
        value = defaultValue;
    }

}
