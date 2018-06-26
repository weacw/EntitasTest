using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "Weapon/WeaponInventory")]
public class WeaponInventory : ScriptableObject
{
    public List<Weapon> m_Weapons = new List<Weapon>();
    public Dictionary<string, int> m_WeaponDict = new Dictionary<string, int>();

    public void Init()
    {
        for (int i = 0; i < m_Weapons.Count; i++)
        {
            if (m_WeaponDict.ContainsKey(m_Weapons[i].weaponId)) continue;
            m_WeaponDict.Add(m_Weapons[i].weaponId, i);
        }
        Debug.Log("Init runtime inventory");
    }

    public int GetWeaponForId(string _id)
    {
        int tmp_WeaponId = -1;
        m_WeaponDict.TryGetValue(_id, out tmp_WeaponId);
        return tmp_WeaponId;
    }
}