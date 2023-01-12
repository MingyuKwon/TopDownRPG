using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    static PlayerStatus instance = null;

    [Header("Basic")]
    public float MaxHP = 100f;
    public float CurrentHP = 50f;
    public float MaxMP = 100f;
    public float CurrentMP = 50f;
    public float MaxEXP = 100f;
    public float CurrentEXP = 50f;

    [Header("Battle")]
    public float PhysicalAttack = 0f;
    public float MagicalAttack = 0f;
    public float PhysicalDefence = 0f;
    public float MagicalDefence = 0f;

    [Header("Equipped")]
    public int Helmet = 1001;
    public int Armor = 2001;
    public int Shoes = 3001;
    public int Weapon = 4001;
    public int Sheild = 5001;

    void Awake() {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }else
        {
            Destroy(this.gameObject);
        }
    }


}
