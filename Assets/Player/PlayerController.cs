using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float speed = 5;
        Vector3 dir = Vector3.zero;

        //�㉺�ړ�
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");
        transform.position += dir.normalized * speed * Time.deltaTime;
    
        Vector2 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -9f, 9f);
        pos.y = Mathf.Clamp(pos.y, -5f, 5f);
        transform.position = pos;

    //  �A�j���[�V�����ݒ�
    if(dir.y == 0)
        {
            //�A�j���[�V�����N���b�v(Player)���Đ�
            anim.Play("Player");
        }
    else if(dir.y == 1)
        {
            anim.Play("PlayerL");
        }
    else if(dir.y == -1)
        {
            anim.Play("PlayerR");
        }


    }
}
