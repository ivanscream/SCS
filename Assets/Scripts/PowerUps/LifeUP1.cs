using UnityEngine;

public class LifeUP1 : MonoBehaviour
{
    public PowerUps powerUps;

    void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")) {
            Destroy(gameObject);
            powerUps.Apply(other.gameObject);
        }
    }

    void Update () {
        transform.Translate(-transform.right * 4 * Time.deltaTime);
    }

    
}
