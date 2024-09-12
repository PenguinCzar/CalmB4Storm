using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goBack : MonoBehaviour
{
    public GameObject wagon;
    public GameObject cave;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.B)) {
                cave.SetActive(false);
                wagon.SetActive(true);
            }
    }
}
