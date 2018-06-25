using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class RotateSystem : IExecuteSystem
{
    readonly Contexts contexts;
    public RotateSystem(Contexts _contexts)
    {
        contexts = _contexts;
    }

    public void Execute()
    {
        var entities = contexts.game.GetEntities(GameMatcher.JoyStick);
        foreach (GameEntity entity in entities)
        {
            if(entity.joyStickState.joystickStateType != JoystickStateType.OnDrag)return;
            if (entity.joyStickDirection.joystickHandlerDirection == Vector2.zero) return;
            float angle = Mathf.Atan2(entity.joyStickDirection.joystickHandlerDirection.x, entity.joyStickDirection.joystickHandlerDirection.y) * Mathf.Rad2Deg;
            entity.player.character.transform.rotation = Quaternion.Euler(angle * Vector3.up);
        }
    }
}
