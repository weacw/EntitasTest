using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine.EventSystems;
using UnityEngine;

public enum JoystickStateType
{
    None,
    OnDrag,
    OnUp,
    OnDown
};

public enum PlayerState
{
    None,
    OnGround,
    OnAir
};


[Game]
public class JoyStickComponent : IComponent { }

[Game]
public class JoyStickPointerDataComponent : IComponent
{
    public PointerEventData eventData;
}
[Game]
public class JoyStickStateComponent : IComponent
{
    public JoystickStateType joystickStateType;
}
[Game]
public class JoyStickRectTransformComponent : IComponent
{
    public RectTransform joystickBackground;
    public RectTransform joystickHandler;
}

[Game]
public class JoyStickDirectionComponent : IComponent
{
    public Vector2 joystickHandlerDirection;
}

[Game]
public class PlayerComponent : IComponent
{
    public GameObject character;
}
[Game]
public class MovementComponent : IComponent
{
    public Vector2 moveDirection;
}
[Game]
public class PlayerPropertiesComponent : IComponent
{
    public float moveSpeed;
    public float rotSpeed;
    public float gravity = 20f;
    public LayerMask ignoreGroundCheckLayer;
    public PlayerState playerState;
}

[Game]
public class PlayerUnityComponent : IComponent
{
    public CapsuleCollider capsuleCollider;
    public Rigidbody rigidbody;
    public Animator animator;
    public Transform transform;
}

[Game]
public class CameraTransComponent : IComponent
{
    public Transform cameraTransform;
    public Transform targetTransform;
}

[Game]
public class CameraPropertiesComponent : IComponent
{
    public float followSpeed;
    public float depth;
    public float height;
}
[Game]
public class CameraComponent : IComponent { }

[Game]
public class PhysicsRaycastComponent : IComponent
{
    IPhysicsRaycast physicsRaycast;
}