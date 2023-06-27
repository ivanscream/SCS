using UnityEngine;
using UnityEngine.UI;

public class MusicOnOff : MonoBehaviour
{
    public AudioListener listener;
    public Sprite musicOn, musicOff;
    private Image button;

    private void Awake() {
        button = GetComponent<Image>();
        if(PlayerPrefs.GetString("music") == "off") {
            button.sprite = musicOff;
            listener.enabled = false;
        }
    }
    public void SetMusic() {
        listener.enabled = !listener.enabled;

        if(listener.enabled) {
            button.sprite = musicOn;
            PlayerPrefs.SetString("music", "on");
        } else {
            button.sprite = musicOff;
            PlayerPrefs.SetString("music", "off");
        }
    }
}
