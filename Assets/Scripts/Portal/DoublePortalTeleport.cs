using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoublePortalTeleport : MonoBehaviour
{
    public DirectionTeleportHelper entranceCollider, exitCollider;
    public Transform player, entranceReceiver, exitReceiver;

    private const int ENTRANCE = 1, EXIT = -1, NONE = 0;

    private bool playerIsOverlapping = false;
    int teleportDirection = 0; // false: from exit, true: from entrance

    // Update is called once per frame
    void FixedUpdate()
    {
        if (playerIsOverlapping && teleportDirection == ENTRANCE)
            Teleport(entranceReceiver);
        if (playerIsOverlapping && teleportDirection == EXIT)
            Teleport(exitReceiver);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerIsOverlapping = true;

            if (entranceCollider.playerIsIntersecting)
                teleportDirection = ENTRANCE;
            else if (exitCollider.playerIsIntersecting)
                teleportDirection = EXIT;
            else
                teleportDirection = NONE;
        }
    }

    private void Teleport(Transform receiver)
    {
        // Vector from portal to player
        Vector3 portalToPlayer = player.position - transform.position;

        float rotationDiff = Quaternion.Angle(transform.rotation, receiver.rotation);
        //player.Rotate(Vector3.up, rotationDiff);

        Vector3 positionOffset = Quaternion.Euler(0f, rotationDiff, 0f) * portalToPlayer;
        player.position = receiver.position + positionOffset;

        playerIsOverlapping = false;
    }
}
