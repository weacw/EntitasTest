using UnityEngine;
using System.Collections;
using Entitas;
using System.Collections.Generic;

public class OcclusionTransparentSystem :IInitializeSystem, IExecuteSystem
{
    readonly Contexts contexts;
    readonly IPhysicsRaycast physicsRaycast;
    GameEntity entity;
    public OcclusionTransparentSystem(Contexts _context, IPhysicsRaycast _physicsRaycast)
    {
        contexts = _context;
        physicsRaycast = _physicsRaycast;
    }

    public void Execute()
    {
        if (physicsRaycast != null)
            physicsRaycast.PhysicsRaycast();
    }

    public void Initialize()
    {
        entity = contexts.game.CreateEntity();
        entity.isPhysicsRaycast = true;
    }
}
