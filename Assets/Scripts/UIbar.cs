using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIbar : MonoBehaviour
{
    //�������������������ı��Ķ���һ����ͼƬ�Ķ���
    public Text T_hp;
    public Image I_hp;
    public GameObject Player;

    private void Update()
    {
        float hp = Player.GetComponent<PlayerState>().HP;
        T_hp.text = "HP:"+ hp; //��ɫ��hpֵ
        


    }

}
