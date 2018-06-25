using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class AnimatorSystem : ReactiveSystem<GameEntity>
{
    public AnimatorSystem(Contexts _contexts) : base(_contexts.game)
    {
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (GameEntity entity in entities)
        {
            entity.playerUnity.animator.SetFloat("MovementAmount", entity.joyStickDirection.joystickHandlerDirection.magnitude);
        }
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasPlayerUnity;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.AnyOf(GameMatcher.JoyStickState, GameMatcher.PlayerUnity, GameMatcher.JoyStickDirection));
    }
}
