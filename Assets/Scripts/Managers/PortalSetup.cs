using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSetup : MonoBehaviour
{
    public string portalTag = "Portal";

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] portals = GameObject.FindGameObjectsWithTag(portalTag);
        foreach(GameObject portal in portals)
        {
            if (portal.transform.up != Vector3.up)
                LockPortal(portal);
        }
    }

    void LockPortal(GameObject portal)
    {
        portal.transform.Find("ColliderPlane").GetComponent<BoxCollider>().enabled = false;
    }
}
