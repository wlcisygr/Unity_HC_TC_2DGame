﻿using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("跳躍高度"), Range(50, 1500)]
    public int jump = 100;
    [Header("是否死亡"), Tooltip("判斷角色是否死亡")]
    public bool isDead;

    public GameObject goScore, goGM;

    private void Start()
    {
        goScore.SetActive(true);
        goGM.SetActive(true);
    }

    /// <summary>
    /// 小雞跳躍功能。
    /// </summary>
    private void Jump()
    {

    }

    /// <summary>
    /// 小雞死亡功能。
    /// </summary>
    private void Dead()
    {

    }

    /// <summary>
    /// 通過水管。
    /// </summary>
    private void PassPipe()
    {

    }
}
