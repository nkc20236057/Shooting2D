using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    public Text kyoriLabel;
    int kyori;
    public Image timeGauge;
    public static float lastTime;
    void Start()
    {
        kyori = 0;
        lastTime = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        kyori++;
        kyoriLabel.text = kyori.ToString("D6") + "km";

        //�������Ԃ����炷
        lastTime -= Time.deltaTime;
        timeGauge.fillAmount = lastTime / 100f;

        //�^�C�g����
        if (lastTime < 0)
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
