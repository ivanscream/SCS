using UnityEngine;
using UnityEngine.UI;
public class SetBestScore : MonoBehaviour
{
    private void Awake() {
        GetComponent<Text>().text = "best score: " + PlayerPrefs.GetInt("bestScore").ToString();
    }
}
