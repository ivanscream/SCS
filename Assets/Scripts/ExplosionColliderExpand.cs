using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionColliderExpand : MonoBehaviour
{
    public float expansionRate = 20f;
    private Vector3 scaleChange;


    void Awake() {
        scaleChange = new Vector3(6, 0, 0);
    }
    void Start() {
        StartCoroutine(Scaler());
    }

    IEnumerator Scaler() {
        // gameObject.transform.lossyScale += scaleChange * expansionRate * Time.deltaTime;
        yield return new WaitForSeconds(0.2f);
        Destroy(gameObject);
    }
}
