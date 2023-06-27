using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePowerUps : MonoBehaviour
{
    private float waitTime;
    public GameObject[] powerUps;
    private bool isSpawn;
    private Coroutine spawner;

    private void Update() {
        if(PlayButton.isStart && !isSpawn) {
        spawner = StartCoroutine(SpawnPowerUps());
        isSpawn = true;
        }
    }

    IEnumerator SpawnPowerUps() {
        while(true) {
            yield return new WaitForSeconds(Random.Range(3,3));
            if(PlayButton.isStart) {
            Instantiate(powerUps[Random.Range(0, powerUps.Length)], new Vector2(10f, Random.Range(-3.3f, 3.5f)), Quaternion.identity);
            } else
                StopCoroutine(spawner);
        }
    }
}
