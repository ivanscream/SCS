using UnityEngine;

public class RocketUP1 : MonoBehaviour
{
    public PowerUps powerUps;

    void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")) {
            Destroy(gameObject);
            powerUps.Apply(other.gameObject);
            GameManager.outOfRockets = false;
        }
    }

    void Update () {
        transform.Translate(-transform.right * 4 * Time.deltaTime);
    }
}
