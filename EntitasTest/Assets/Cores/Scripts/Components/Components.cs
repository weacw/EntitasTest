using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine.EventSystems;
using UnityEngine;

#region Joystick Components
public enum JoystickStateType
{
    None,
    OnDrag,
    OnUp,
    OnDown
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

#endregion


#region Player Components
public enum PlayerState
{
    None,
    OnGround,
    OnAir
};

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
    public CharacterController characterController;
    public Animator animator;
    public Transform transform;
}

#endregion


#region Camera Components

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

#endregion


#region Physics Components
[Game]
public class PhysicsRaycastComponent : IComponent
{
    public IPhysicsRaycast physicsRaycast;
}
#endregion


#region Weapon Components
[Game]
public class WeaponComponent : IComponent
{
    public IWeapon weapon;
}
[Game]
public class WeaponStateComponent : IComponent
{
    public bool shot;
    public bool reload;
}

[Game]
public class WeaponSlotsComponent : IComponent
{
    public string mainWeaponId;
    public string secondWeaponId;
}

[Game, Unique]
public class WeaponInventoryComponent : IComponent
{
    public WeaponInventory weaponInventory;
}



[System.Serializable]
public class WeaponProperties
{
    public int curAmmunition = 30;
    public int maxAmmunition = 30;
    public int carryAmmunition = 120;
    public float fireRate = 0.086f;
    public float bulletSpeed;
    public float injure;
}
[System.Serializable]
public class Weapon
{
    public string weaponId;
    public GameObject prefab;
}
#endregion