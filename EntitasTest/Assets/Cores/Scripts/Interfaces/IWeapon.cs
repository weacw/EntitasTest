using UnityEngine;
using System.Collections;

public interface IWeapon
{
    void Init(Weapon _weapon,Transform _holder);
    void Shot();
    void Reload();
}
