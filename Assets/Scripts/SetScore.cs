using UnityEngine;
using UnityEngine.UI;

public class SetScore : MonoBehaviour
{

    void Start() {
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Enemy")){
            GameManager.gameManager.UpdateScore(-1);
        }
    }
}
