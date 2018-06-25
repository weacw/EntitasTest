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
        //float tmp_DT = Time.deltaTime;

        var entities = contexts.game.GetEntities(GameMatcher.JoyStick);
        foreach (GameEntity entity in entities)
        {
            if (entity.joyStickState.joystickStateType != JoystickStateType.OnDrag)
            {
                entity.playerUnity.rigidbody.drag = 8;
                return;
            }
            entity.playerUnity.rigidbody.drag = 0;
            Vector3 tmp_Move = entity.playerUnity.transform.forward * entity.playerProperties.moveSpeed;
            entity.playerUnity.rigidbody.velocity = tmp_Move;
        }
    }
}
