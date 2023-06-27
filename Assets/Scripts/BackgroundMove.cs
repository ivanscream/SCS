using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    public float bgMoveSpeed = 5f;

    private void Update() {
        if(PlayButton.isStart) {
            transform.Translate(Vector2.left * bgMoveSpeed * Time.deltaTime);
        }

    }
}
