using UnityEngine;


public class ButtonsControl : MonoBehaviour
{
    public GameObject flyer, startBtn, credits, creditBtn, SCSlogo;

    public void PushCredits() {
        credits.SetActive(true);
        flyer.SetActive(false);
        startBtn.SetActive(false);
        creditBtn.SetActive(false);
        SCSlogo.SetActive(false);

    }

    public void PushCross() {
        credits.SetActive(false);
        flyer.SetActive(true);
        startBtn.SetActive(true);
        creditBtn.SetActive(true);
        SCSlogo.SetActive(true);
    }
}
