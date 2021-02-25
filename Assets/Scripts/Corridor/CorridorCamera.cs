using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorridorCamera : MonoBehaviour
{
    public Transform playerCamera;
    public Transform corridorEnd;
    public Transform corridorOtherEnd;

    // Update is called once per frame
    void LateUpdate()
    {
        // Vector to get from portal to player
        Vector3 playerOffsetFromPortal = playerCamera.position - corridorOtherEnd.position;

        // get position
        transform.position = corridorEnd.position + playerOffsetFromPortal;

        // get rotation
        transform.rotation = playerCamera.rotation;
    }
}
