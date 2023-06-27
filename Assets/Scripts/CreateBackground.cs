using UnityEngine;

public class CreateBackground : MonoBehaviour
{
    public GameObject nowBg, bgInstantiate;
    private GameObject newBg;

    private void Update() {
        if(PlayButton.isStart) {
            if(nowBg.transform.position.x <= 0 && newBg == null)
                CreateNewBg();
            else if(newBg != null && newBg.transform.position.x <= 0)
                CreateNewBg();
        }
    }
    void CreateNewBg() {
        if(nowBg.transform.position.x < -10f){
            Destroy(nowBg);
            nowBg = newBg;
        }

        newBg = Instantiate(bgInstantiate, new Vector2(21.80f, 0), Quaternion.identity)
        as GameObject;
    }

}
