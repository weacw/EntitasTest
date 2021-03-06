//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public JoyStickStateComponent joyStickState { get { return (JoyStickStateComponent)GetComponent(GameComponentsLookup.JoyStickState); } }
    public bool hasJoyStickState { get { return HasComponent(GameComponentsLookup.JoyStickState); } }

    public void AddJoyStickState(JoystickStateType newJoystickStateType) {
        var index = GameComponentsLookup.JoyStickState;
        var component = CreateComponent<JoyStickStateComponent>(index);
        component.joystickStateType = newJoystickStateType;
        AddComponent(index, component);
    }

    public void ReplaceJoyStickState(JoystickStateType newJoystickStateType) {
        var index = GameComponentsLookup.JoyStickState;
        var component = CreateComponent<JoyStickStateComponent>(index);
        component.joystickStateType = newJoystickStateType;
        ReplaceComponent(index, component);
    }

    public void RemoveJoyStickState() {
        RemoveComponent(GameComponentsLookup.JoyStickState);
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

    static Entitas.IMatcher<GameEntity> _matcherJoyStickState;

    public static Entitas.IMatcher<GameEntity> JoyStickState {
        get {
            if (_matcherJoyStickState == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.JoyStickState);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherJoyStickState = matcher;
            }

            return _matcherJoyStickState;
        }
    }
}
