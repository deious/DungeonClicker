﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMove : MonoBehaviour
{
    // 부딪힌 다음 튕겨나오는 것을 구현해야함
    void Update()
    {
        GetComponent<Rigidbody2D>().AddForce(transform.right *-10f);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground"){ return; }
        else
        {
            //col.gameObject.transform.Find("Canvas").Find("Health Slider").GetComponent<HpControl>().GainDamage(30);
            GetComponent<Rigidbody2D>().AddForce(transform.right * 300f);
        }
    }
}