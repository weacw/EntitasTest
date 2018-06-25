using UnityEngine;
using System.Collections;
using Entitas;
public class CameraFeature : Feature
{
    public CameraFeature(Contexts _context)
    {
        Add(new TopdownCameraSystem(_context));
        Add(new OcclusionTransparentSystem(_context, new TransparentService(Camera.main.transform, GameObject.FindGameObjectWithTag("Player").transform)));
    }

}
