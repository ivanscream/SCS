using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class TouchMove : MonoBehaviour
{
    private Vector3 targetPosition;
    public GameObject player;
    public float speed = 6f;
    public GameObject shot;
    public Transform bulletPlace;
    private bool isShot = false;
    public float editorSpeed;

    private void Update() {
        if(PlayButton.isStart) {
#if UNITY_ANDROID
            if (!EventSystem.current.IsPointerOverGameObject()){
                if(Input.touchCount > 0) {
                Touch touch = Input.GetTouch(0);
                    if(touch.phase == TouchPhase.Moved) {
                        targetPosition = Camera.main.ScreenToWorldPoint(touch.position);
                    }
                }
            }
            
#endif

#if UNITY_EDITOR
            if (!EventSystem.current.IsPointerOverGameObject()){
                if(Input.GetMouseButton(0)){
                    targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }

            }
            
            if(Input.GetKey(KeyCode.LeftShift) && PlayButton.isStart && !isShot) {
                Instantiate(shot, bulletPlace.position, Quaternion.identity);
                isShot = true;
                StartCoroutine(ShotTemp());
            }

                       
#endif

            IEnumerator ShotTemp() {
                yield return new WaitForSeconds (0.2f);
                isShot = false;
            }

            float move = speed * Time.deltaTime;

            if(targetPosition.y < -3.3f)
                targetPosition.y = -3.3f;
            else if(targetPosition.y > 3.5f)
                targetPosition.y = 3.5f;

            player.transform.position = Vector3.MoveTowards(
                player.transform.position,
                new Vector3(targetPosition.x, targetPosition.y, player.transform.position.z),
                move
            );
        }
    }
}
