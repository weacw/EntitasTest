//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public PlayerPropertiesComponent playerProperties { get { return (PlayerPropertiesComponent)GetComponent(GameComponentsLookup.PlayerProperties); } }
    public bool hasPlayerProperties { get { return HasComponent(GameComponentsLookup.PlayerProperties); } }

    public void AddPlayerProperties(float newMoveSpeed, float newRotSpeed, float newGravity, UnityEngine.LayerMask newIgnoreGroundCheckLayer, PlayerState newPlayerState) {
        var index = GameComponentsLookup.PlayerProperties;
        var component = CreateComponent<PlayerPropertiesComponent>(index);
        component.moveSpeed = newMoveSpeed;
        component.rotSpeed = newRotSpeed;
        component.gravity = newGravity;
        component.ignoreGroundCheckLayer = newIgnoreGroundCheckLayer;
        component.playerState = newPlayerState;
        AddComponent(index, component);
    }

    public void ReplacePlayerProperties(float newMoveSpeed, float newRotSpeed, float newGravity, UnityEngine.LayerMask newIgnoreGroundCheckLayer, PlayerState newPlayerState) {
        var index = GameComponentsLookup.PlayerProperties;
        var component = CreateComponent<PlayerPropertiesComponent>(index);
        component.moveSpeed = newMoveSpeed;
        component.rotSpeed = newRotSpeed;
        component.gravity = newGravity;
        component.ignoreGroundCheckLayer = newIgnoreGroundCheckLayer;
        component.playerState = newPlayerState;
        ReplaceComponent(index, component);
    }

    public void RemovePlayerProperties() {
        RemoveComponent(GameComponentsLookup.PlayerProperties);
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

    static Entitas.IMatcher<GameEntity> _matcherPlayerProperties;

    public static Entitas.IMatcher<GameEntity> PlayerProperties {
        get {
            if (_matcherPlayerProperties == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PlayerProperties);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPlayerProperties = matcher;
            }

            return _matcherPlayerProperties;
        }
    }
}
