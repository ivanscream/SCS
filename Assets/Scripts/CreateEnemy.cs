using UnityEngine;
using System.Collections;

public class CreateEnemy : MonoBehaviour
{
    public float waitTime = 1f;
    public GameObject[] enemy;
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
            if(PlayButton.isStart) {
            Instantiate(enemy[Random.Range(0, enemy.Length)], new Vector2(10f, Random.Range(-3.30f, 3.5f)), Quaternion.identity);
            } else
                StopCoroutine(spawner);
            yield return new WaitForSeconds(waitTime);
        }
    }
}
