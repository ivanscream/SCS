using UnityEngine;

public class ContinueGame : MonoBehaviour
{
    public GameObject pauseButton, musicbutton, aButton, bButton;

    public void PressContinue() {

            Time.timeScale = 1;
            gameObject.SetActive(false);
            pauseButton.SetActive(true);
            musicbutton.SetActive(false);
            aButton.SetActive(true);
            bButton.SetActive(true);
        
    }
}
