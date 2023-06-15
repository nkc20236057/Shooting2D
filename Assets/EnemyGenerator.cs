using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPre;//�v���n�u��ۑ�
    float delta;
    float span;
    void Start()
    {
        delta = 0;
        span = 1;
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;

        if (delta > span)
        {
            GameObject go = Instantiate(enemyPre);
            float py = Random.Range(-6f, 7);
            go.transform.position = new Vector3(0, py, 0);

            //�ϐ��N���A
            delta = 0;

            //�Ԋu��Z������
            span -= (span >= 0.5f)?0.01f : 0f;
        }
    }
}
