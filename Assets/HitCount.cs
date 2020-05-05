using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCount : MonoBehaviour
{
    // Start is called before the first frame update
    private float time = 0f;
    private float totaltime = 0f;
    public GameObject target;
    public TextMesh textMesh;
    public TextMesh total;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totaltime+=Time.deltaTime;
        total.text = totaltime.ToString();

        RaycastHit outHit;
            if(Physics.Raycast(transform.position, transform.forward,out outHit, 100.0f)){
                    GameObject item = outHit.collider.gameObject;
                    if(item == target){
                        time+=Time.deltaTime;
                        textMesh.text = time.ToString();
                    }
            }
        
    }
}
