using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour {

	public void RetryButtonPressed() {
        SceneManager.LoadScene(0);
    }
}
