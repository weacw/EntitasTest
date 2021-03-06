//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public JoyStickDirectionComponent joyStickDirection { get { return (JoyStickDirectionComponent)GetComponent(GameComponentsLookup.JoyStickDirection); } }
    public bool hasJoyStickDirection { get { return HasComponent(GameComponentsLookup.JoyStickDirection); } }

    public void AddJoyStickDirection(UnityEngine.Vector2 newJoystickHandlerDirection) {
        var index = GameComponentsLookup.JoyStickDirection;
        var component = CreateComponent<JoyStickDirectionComponent>(index);
        component.joystickHandlerDirection = newJoystickHandlerDirection;
        AddComponent(index, component);
    }

    public void ReplaceJoyStickDirection(UnityEngine.Vector2 newJoystickHandlerDirection) {
        var index = GameComponentsLookup.JoyStickDirection;
        var component = CreateComponent<JoyStickDirectionComponent>(index);
        component.joystickHandlerDirection = newJoystickHandlerDirection;
        ReplaceComponent(index, component);
    }

    public void RemoveJoyStickDirection() {
        RemoveComponent(GameComponentsLookup.JoyStickDirection);
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

    static Entitas.IMatcher<GameEntity> _matcherJoyStickDirection;

    public static Entitas.IMatcher<GameEntity> JoyStickDirection {
        get {
            if (_matcherJoyStickDirection == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.JoyStickDirection);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherJoyStickDirection = matcher;
            }

            return _matcherJoyStickDirection;
        }
    }
}
