using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtalTextureSetup : MonoBehaviour
{
    public Camera[] portalCameras;
    public Camera[] corridorCameras;
    public Camera[] cornerCameras;
    public Camera[] cycleCameras;

    public Material[] portalCameraMats;
    public Material[] corridorCameraMats;
    public Material[] cornerMaterials;
    public Material[] cycleMaterials;

    // Start is called before the first frame update
    void Start()
    {
        // Attach cameras to corresponding Materials
        AttachCamerasToMaterials(portalCameras, portalCameraMats);
        AttachCamerasToMaterials(corridorCameras, corridorCameraMats);
        AttachCamerasToMaterials(cornerCameras, cornerMaterials);
        AttachCamerasToMaterials(cycleCameras, cycleMaterials);
    }

    private void AttachCamerasToMaterials(Camera[] cameras, Material[] materials)
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            if (cameras[i].targetTexture != null)
                cameras[i].targetTexture.Release();

            cameras[i].targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
            materials[i].mainTexture = cameras[i].targetTexture;
        }
    }
}
