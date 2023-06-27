using System.Collections;
using UnityEngine;

public class ShootButton : MonoBehaviour
{
    private Vector3 targetPosition;
    public GameObject shot;
    public Transform bulletPlace;
    private bool isShot = false;


    public void Shoot() {
        if(bulletPlace == null)
            return;

        if(!isShot){
            Instantiate(shot, bulletPlace.position, Quaternion.identity);
            isShot = true;
            StartCoroutine(ShotTemp());
        } else return;
    }
    IEnumerator ShotTemp() {
        yield return new WaitForSeconds (0.2f);
        isShot = false;
    }
}   

