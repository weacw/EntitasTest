using UnityEngine;
using System.Collections;

public class RifleWeapon : IWeapon
{
    private float lastShot;
    private WeaponHook weaponHook;

    public void Init(Weapon _weapon, Transform _holder)
    {
        GameObject tmp_weaponGO = Object.Instantiate(_weapon.prefab);
        weaponHook = tmp_weaponGO.GetComponent<WeaponHook>();
        tmp_weaponGO.transform.SetParent(_holder);
        tmp_weaponGO.transform.localPosition = Vector3.zero;
        tmp_weaponGO.transform.localRotation = Quaternion.identity;
    }

    public void Reload()
    {
        weaponHook.m_Properties.curAmmunition = weaponHook.m_Properties.maxAmmunition;
    }

    public void Shot()
    {
        if (weaponHook == null) return;
        if (weaponHook.m_Properties.curAmmunition <= 0) return;
        if (Time.time > weaponHook.m_Properties.fireRate + lastShot)
        {
            GameObject go = Object.Instantiate(weaponHook.m_Projectile, weaponHook.m_Muzzle.transform.position, weaponHook.m_Muzzle.transform.rotation);            
            go.GetComponent<Rigidbody>().AddForce(weaponHook.m_Muzzle.transform.forward * 150, ForceMode.Impulse);
            weaponHook.m_Properties.curAmmunition--;
            weaponHook.m_Muzzle.Play(true);
            weaponHook.m_Shell.Emit(1);
            weaponHook.m_AudioSource.Play();
            lastShot = Time.time;
        }
    }
}
