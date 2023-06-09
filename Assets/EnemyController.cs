using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Vector3 dir = Vector3.zero; //方向
    float speed = 5;          　//速度

    void Start()
    {
      //灯火４秒
      Destroy(gameObject,4f);
    }

    // Update is called once per frame
    void Update()
    {
          //移動方向の決定
        dir = Vector3.left;

        //現在地に移動量を加算
        transform.position += dir.normalized * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameDirector.lastTime -= 10f;
        Destroy (gameObject);//重なって消去
    }
}
