using System.Collections;
using UnityEngine;

public class MissileShot : MonoBehaviour
{
    private Vector3 targetPosition;
    public GameObject missile;
    public Transform bulletPlace;
    private bool isShot = false;

    public void ShootMissile() {
        if(bulletPlace == null)
            return;

        if(!isShot && !GameManager.outOfRockets){
            Instantiate(missile, bulletPlace.position, Quaternion.identity);
            isShot = true;
            StartCoroutine(ShotTemp());
        } else return;
    }
    IEnumerator ShotTemp() {
        GameManager.gameManager.UpdateRockets(-1);
        yield return new WaitForSeconds (1f);
        isShot = false;
    }


}
