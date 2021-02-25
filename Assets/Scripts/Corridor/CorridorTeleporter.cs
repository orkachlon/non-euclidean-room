using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorridorTeleporter : MonoBehaviour
{
    public Transform player;
    public Transform receiver;

    private bool playerIsOverlapping = false;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (playerIsOverlapping)
        {
            // Vector from portal to player
            Vector3 portalToPlayer = player.position - transform.position;
            float dotProduct = Vector3.Dot(transform.up, portalToPlayer);

            // If this is true: The player has moved across the portal
            if (dotProduct < 0f)
            {
                //Teleport player

                float rotationDiff = Quaternion.Angle(transform.rotation, receiver.rotation);
                player.Rotate(Vector3.up, rotationDiff);

                Vector3 positionOffset = Quaternion.Euler(0f, rotationDiff, 0f) * portalToPlayer;
                player.position = receiver.position + positionOffset;

                playerIsOverlapping = false;
                print(player.GetComponent<PlayerMovement>().CurrentRoom());
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            playerIsOverlapping = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            playerIsOverlapping = false;

    }
}
