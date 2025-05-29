using System.Collections;
using UnityEngine;

public class MyLookAtPlayer : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        LookAt();
    }

    void LookAt()
    {
        if (MyCode.GameManager.GetInstance().activePlayer != null)
        {
            transform.up = MyCode.GameManager.GetInstance().activePlayer.transform.position - transform.position;
        }    
    }
}
