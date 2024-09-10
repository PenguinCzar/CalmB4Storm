using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour
{
    public Vector3 startPos;
    public Vector3 endPos;
    public Vector3 spd;
    public GameObject obj;
    public bool touched;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!touched){
            obj.transform.position += spd;
        }else{
            obj.transform.position = startPos;
            touched = false;
        }

    }
    private void OnTriggerEnter(Collider other){
        touched = true;
    }
}
