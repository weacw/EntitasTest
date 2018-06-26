using UnityEngine;
using System.Collections;

public class InventoryFeature : Feature
{
    public InventoryFeature(Contexts contexts)
    {
        Add(new WeaponInventorySystem(contexts));
    }
}
