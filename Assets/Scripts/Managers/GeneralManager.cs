using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GeneralManager : MonoBehaviour
{
    const int ROOMS = 3;
    public GameObject player;
    public GameObject[] rooms = new GameObject[ROOMS];
    public GameObject[] portals = new GameObject[ROOMS];

    // Update is called once per frame
    void Update()
    {
        // Get Quit input
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();

        Tuple<int, int> playerCurrentLocation = player.GetComponent<PlayerMovement>().CurrentRoom();
        // Hide objects in other rooms
        for (int room = 0; room < ROOMS; room++)
        {
            if (playerCurrentLocation.Item1 == room)
                HidObjectsInOtherRooms(room);
        }
    }

    private void HidObjectsInOtherRooms(int room)
    {
        // Show objects in current room
        foreach (Transform child in rooms[room].transform.Find("Demonstration").transform)
        {
            if (child.tag == "ToHide")
                child.gameObject.SetActive(true);
        }

        // Hide objects in other rooms
        for (int otherRooms = 0; otherRooms < ROOMS; otherRooms++)
        {
            if (otherRooms != room)
                foreach (Transform child in rooms[otherRooms].transform.Find("Demonstration").transform)
                {
                    if (child.tag == "ToHide")
                        child.gameObject.SetActive(false);
                }
        }
    }

    public Transform GetClosestPortalToPlayer()
    {
        float xValue = player.transform.position.x;
        float zValue = player.transform.position.z;

        if (Mathf.Abs(xValue) < 15)
            return portals[0].transform;
        else if (-15 + 32 < xValue && xValue < 15 + 32)
            return portals[1].transform;
        return portals[2].transform;
    }
}
