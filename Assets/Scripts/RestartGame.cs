using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartGame : MonoBehaviour
{
    public void startNewGame() {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }
}
