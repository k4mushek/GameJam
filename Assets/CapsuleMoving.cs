using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCapsuleAndCamera : MonoBehaviour
{
    public Transform capsule; // Reference to the capsule object
    public Transform camera;  // Reference to the camera object
    public float capsuleSpeed = 5.0f;  // Speed at which the capsule moves
    public Vector3 cameraOffset = new Vector3(0f, 5f, -10f);  // Camera offset relative to the capsule

    void Update()
    {
        // Move the capsule to the right
        capsule.Translate(Vector3.right * capsuleSpeed * Time.deltaTime);

        // Make the camera follow the capsule with an offset
        camera.Translate(Vector3.right * capsuleSpeed * Time.deltaTime);
    }
}
