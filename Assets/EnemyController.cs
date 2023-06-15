using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Vector3 dir = Vector3.zero; //•ûŒü
    float speed = 5;          @//‘¬“x

    void Start()
    {
      //“”‰Î‚S•b
      Destroy(gameObject,4f);
    }

    // Update is called once per frame
    void Update()
    {
          //ˆÚ“®•ûŒü‚ÌŒˆ’è
        dir = Vector3.left;

        //Œ»İ’n‚ÉˆÚ“®—Ê‚ğ‰ÁZ
        transform.position += dir.normalized * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameDirector.lastTime -= 10f;
        Destroy (gameObject);//d‚È‚Á‚ÄÁ‹
    }
}
