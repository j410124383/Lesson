using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIMenu : MonoBehaviour
{
    //���巽�� ��ʼ��Ϸ
    public void StartGame()
    {
        SceneManager.LoadScene("MainWorld");
        Debug.Log("��ִ�У���ʼ��Ϸ");
    }

    //���巽�� �˳���Ϸ
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("��ִ�У��˳���Ϸ");
    }



}
