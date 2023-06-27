using UnityEngine;

public class EnemyMove : MonoBehaviour
{
        public float enemySpeed = 5f;
        public GameObject[] explosions;
        public static bool enemyDestroyed = false;

    private void Update() {
        if(PlayButton.isStart) {
            transform.Translate(Vector2.left * enemySpeed * Time.deltaTime);
                if(transform.position.x <= -10f)
                    Destroy(gameObject);      
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Shot") || other.CompareTag("ExplosionSphere")){
            Instantiate(explosions[Random.Range(0, explosions.Length)], transform.position, Quaternion.identity);
            GameManager.gameManager.UpdateScore(1);
            Destroy(gameObject);
        }

    }

    void Explode() {
        Instantiate(explosions[Random.Range(0, explosions.Length)], transform.position, Quaternion.identity);
            GameManager.gameManager.UpdateScore(1);
            Destroy(gameObject);
    }
}

