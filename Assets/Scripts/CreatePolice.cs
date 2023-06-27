using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePolice : MonoBehaviour
{
    public float waitTime = 1f;
    public GameObject enemy;
    private bool isSpawn;
    private Coroutine spawner;

    private void Update() {
        if(PlayButton.isStart && !isSpawn) {
        spawner = StartCoroutine(SpawnEnemy());
        isSpawn = true;
        }
    }

    IEnumerator SpawnEnemy() {
        while(true) {
            yield return new WaitForSeconds(waitTime);
            if(PlayButton.isStart) {
            Instantiate(enemy, new Vector2(10f, Random.Range(-3.3f, 3.5f)), Quaternion.identity);
            } else
                StopCoroutine(spawner);
        }
    }
}
