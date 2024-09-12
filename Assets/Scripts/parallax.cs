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
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("The time is now: " + Time.time);
        if (!touched){
            obj.transform.position += spd;
        }else{
            obj.transform.position = startPos;
            touched = false;
        }

    }
    private void OnTriggerEnter(Collider other){
        if(other.tag == "ParallaxTrigger")
            touched = true;
    }
}
