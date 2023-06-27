using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public AudioClip[] audioClips;
    private AudioClip randClip;
    public AudioSource audioSource;
    private AudioSource SpawnedAudioSrc;
    private bool isPlaying;

    void Start() 
    {
        GameObject audioObject = GameObject.FindGameObjectWithTag("MainMusic");
        if(audioObject){
            SpawnedAudioSrc = audioObject.GetComponent<AudioSource>();
        }

        if(SpawnedAudioSrc == null ) {
            SpawnedAudioSrc = Instantiate(audioSource, new Vector3(0,0,0), Quaternion.identity).GetComponent<AudioSource>();
            SpawnedAudioSrc.enabled = true;
            isPlaying = true;
            DontDestroyOnLoad(SpawnedAudioSrc); 

            Debug.Log("Spawned AudioSource");
        }
            SpawnedAudioSrc.loop = false;
            randClip = audioClips[Random.Range(0, audioClips.Length)]; 
                  
    }

    private AudioClip GetRandomClip() {
       return randClip;
    }

    void Update () {
        if(!SpawnedAudioSrc.isPlaying && SpawnedAudioSrc.enabled) {
            SpawnedAudioSrc.clip = GetRandomClip();
            SpawnedAudioSrc.Play();
        }else if(!SpawnedAudioSrc.enabled || !SpawnedAudioSrc.gameObject.activeInHierarchy)
        {
            SpawnedAudioSrc.enabled = true;
            SpawnedAudioSrc.gameObject.SetActive(true);
        }
    }
    // public GameObject mainAudio;

    // private void Start() {
    //     GameObject[] objects = GameObject.FindGameObjectsWithTag("MainMusic");
    //     if(objects.Length == 0) {
    //         GameObject instantObj = Instantiate(mainAudio, new Vector3(0,0,0),
    //         Quaternion.identity) as GameObject;

    //         DontDestroyOnLoad(instantObj);
    //     }
    // }

}
