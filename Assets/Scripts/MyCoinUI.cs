using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MyCoinUI : MonoBehaviour
{
    public TextMeshProUGUI text;
    public MyScriptableInteger coinScriptable;
    
    void Start()
    {
        
    }

    void Update()
    {
        text.text = coinScriptable.value.ToString();
    }
}
