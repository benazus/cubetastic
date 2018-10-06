using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    bool gameOver = false;
    public float restartDelay = 1f;
    public GameObject levelCompleteUI;


    // Use this for initialization
    public void EndGame() {
        if (!gameOver) {
            gameOver = true;
            Invoke("RestartLevel", restartDelay);
        }
    }


    void RestartLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void CompleteLevel() {
        levelCompleteUI.SetActive(true);
        Invoke("GameOver", 2f);
    }

    public void GameOver() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}