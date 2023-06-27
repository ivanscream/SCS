using UnityEngine.UI;
using UnityEngine;

public class ToggleMusic : MonoBehaviour
{
    public void MusicOnOff(bool muted) {
        if(muted) {
            AudioListener.volume = 0;
        } else {
            AudioListener.volume = 1;
        }
        
    }
}
