using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceShotMove : MonoBehaviour
{
 public float shotSpeed = 20f;

    void Start() {
        if(gameObject != null)
            Destroy(gameObject, 2f);
    }
    void Update()
    {
        ShotFly();
    }

    void ShotFly() {       
        transform.Translate(-transform.right * shotSpeed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Player")) {
            Destroy(gameObject);
        }
    }
}
