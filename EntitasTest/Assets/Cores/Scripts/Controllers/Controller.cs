using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
public class Controller : MonoBehaviour
{
    Systems systems;
    Contexts contexts;
    // Use this for initialization
    void Start()
    {
        contexts = Contexts.sharedInstance;
        systems = new Feature("Camera System").Add(new CameraFeature(contexts));
    }

    // Update is called once per frame
    void Update()
    {
        systems.Execute();
        systems.Cleanup();
    }
}
