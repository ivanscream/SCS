using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGCarsCreate : MonoBehaviour
{
    public float waitTime = 1f;
    public GameObject[] bgCars;
    private bool isSpawn;

    private void Start() {
        if(!isSpawn && !PlayButton.isStart) {
        StartCoroutine(CreateBgCars());
        isSpawn = true;
        }
    }

    IEnumerator CreateBgCars() {
        while(true) {
            Instantiate(bgCars[Random.Range(0, bgCars.Length)], new Vector2(-10f, Random.Range(-3.30f, 0.6f)), Quaternion.Euler(0,180,0));
            yield return new WaitForSeconds(waitTime);
            isSpawn = false;
        }
    }

}
