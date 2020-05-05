using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class awake : MonoBehaviour
{
    float starttime;
    float activation;
    AudioSource audio;
    bool activated = false;
    // Start is called before the first frame update
    void Start()
    {
        starttime=Time.time;
        activation = Random.Range(0.0f,80.0f);
        audio = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(activated==false){
        if(Time.time-starttime>activation){
            audio.mute = false;
            activated = true;
        }
        }
    }
}
