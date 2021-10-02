using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    //声明一个变量，HP，用来显示当前体力值
    //声明一个变量，MaxHP,用来定义最大体力值
    public float HP;
    public float MaxHP;

    //脚本开始运行的第一帧执行start
    void Start()
    {
        MaxHP = 100f;
        HP = MaxHP;
    }

    //每一帧去执行
    void Update()
    {
        if (HP<=0)
        {
            Debug.Log("Player is DIE!");
        }
    }




}
