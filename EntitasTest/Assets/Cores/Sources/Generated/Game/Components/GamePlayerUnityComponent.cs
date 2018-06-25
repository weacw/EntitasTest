//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public PlayerUnityComponent playerUnity { get { return (PlayerUnityComponent)GetComponent(GameComponentsLookup.PlayerUnity); } }
    public bool hasPlayerUnity { get { return HasComponent(GameComponentsLookup.PlayerUnity); } }

    public void AddPlayerUnity(UnityEngine.CapsuleCollider newCapsuleCollider, UnityEngine.Rigidbody newRigidbody, UnityEngine.Animator newAnimator, UnityEngine.Transform newTransform) {
        var index = GameComponentsLookup.PlayerUnity;
        var component = CreateComponent<PlayerUnityComponent>(index);
        component.capsuleCollider = newCapsuleCollider;
        component.rigidbody = newRigidbody;
        component.animator = newAnimator;
        component.transform = newTransform;
        AddComponent(index, component);
    }

    public void ReplacePlayerUnity(UnityEngine.CapsuleCollider newCapsuleCollider, UnityEngine.Rigidbody newRigidbody, UnityEngine.Animator newAnimator, UnityEngine.Transform newTransform) {
        var index = GameComponentsLookup.PlayerUnity;
        var component = CreateComponent<PlayerUnityComponent>(index);
        component.capsuleCollider = newCapsuleCollider;
        component.rigidbody = newRigidbody;
        component.animator = newAnimator;
        component.transform = newTransform;
        ReplaceComponent(index, component);
    }

    public void RemovePlayerUnity() {
        RemoveComponent(GameComponentsLookup.PlayerUnity);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherPlayerUnity;

    public static Entitas.IMatcher<GameEntity> PlayerUnity {
        get {
            if (_matcherPlayerUnity == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PlayerUnity);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPlayerUnity = matcher;
            }

            return _matcherPlayerUnity;
        }
    }
}
