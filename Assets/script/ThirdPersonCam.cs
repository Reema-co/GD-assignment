using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCam : MonoBehaviour
{
    Transform playerTransform;
    float initialCameraOffset;
    float sensitivity = 3;

    Vector3 cameraRotation;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        initialCameraOffset = Vector3.Distance(transform.position, playerTransform.position);
        cameraRotation = transform.rotation.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform)
        {
            float mouseX = Input.GetAxis("Mouse X");
            if (mouseX != 0)
            {
                cameraRotation.y += mouseX * sensitivity;
            }

            transform.eulerAngles = cameraRotation;
            Vector3 cameraLookDirction = Quaternion.Euler(cameraRotation) * Vector3.forward;
            transform.position = -cameraLookDirction * initialCameraOffset + playerTransform.position;
        }
    }

    void OnEnable()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void OnDisable()
    {
        Cursor.lockState = CursorLockMode.None;
    }
}
