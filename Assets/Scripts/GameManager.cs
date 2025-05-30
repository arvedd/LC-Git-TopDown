using UnityEngine;
using UnityEngine.Events;

namespace MyCode
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager instance;
        [SerializeField] public GameObject activePlayer;
        public GameObject playerPrefab;
        public UnityAction OnGameOverAction;
        public bool isPlaying;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public static GameManager GetInstance()
        {
            return instance;
        }

        void Start()
        {
            StartGame();
        }

        private void spawnPlayer()
        {
            activePlayer = Instantiate(playerPrefab);
        }

        public Vector3 getPlayerPosition()
        {
            if (activePlayer != null)
            {
                return activePlayer.transform.position;
            }
            return Vector3.zero;
        }


        public void StartGame()
        {
            isPlaying = true;
            spawnPlayer();
        }

        public void resumeGame()
        {
            isPlaying = true;
            Time.timeScale = 1;
        }

        public void pauseGame()
        {
            isPlaying = false;
            Time.timeScale = 0;
        }
        
        internal void gameOver() 
        {
            isPlaying = false;
            OnGameOverAction?.Invoke();
        }
    }
}
