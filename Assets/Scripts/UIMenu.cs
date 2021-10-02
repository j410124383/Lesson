using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIMenu : MonoBehaviour
{
    //定义方法 开始游戏
    public void StartGame()
    {
        SceneManager.LoadScene("MainWorld");
        Debug.Log("已执行：开始游戏");
    }

    //定义方法 退出游戏
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("已执行：退出游戏");
    }



}
