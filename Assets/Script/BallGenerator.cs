using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    [SerializeField] GameObject _redBall = null;
    [SerializeField] GameObject _blueBall = null;
    [SerializeField] GameObject _whiteBall = null;
    [SerializeField] float r_interval = 1f;
    [SerializeField] float b_interval = 3f;
    [SerializeField] float w_interval = 7f;
    [SerializeField] Transform rangeA;
    [SerializeField] Transform rangeB;
    float r_timer;
    float b_timer;
    float w_timer;

    void Update()
    {
        //それぞれのボールが出るタイマー
        r_timer += Time.deltaTime;
        b_timer += Time.deltaTime;
        w_timer += Time.deltaTime;

        if (r_timer > r_interval)//赤ボールの設定
        {
            float x = Random.Range(rangeA.position.x, rangeB.position.x);
            float y = Random.Range(rangeA.position.y, rangeB.position.y);
            //ボールが出る範囲設定
            r_timer = 0;
            Instantiate(_redBall, new Vector2(x, y), _redBall.transform.rotation);
        }
        if (b_timer > b_interval)//青ボールの設定
        {
            float x = Random.Range(rangeA.position.x, rangeB.position.x);
            float y = Random.Range(rangeA.position.y, rangeB.position.y);
            b_timer = 0;
            Instantiate(_blueBall, new Vector2(x,y), _blueBall.transform.rotation);
        }
        if (w_timer > w_interval)//白ボールの設定
        {
            float x = Random.Range(rangeA.position.x, rangeB.position.x);
            float y = Random.Range(rangeA.position.y, rangeB.position.y);
            w_timer = 0;
            Instantiate(_whiteBall, new Vector2(x, y), _whiteBall.transform.rotation);
        }
    }
}
