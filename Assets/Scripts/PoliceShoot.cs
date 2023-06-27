using UnityEngine;
using System.Collections;

public class PoliceShoot : MonoBehaviour
{
    public GameObject shot;
    public Transform shotPos;
    private bool isShot = false;

    void Update() {
        if(gameObject != null && !isShot && DetectCollision.playerDead == false){
            StartCoroutine(PoliceShooting());
            isShot = true;
        }
    
    }

    IEnumerator PoliceShooting() {
        yield return new WaitForSeconds(0.9f);
        Instantiate(shot, shotPos.position, Quaternion.Euler(0, 180, 0));
        isShot = false;
    }
}
