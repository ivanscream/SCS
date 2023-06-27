using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMove : MonoBehaviour
{
    public float shotSpeed = 30f;
    public GameObject explosion, explosionRadius;

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

    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("PoliceShot")) {
            ContactPoint2D contact = other.contacts[0];
            Vector3 pos = contact.point;

            GameObject boomAnim = Instantiate(explosion, pos, Quaternion.identity) as GameObject;
            GameObject radius = Instantiate(explosionRadius, pos, Quaternion.identity) as GameObject;
            Destroy(gameObject);
            Destroy(boomAnim, 0.6f); 
            Destroy(radius, 1f);    
        }
    }
}
