using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class Move : MonoBehaviour
{
    public bool isground ;  //用来判断，当前角色是否在地面上，如果在地面上，则为真；反之为假
    public float speed=0.05f; //用来表示这个速度的常量
    public float jump=300f; //用来表示这个弹跳力的常量

    void Start()
    {

    }


    //update 方法 每一帧都执行一次
    void Update()
    {

        //当玩家按下左键，角色，向左移动
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Time.deltaTime当前帧数频率，也可以指代时间的系数
            this.gameObject.transform.Translate(Vector2.left* speed*Time.deltaTime);
            GetComponent<SpriteRenderer>().flipX = true; //获取当前对象身上的spriterenderer组件，并且让其中的flipx为真
        }

        //当玩家按下右键，角色向右移动
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.gameObject.transform.Translate(Vector2.right * speed * Time.deltaTime);
            GetComponent<SpriteRenderer>().flipX = false; //获取当前对象身上的spriterenderer组件，并且让其中的flipx为假
        }

        //当玩家按下空白键，角色跳跃
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            if (isground==true)
            {
                this.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jump * Time.deltaTime);
            }
        }
    }

    //当这个脚本所挂载的对象，与其他对象相碰撞时
    void OnCollisionStay2D(Collision2D collider)
    {
        isground = true;//我们让isground为真
       
    }

    //当这个脚本所挂载的对象，未与其他对象相碰撞；
    void OnCollisionExit2D(Collision2D collider)
    {
        isground = false;//我们让isground为假
    }

}
