using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class awake : MonoBehaviour
{
    float starttime;
    float activation;
    AudioSource audio;
    bool started;
    public bool activated;
    // Start is called before the first frame update
    void Start()
    {
        started=false;
        activation = Random.Range(10.0f,70.0f);
        audio = gameObject.GetComponent<AudioSource>();
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {   
        if(started==false){
        if(Input.GetKeyDown("1")){
            starttime=Time.time;
            started=true;
        }
        }
        if(activated==false&started==true){
        if(Time.time-starttime>activation){
            print("yes");
            audio.Play();
            audio.mute = false;
            gameObject.GetComponent<Renderer>().enabled = true;
            activated = true;
        }
        }
        if(activated==true){
            if(Time.time-starttime-activation>20.0f){
                audio.mute = true;
                gameObject.GetComponent<Renderer>().enabled = false;
            }
        }
    }
}
