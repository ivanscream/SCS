using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject continueButton, musicbutton, aButton, bButton;

    public void PressPause() {
        
            Time.timeScale = 0;
            gameObject.SetActive(false);
            continueButton.SetActive(true);
            musicbutton.SetActive(true);
            aButton.SetActive(false);
            bButton.SetActive(false);
        
    }
}
