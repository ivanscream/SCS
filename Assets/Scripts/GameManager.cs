using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score;
    public static GameManager gameManager;
    public Text scoreText;
    public GameObject player;
    private int lives, rockets;
    public GameObject life1, life2, life3;
    public GameObject rocket1, rocket2, rocket3;
    public static bool outOfRockets = false;

    private void Awake(){
        gameManager = this;
    }
    void Start() {
        score = 1;
        lives = 3;
        rockets = 3;
        UpdateScore(0);
    }

    public void UpdateScore(int scoreToAdd) {
        score += scoreToAdd;
        scoreText.text = "SCORE: " + score.ToString();

        if(PlayerPrefs.GetInt("bestScore") < score)
            PlayerPrefs.SetInt("bestScore", score);
    }

    void Update() {
        LifeCount();
        RocketCount();
    }

    public void UpdateLives(int hearts) {
        lives += hearts;

        if(lives >= 4)
            lives = 3;
    }

    public void UpdateRockets(int missile) {
        rockets += missile;

        if(rockets >= 4)
            rockets = 3;

        if(rockets <= 0)
            rockets = 0;
    }

    void LifeCount() {
        if(player != null) {
            if (score <= 0)
            player.GetComponent<DetectCollision>().EndGame();

            if(lives == 3){
                life1.SetActive(true);
                life2.SetActive(true);
                life3.SetActive(true);
            } else if (lives == 2){
                life1.SetActive(true);
                life2.SetActive(true);
                life3.SetActive(false);
            } else if (lives == 1) {
                life1.SetActive(true);
                life2.SetActive(false);
                life3.SetActive(false);
            } else if (lives == 0) {
                life1.SetActive(false);
                life2.SetActive(false);
                life3.SetActive(false);
                player.GetComponent<DetectCollision>().EndGame();
            } else if (lives >= 4) return;
        }
    }

    void RocketCount () {
        if(player != null) {

            if(rockets == 3){
                rocket1.SetActive(true);
                rocket2.SetActive(true);
                rocket3.SetActive(true);
            } else if (rockets == 2){
                rocket1.SetActive(true);
                rocket2.SetActive(true);
                rocket3.SetActive(false);
            } else if (rockets == 1) {
                rocket1.SetActive(true);
                rocket2.SetActive(false);
                rocket3.SetActive(false);
            } else if (rockets == 0) {
                outOfRockets = true;
                rocket1.SetActive(false);
                rocket2.SetActive(false);
                rocket3.SetActive(false);
            } else if (rockets >= 4) return;
        }
    }
}
