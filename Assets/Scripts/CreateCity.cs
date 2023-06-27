using UnityEngine;

public class CreateCity : MonoBehaviour
{
    public GameObject nowCity;
    public GameObject[] cityInstantiate;
    private GameObject newCity;

    private void Update() {
        if(PlayButton.isStart) {
            if(nowCity.transform.position.x <= 3.6f && newCity == null)
                CreateNewCity();
            else if(newCity != null && newCity.transform.position.x <= 3.6f)
                CreateNewCity();
        }
    }
    void CreateNewCity() {
        if(nowCity.transform.position.x < -10f){
            Destroy(nowCity);
            nowCity = newCity;
        }

        newCity = Instantiate(cityInstantiate[Random.Range(0, cityInstantiate.Length)], new Vector2(29.13f, -2f), Quaternion.identity)
        as GameObject;
    }
}
