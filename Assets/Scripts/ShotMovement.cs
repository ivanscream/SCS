using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotMovement : MonoBehaviour
{
    public float shotSpeed = 30f;

    void Start() {
        if(gameObject != null)
            Destroy(gameObject, 2f);
    }
    void Update()
    {
        ShotFly();
    }

    void ShotFly() {       
        transform.Translate(transform.right * shotSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Enemy")) {
            Destroy(gameObject);
        }
    }
}

