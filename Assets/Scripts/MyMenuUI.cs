using UnityEngine;

public class MyMenuUI : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject pauseMenu;
    public GameObject gameOverMenu;
    public MyInputHandler inputHandler;

    void Start()
    {
        MyCode.GameManager.GetInstance().OnGameOverAction += gameOver;
    }

    public void startGame()
    {
        mainMenu.SetActive(false);
    }

    public void pauseGame()
    {
        pauseMenu.SetActive(true);
        MyCode.GameManager.GetInstance().pauseGame();
    }

    public void resumeGame()
    {
        pauseMenu.SetActive(false);
        MyCode.GameManager.GetInstance().resumeGame();
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void gameOver()
    {
        gameOverMenu.SetActive(true);
    }

    public void retry() 
    {
        gameOverMenu.SetActive(false);
        mainMenu.SetActive(true);
        MyCode.GameManager.GetInstance().retry();
    }

    private void OnEnable()
    {
        inputHandler.OnPauseAction += pauseGame;
    }

    private void OnDisable()
    {
        inputHandler.OnPauseAction -= pauseGame;
    }
        
        
}
