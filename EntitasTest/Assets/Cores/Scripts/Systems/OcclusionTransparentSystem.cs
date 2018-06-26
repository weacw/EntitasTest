using UnityEngine;
using System.Collections;
using Entitas;
using System.Collections.Generic;

public class OcclusionTransparentSystem : IExecuteSystem
{
    readonly Contexts contexts;
    GameEntity entity;
    public OcclusionTransparentSystem(Contexts _context, IPhysicsRaycast _physicsRaycast)
    {
        contexts = _context;
        var entities = contexts.game.GetEntities(GameMatcher.Camera);
        foreach (GameEntity entity in entities)
        {
            entity.AddPhysicsRaycast(_physicsRaycast);
        }
    }

    public void Execute()
    {
        var entities = contexts.game.GetEntities(GameMatcher.PhysicsRaycast);
        foreach (GameEntity entity in entities)
        {
            if (entity.physicsRaycast.physicsRaycast!=null)
                entity.physicsRaycast.physicsRaycast.PhysicsRaycast();
        }
    }
}
