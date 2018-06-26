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
            if (entity.weaponState.shot)
            {
                entity.weapon.weapon.Shot();
                entity.weaponState.shot = false;
            }

            if (entity.weaponState.reload)
            {
                entity.weapon.weapon.Reload();
                entity.weaponState.reload = false;
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
            string tmp_WeaponId = entity.weaponSlots.mainWeaponId;
            int id = weaponInventoryEntity.weaponInventory.weaponInventory.GetWeaponForId(tmp_WeaponId);
            entity.weapon.weapon.Init(weaponInventoryEntity.weaponInventory.weaponInventory.m_Weapons[id], tmp_RightHand);

        }
    }
}
