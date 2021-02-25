using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disabler : MonoBehaviour
{
    public static bool teleportDisabled = false;

    public Transform teleporter;
    //private CapsuleCollider playerBody;
    private Vector3 returnLocation;

    private void Start()
    {
        //playerBody = GameObject.FindGameObjectWithTag("PlayerBody").GetComponent<CapsuleCollider>();
        returnLocation = transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            teleportDisabled = true;
            transform.position = 0.5f * (transform.position + teleporter.position);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            teleportDisabled = false;
            transform.position = returnLocation;
        }
    }
}
