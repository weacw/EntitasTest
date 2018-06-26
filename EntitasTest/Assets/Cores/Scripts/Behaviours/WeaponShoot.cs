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
            foreach (GameEntity item in entities)
            {
                item.weapon.shot = true;
            }
    }

    public void Reload()
    {
        foreach (GameEntity item in entities)
        {
            item.weapon.reload = true;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        pressing = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pressing = false;
    }
}
