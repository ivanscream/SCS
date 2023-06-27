using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public GameObject logoText, musicBtn, creditsBtn, buttonCanvas, continueButton;
    public float hideSpeed = 10f;
    public static bool isStart;
    public GameObject flyer;
    private void Update() {
        if (isStart && logoText != null)
            logoText.transform.Translate(Vector2.up * hideSpeed * Time.deltaTime);
    }

    public void StartGame() {
        if(isStart)
            return;

        isStart = true;
        Destroy(logoText, 2.5f);
        GetComponent<Animation>().Play("HidePlayBtn");
        flyer.GetComponent<Animator>().enabled = false;
        musicBtn.SetActive(false);
        creditsBtn.SetActive(false);
        DetectCollision.playerDead = false;
        buttonCanvas.SetActive(true);
        continueButton.SetActive(false);
    }
}
