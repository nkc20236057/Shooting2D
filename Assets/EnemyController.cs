using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Vector3 dir = Vector3.zero; //����
    float speed = 5;          �@//���x

    void Start()
    {
      //���΂S�b
      Destroy(gameObject,4f);
    }

    // Update is called once per frame
    void Update()
    {
          //�ړ������̌���
        dir = Vector3.left;

        //���ݒn�Ɉړ��ʂ����Z
        transform.position += dir.normalized * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameDirector.lastTime -= 10f;
        Destroy (gameObject);//�d�Ȃ��ď���
    }
}
