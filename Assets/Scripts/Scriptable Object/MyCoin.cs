using UnityEngine;

public class MyCoin : MonoBehaviour
{
    public MyScriptableInteger coin;
    
    public void OnGain()
    {
        coin.value += 1;
    }
}
