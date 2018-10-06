using UnityEngine.SceneManagement;
using UnityEngine;

public class StartButton : MonoBehaviour {

    public void StartButtonPressed() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
