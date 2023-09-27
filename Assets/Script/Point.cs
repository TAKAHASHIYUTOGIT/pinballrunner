using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    [SerializeField] Text _scoreText;
    public static int _score = 0; 
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Rball")
        {
            _score += 1;
            _scoreText.text = "スコア:" +  _score.ToString("D2");//D2は01と表示してくれる
        }
        if(collision.gameObject.tag == "Bball")
        {
            _score += 3;
            _scoreText.text = "スコア:" + _score.ToString("D2");
        }
        if (collision.gameObject.tag == "Wball")
        {
            _score += 5;
            _scoreText.text = "スコア:" + _score.ToString("D2");
        }
    }
}
