﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    public float hp;

    public void GainDamage(float damage)
    {
        hp -= damage;

        if (hp <= 0)
        {
            Destroy(gameObject.transform.root.gameObject);
        }
    }
}
