using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPre;//プレハブを保存
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

            //変数クリア
            delta = 0;

            //間隔を短くする
            span -= (span >= 0.5f)?0.01f : 0f;
        }
    }
}
