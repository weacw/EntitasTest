//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity weaponInventoryEntity { get { return GetGroup(GameMatcher.WeaponInventory).GetSingleEntity(); } }
    public WeaponInventoryComponent weaponInventory { get { return weaponInventoryEntity.weaponInventory; } }
    public bool hasWeaponInventory { get { return weaponInventoryEntity != null; } }

    public GameEntity SetWeaponInventory(WeaponInventory newWeaponInventory) {
        if (hasWeaponInventory) {
            throw new Entitas.EntitasException("Could not set WeaponInventory!\n" + this + " already has an entity with WeaponInventoryComponent!",
                "You should check if the context already has a weaponInventoryEntity before setting it or use context.ReplaceWeaponInventory().");
        }
        var entity = CreateEntity();
        entity.AddWeaponInventory(newWeaponInventory);
        return entity;
    }

    public void ReplaceWeaponInventory(WeaponInventory newWeaponInventory) {
        var entity = weaponInventoryEntity;
        if (entity == null) {
            entity = SetWeaponInventory(newWeaponInventory);
        } else {
            entity.ReplaceWeaponInventory(newWeaponInventory);
        }
    }

    public void RemoveWeaponInventory() {
        weaponInventoryEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public WeaponInventoryComponent weaponInventory { get { return (WeaponInventoryComponent)GetComponent(GameComponentsLookup.WeaponInventory); } }
    public bool hasWeaponInventory { get { return HasComponent(GameComponentsLookup.WeaponInventory); } }

    public void AddWeaponInventory(WeaponInventory newWeaponInventory) {
        var index = GameComponentsLookup.WeaponInventory;
        var component = CreateComponent<WeaponInventoryComponent>(index);
        component.weaponInventory = newWeaponInventory;
        AddComponent(index, component);
    }

    public void ReplaceWeaponInventory(WeaponInventory newWeaponInventory) {
        var index = GameComponentsLookup.WeaponInventory;
        var component = CreateComponent<WeaponInventoryComponent>(index);
        component.weaponInventory = newWeaponInventory;
        ReplaceComponent(index, component);
    }

    public void RemoveWeaponInventory() {
        RemoveComponent(GameComponentsLookup.WeaponInventory);
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

    static Entitas.IMatcher<GameEntity> _matcherWeaponInventory;

    public static Entitas.IMatcher<GameEntity> WeaponInventory {
        get {
            if (_matcherWeaponInventory == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.WeaponInventory);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherWeaponInventory = matcher;
            }

            return _matcherWeaponInventory;
        }
    }
}
