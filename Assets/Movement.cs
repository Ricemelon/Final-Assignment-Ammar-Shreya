using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1;
    public Transform target1;
    public Transform target2;
    public Transform target3;
    public Transform target4;
    public Transform target5;
    public Transform target6;
    private Transform target;
    void Start()
    {
        target = target1;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position!=target.position){
            float step =  speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        }else{
            float rand = Random.Range(1,6);
            if(rand==1){
                target = target1;
            }else if(rand==2){
                target = target2;
            }else if(rand==3){
                target = target3;
            }else if(rand==4){
                target = target4;
            }else if(rand==5){
                target = target5;
            }else if(rand==6){
                target = target6;
            }
            
        }
        
    }
}
