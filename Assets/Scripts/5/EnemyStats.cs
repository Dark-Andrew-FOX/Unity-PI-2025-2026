using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "enemyStats", menuName = "Game Data/Enemy Stats")]
public class EnemyStats : ScriptableObject
{
    private float maxHealth;
    private float maxDamage;
    private string enemyName;

    public float MaxHealth { get => maxHealth; }
    public float MaxDamage { get => maxDamage; }
    public string EnemyName { get => enemyName; }
}
