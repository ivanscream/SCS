using UnityEngine;

public class CityMove : MonoBehaviour
{
    public float cityMoveSpeed = 5f;

    private void Update() {
        if(PlayButton.isStart) {
            transform.Translate(Vector2.left * cityMoveSpeed * Time.deltaTime);
        }

    }
}
