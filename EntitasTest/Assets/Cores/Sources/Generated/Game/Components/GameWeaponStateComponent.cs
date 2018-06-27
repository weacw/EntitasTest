//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public WeaponStateComponent weaponState { get { return (WeaponStateComponent)GetComponent(GameComponentsLookup.WeaponState); } }
    public bool hasWeaponState { get { return HasComponent(GameComponentsLookup.WeaponState); } }

    public void AddWeaponState(bool newShot, bool newReload) {
        var index = GameComponentsLookup.WeaponState;
        var component = CreateComponent<WeaponStateComponent>(index);
        component.shot = newShot;
        component.reload = newReload;
        AddComponent(index, component);
    }

    public void ReplaceWeaponState(bool newShot, bool newReload) {
        var index = GameComponentsLookup.WeaponState;
        var component = CreateComponent<WeaponStateComponent>(index);
        component.shot = newShot;
        component.reload = newReload;
        ReplaceComponent(index, component);
    }

    public void RemoveWeaponState() {
        RemoveComponent(GameComponentsLookup.WeaponState);
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

    static Entitas.IMatcher<GameEntity> _matcherWeaponState;

    public static Entitas.IMatcher<GameEntity> WeaponState {
        get {
            if (_matcherWeaponState == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.WeaponState);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherWeaponState = matcher;
            }

            return _matcherWeaponState;
        }
    }
}