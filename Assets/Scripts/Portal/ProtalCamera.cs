using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtalCamera : MonoBehaviour
{
    public Transform playerCamera;
    public Transform portal;
    public GameObject generalManager;
    public bool reverse = false;


    private Transform otherPortal;

    private void Start()
    {
        generalManager = GameObject.Find("GameManager");
       // otherPortal = generalManager.GetComponent<GeneralManager>().GetClosestPortalToPlayer();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        otherPortal = generalManager.GetComponent<GeneralManager>().GetClosestPortalToPlayer();
        Vector3 playerOffsetFromPortal = playerCamera.position - otherPortal.position;
        //transform.position = portal.position + playerOffsetFromPortal;
        //===========================
        if (!reverse)
            transform.position = portal.position + (portal.rotation * Quaternion.Inverse(otherPortal.rotation) * playerOffsetFromPortal);
        else
            transform.position = portal.position - (portal.rotation * Quaternion.Inverse(otherPortal.rotation) * playerOffsetFromPortal);
        //===========================

        //float angularDifferenceBetweenPortalRotations = Quaternion.Angle(portal.rotation, otherPortal.rotation);

        //Quaternion portalRotationalDifference = Quaternion.AngleAxis(angularDifferenceBetweenPortalRotations, Vector3.up);

        //Vector3 newCameraDirection = portalRotationalDifference * playerCamera.forward;
        //transform.rotation = Quaternion.LookRotation(newCameraDirection, Vector3.up);

        //===========================
        Vector3 forwardRotation;
        if (!reverse)
            forwardRotation = portal.rotation * Quaternion.Inverse(otherPortal.rotation) * playerCamera.forward;
        else
            forwardRotation = Quaternion.Euler(0f, 180f, 0f) * portal.rotation * Quaternion.Inverse(otherPortal.rotation) * playerCamera.forward;

        Vector3 upRotation = portal.rotation * Quaternion.Inverse(otherPortal.rotation) * playerCamera.up;
        transform.rotation = Quaternion.LookRotation(forwardRotation, upRotation);
        //===========================
    }
}
