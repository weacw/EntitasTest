using System.Collections.Generic;
using Entitas;
using UnityEngine;
public class MovementSystem : IExecuteSystem
{
    readonly Contexts contexts;
    GameEntity entity;

    public MovementSystem(Contexts _context)
    {
        contexts = _context;
    }

    public void Execute()
    {
        var entities = contexts.game.GetEntities(GameMatcher.JoyStick);
        foreach (GameEntity entity in entities)
        {
            Vector3 tmp_Move = entity.playerUnity.transform.forward * entity.playerProperties.moveSpeed * entity.joyStickDirection.joystickHandlerDirection.magnitude;
            entity.playerUnity.characterController.SimpleMove(tmp_Move);
        }
    }
}
