using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIbar : MonoBehaviour
{
    //公开声明两个变量：文本的对象，一个是图片的对象
    public Text T_hp;
    public Image I_hp;
    public GameObject Player;

    private void Update()
    {
        float hp = Player.GetComponent<PlayerState>().HP;
        T_hp.text = "HP:"+ hp; //角色的hp值
        


    }

}
