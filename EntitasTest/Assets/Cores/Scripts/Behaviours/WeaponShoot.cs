using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Entitas;
public class WeaponShoot : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    Contexts contexts;
    GameEntity[] entities;
    bool pressing = false;
    public void Start()
    {
        contexts = Contexts.sharedInstance;
        entities = contexts.game.GetEntities(GameMatcher.Weapon);
    }
    public void Update()
    {
        if (pressing)
            Shootting(true);
    }

    private void Shootting(bool _state)
    {
        foreach (GameEntity item in entities)
        {
            item.ReplaceWeaponState(_state, false);
        }
    }

    public void Reload()
    {
        foreach (GameEntity item in entities)
        {
            item.ReplaceWeaponState(false, true);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        pressing = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pressing = false;
        Shootting(false);
    }
}
