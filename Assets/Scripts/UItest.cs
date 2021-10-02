using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UItest : MonoBehaviour
{
    //public 公开，前面有public的变量，方法，是可以其他的脚本被调用的
    //private 私有，也就是不公开

    public string name01 = "张苏杭";
    private string name02 = "老王";

    //方法 void +方法名+（参数（通常情况可以省略））
    //定义一个方法
    //
    public void PrintName()
    {
        print(name01);

    }


}
