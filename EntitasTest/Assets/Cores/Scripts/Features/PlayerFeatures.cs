using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
public class PlayerFeatures : Feature
{
    public PlayerFeatures(Contexts _context)
    {
        //Add(new GravitySystem(_context));
        Add(new MovementSystem(_context));
        Add(new RotateSystem(_context));
        Add(new AnimatorSystem(_context));
        Add(new WeaponSystem(_context));
    }
}
