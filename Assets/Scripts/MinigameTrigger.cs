using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class MinigameTrigger : MonoBehaviour {
    public Vector3 startPos;
    public Vector3 spd;
    public GameObject obj;
    public bool touched;
    public float timeDelay;
    public string GameName;
    public TMP_Text instructionsText;
    public string GameInstructions;
    public GameObject gameManager;
    public GameObject miniGameObj;
    // Start is called before the first frame update
    void Start() {
        instructionsText.text = GameInstructions;
        
    }

    // Update is called once per frame
    void Update() {
        StartCoroutine(parallaxFunc());
    }

    IEnumerator parallaxFunc() {
        yield return new WaitForSeconds(timeDelay);
        //Debug.Log("Started Coroutine at timestamp : " + Time.time);
        if (!touched) {
            obj.transform.position += spd;
        } else {
            obj.transform.position = startPos;
            touched = false;
        }

    }


    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Wagon") {
            instructionsText.gameObject.SetActive(true);
        } else if (other.tag == "ParallaxTrigger") {
            touched = true;
        }

    }

    private void OnTriggerStay(Collider other) {
        if (other.tag == "Wagon") {
            //instructionsText.gameObject.SetActive(true);
            if (Input.GetKey(KeyCode.X)) {

                gameManager.SetActive(false);
                miniGameObj.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.tag == "Wagon") {
            instructionsText.gameObject.SetActive(false);
        }

    }
}
