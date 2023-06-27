using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public Color deathColor;
    private SpriteRenderer sr;
    public GameObject explosion, gameOverPanel, scorePanel;
    private AudioSource looseAudio;
    public static bool playerDead = false;

    private void Awake() {
        sr = GetComponent<SpriteRenderer>();
        looseAudio = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("Enemy")) {
            PlayButton.isStart = false;
            Destroy(collision.gameObject);
            sr.color = deathColor;

            ContactPoint2D contact = collision.contacts[0];
            Vector3 pos = contact.point;
            GameObject boomAnim = Instantiate(explosion, pos, Quaternion.identity) as GameObject;
            Destroy(boomAnim, 2f);
            looseAudio.Play();
            gameOverPanel.SetActive(true);
            scorePanel.SetActive(false);
            playerDead = true;
            Destroy(gameObject);

        }
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("PoliceShot")) {    
            GameManager.gameManager.UpdateLives(-1);
        }
    }

    public void EndGame() {
        PlayButton.isStart = false;
        sr.color = deathColor;
        GameObject boomAnim = Instantiate(explosion, gameObject.transform.position, Quaternion.identity) as GameObject;
        Destroy(boomAnim, 2f);
        looseAudio.Play();
        gameOverPanel.SetActive(true);
        scorePanel.SetActive(false);
        playerDead = true;
        Destroy(gameObject);
    }
}
