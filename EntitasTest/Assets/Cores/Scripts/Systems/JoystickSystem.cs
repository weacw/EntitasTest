using Entitas;
using UnityEngine;

public class JoystickSystem : IExecuteSystem
{
    readonly Contexts contexts;
    public JoystickSystem(Contexts _context)
    {
        contexts = _context;
    }

    public void Execute()
    {
        var entities = contexts.game.GetEntities(GameMatcher.JoyStick);
        foreach (GameEntity entity in entities)
        {
            if (entity.joyStickState.joystickStateType == JoystickStateType.OnDrag
                || entity.joyStickState.joystickStateType == JoystickStateType.OnDown)
            {
                Vector2 pos;
                if (RectTransformUtility.ScreenPointToLocalPointInRectangle(entity.joyStickRectTransform.joystickBackground,
                    entity.joyStickPointerData.eventData.position, entity.joyStickPointerData.eventData.pressEventCamera, out pos))
                {
                    pos.x = pos.x / entity.joyStickRectTransform.joystickBackground.sizeDelta.x;
                    pos.y = pos.y / entity.joyStickRectTransform.joystickBackground.sizeDelta.y;

                    entity.joyStickDirection.joystickHandlerDirection = new Vector2(pos.x * 2, pos.y * 2);
                    entity.joyStickDirection.joystickHandlerDirection = entity.joyStickDirection.joystickHandlerDirection.magnitude > 1f ?
                        entity.joyStickDirection.joystickHandlerDirection.normalized : entity.joyStickDirection.joystickHandlerDirection;

                    entity.joyStickRectTransform.joystickHandler.anchoredPosition = new Vector2(
                     entity.joyStickDirection.joystickHandlerDirection.x * (entity.joyStickRectTransform.joystickBackground.sizeDelta.x / 2),
                    entity.joyStickDirection.joystickHandlerDirection.y * (entity.joyStickRectTransform.joystickBackground.sizeDelta.y / 2));
                }
            }
            else
            {
                entity.joyStickRectTransform.joystickHandler.anchoredPosition = Vector2.zero;
                entity.joyStickDirection.joystickHandlerDirection = Vector2.zero;
            }

        }
    }
}
