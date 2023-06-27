using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGCarMove : MonoBehaviour
{
        public float carSpeed = 30f;

    void Start() {
        if(gameObject != null)
            Destroy(gameObject, 2f);
    }
    void Update()
    {
        ShotFly();
    }

    void ShotFly() {       
        transform.Translate(transform.right * carSpeed * Time.deltaTime);
    }
}
