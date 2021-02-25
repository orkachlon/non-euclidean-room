using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornerCamera : MonoBehaviour
{
    public Transform playerCamera;
    public Transform portal;
    public Transform otherPortal;

    // Update is called once per frame
    void LateUpdate()
    {
        // Position offset vector
        Vector3 playerOffsetFromPortal = playerCamera.position - otherPortal.position;

        // Camera's new position - calculated by using player's position relative to other portal
        //                                     flip forward direction                   apply portal rotation difference
        transform.position = portal.position + (Quaternion.Euler(0f, 180f, 0f) * portal.rotation * Quaternion.Inverse(otherPortal.rotation) * playerOffsetFromPortal);

        // Calculate camera roatation
        //Vector3 forwardRotation = Quaternion.Euler(0f, 180f, 0f) * portal.rotation * Quaternion.Inverse(otherPortal.rotation) * playerCamera.forward;
        //Vector3 upRotation = portal.rotation * Quaternion.Inverse(otherPortal.rotation) * playerCamera.up;
        transform.rotation = playerCamera.rotation;//Quaternion.LookRotation(forwardRotation, upRotation);
    }
}
