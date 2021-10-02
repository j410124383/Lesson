using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class Move : MonoBehaviour
{
    public bool isground ;  //�����жϣ���ǰ��ɫ�Ƿ��ڵ����ϣ�����ڵ����ϣ���Ϊ�棻��֮Ϊ��
    public float speed=0.05f; //������ʾ����ٶȵĳ���
    public float jump=300f; //������ʾ����������ĳ���

    void Start()
    {

    }


    //update ���� ÿһ֡��ִ��һ��
    void Update()
    {

        //����Ұ����������ɫ�������ƶ�
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Time.deltaTime��ǰ֡��Ƶ�ʣ�Ҳ����ָ��ʱ���ϵ��
            this.gameObject.transform.Translate(Vector2.left* speed*Time.deltaTime);
            GetComponent<SpriteRenderer>().flipX = true; //��ȡ��ǰ�������ϵ�spriterenderer��������������е�flipxΪ��
        }

        //����Ұ����Ҽ�����ɫ�����ƶ�
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.gameObject.transform.Translate(Vector2.right * speed * Time.deltaTime);
            GetComponent<SpriteRenderer>().flipX = false; //��ȡ��ǰ�������ϵ�spriterenderer��������������е�flipxΪ��
        }

        //����Ұ��¿հ׼�����ɫ��Ծ
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            if (isground==true)
            {
                this.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jump * Time.deltaTime);
            }
        }
    }

    //������ű������صĶ�����������������ײʱ
    void OnCollisionStay2D(Collision2D collider)
    {
        isground = true;//������isgroundΪ��
       
    }

    //������ű������صĶ���δ��������������ײ��
    void OnCollisionExit2D(Collision2D collider)
    {
        isground = false;//������isgroundΪ��
    }

}
