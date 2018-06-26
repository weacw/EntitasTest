using UnityEngine;
using System.Collections;
using Entitas;
using System.Collections.Generic;

public class WeaponSystem : IInitializeSystem, IExecuteSystem
{
    readonly Contexts contexts;
    public WeaponSystem(Contexts _context)
    {
        contexts = _context;
    }

    public void Execute()
    {
        var entities = contexts.game.GetEntities(GameMatcher.Weapon);
        foreach (GameEntity entity in entities)
        {
            if (entity.weapon.shot)
            {
                entity.weapon.weapon.Shot();
                entity.weapon.shot = false;
            }

            if (entity.weapon.reload)
            {
                entity.weapon.weapon.Reload();
                entity.weapon.reload = false;
            }
        }
    }

    public void Initialize()
    {
        var weaponInventoryEntity = contexts.game.GetEntities(GameMatcher.WeaponInventory).SingleEntity<GameEntity>();
        var entities = contexts.game.GetEntities(GameMatcher.Weapon);
        foreach (GameEntity entity in entities)
        {
            Transform tmp_RightHand = entity.playerUnity.animator.GetBoneTransform(HumanBodyBones.RightHand);
            int id = weaponInventoryEntity.weaponInventory.weaponInventory.GetWeaponForId("M4");
            entity.weapon.weapon.Init(weaponInventoryEntity.weaponInventory.weaponInventory.m_Weapons[id], tmp_RightHand);

        }
    }
}
