using UnityEngine;

public class MyGameOverController : MonoBehaviour
{
    public void gameOver() 
		{
        MyCode.GameManager.GetInstance().gameOver();
    }
}
