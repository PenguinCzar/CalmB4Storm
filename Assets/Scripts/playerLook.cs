using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLook : MonoBehaviour
{

    public Transform playerCamera;
    public Vector2 sensitivities;

    private Vector2 XYRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //can we do this with arrow keys???
        Vector2 mouseInput = new Vector2
        {
            x = Input.GetAxis("HorizontalCam"),
            y = Input.GetAxis("VerticalCam")
        };

        XYRotation.x -= mouseInput.y * sensitivities.y;
        XYRotation.y += mouseInput.x * sensitivities.x;

        XYRotation.x = Mathf.Clamp(XYRotation.x,-90f,90f);

        transform.eulerAngles = new Vector3(0f,XYRotation.y,0f);
        playerCamera.localEulerAngles = new Vector3(XYRotation.x,0f,0f);
    }
}
