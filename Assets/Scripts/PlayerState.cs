using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    //����һ��������HP��������ʾ��ǰ����ֵ
    //����һ��������MaxHP,���������������ֵ
    public float HP;
    public float MaxHP;

    //�ű���ʼ���еĵ�һִ֡��start
    void Start()
    {
        MaxHP = 100f;
        HP = MaxHP;
    }

    //ÿһ֡ȥִ��
    void Update()
    {
        if (HP<=0)
        {
            Debug.Log("Player is DIE!");
        }
    }




}
