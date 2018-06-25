//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public JoyStickPointerDataComponent joyStickPointerData { get { return (JoyStickPointerDataComponent)GetComponent(GameComponentsLookup.JoyStickPointerData); } }
    public bool hasJoyStickPointerData { get { return HasComponent(GameComponentsLookup.JoyStickPointerData); } }

    public void AddJoyStickPointerData(UnityEngine.EventSystems.PointerEventData newEventData) {
        var index = GameComponentsLookup.JoyStickPointerData;
        var component = CreateComponent<JoyStickPointerDataComponent>(index);
        component.eventData = newEventData;
        AddComponent(index, component);
    }

    public void ReplaceJoyStickPointerData(UnityEngine.EventSystems.PointerEventData newEventData) {
        var index = GameComponentsLookup.JoyStickPointerData;
        var component = CreateComponent<JoyStickPointerDataComponent>(index);
        component.eventData = newEventData;
        ReplaceComponent(index, component);
    }

    public void RemoveJoyStickPointerData() {
        RemoveComponent(GameComponentsLookup.JoyStickPointerData);
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

    static Entitas.IMatcher<GameEntity> _matcherJoyStickPointerData;

    public static Entitas.IMatcher<GameEntity> JoyStickPointerData {
        get {
            if (_matcherJoyStickPointerData == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.JoyStickPointerData);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherJoyStickPointerData = matcher;
            }

            return _matcherJoyStickPointerData;
        }
    }
}
