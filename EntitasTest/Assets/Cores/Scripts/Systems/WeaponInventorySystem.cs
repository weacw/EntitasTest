using UnityEngine;
using System.Collections;
using Entitas;
public class WeaponInventorySystem : IInitializeSystem
{
    private WeaponInventory weaponInventory;
    readonly Contexts contexts;
    public WeaponInventorySystem(Contexts _contexts)
    {
        contexts = _contexts;
    }

    public void Initialize()
    {
        weaponInventory = Resources.Load<WeaponInventory>("WeaponInventory");
        var entity = contexts.game.CreateEntity();
        entity.AddWeaponInventory(weaponInventory);
        weaponInventory.Init();
    }
}
