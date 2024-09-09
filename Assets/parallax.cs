using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour
{
    public Vector3 startPos, endPos;
    public GameObject obj;
    public Vector3 spd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while(obj.transform.position != endPos) {
            obj.transform.position += spd;
        }
        obj.transform.position = startPos;
    }
}
