using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activing : MonoBehaviour
{
    // Start is called before the first frame update
    public HitCount script1;
    public Movement script2;

    void Start()
    {
        script1.enabled = false;
        script2.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("1")){
            script1.enabled = true;
            script2.enabled = true;

        }
        
    }
}
