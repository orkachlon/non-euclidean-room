using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShortCorridorDoubleCamera : MonoBehaviour
{
    public Transform playerCamera;
    public Transform corridorEnd;
    public Transform[] corridorOtherEnds;

    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Transform otherEnd;
        Tuple<int, int> playerLocation = player.GetComponent<PlayerMovement>().CurrentRoom();
        if (playerLocation.Item2 == 0)
            otherEnd = corridorOtherEnds[0];
        else
            otherEnd = corridorOtherEnds[1];

        // Vector to get from portal to player
        Vector3 playerOffsetFromPortal = playerCamera.position - otherEnd.position;

        // get position
        transform.position = corridorEnd.position + (/*corridorEnd.rotation * Quaternion.Inverse(corridorOtherEnd.rotation) * */playerOffsetFromPortal);

        // get rotation
        transform.rotation = playerCamera.rotation;
    }
}
