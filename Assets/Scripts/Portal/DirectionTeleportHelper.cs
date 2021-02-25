using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionTeleportHelper : MonoBehaviour
{
    [HideInInspector]public bool playerIsIntersecting = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerIsIntersecting = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            playerIsIntersecting = false;
    }
}
