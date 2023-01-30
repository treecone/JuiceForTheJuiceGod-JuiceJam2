using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS_PlayerAttributes : MonoBehaviour
{
    [Header("Player Stats")]
    public int juicefulness;
    public int durability;

    public float speed;
    public float vision;

    [Space]
    [Header("Combat")]

    public int cupDamage;
    public float damageRadiusSquared;
    public float absorbtionRadius;
    public float absorbtionSpeed;
    public float hammerRecoverySpeed;
    public float hammerFallSpeed;
    public float invincibilityTime;
    public bool invincibility;

}