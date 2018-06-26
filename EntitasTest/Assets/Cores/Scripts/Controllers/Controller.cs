using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
public class Controller : MonoBehaviour
{
    Systems systems;
    Contexts m_Context;
    // Use this for initialization
    void Start()
    {
        m_Context = Contexts.sharedInstance;
        systems = new Feature("Operater Systems")
            .Add(new InventoryFeature(m_Context))
            .Add(new CameraFeature(m_Context))
            .Add(new JoystickSystem(m_Context))
            .Add(new PlayerFeatures(m_Context));
        systems.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        systems.Execute();
        systems.Cleanup();
    }
}
