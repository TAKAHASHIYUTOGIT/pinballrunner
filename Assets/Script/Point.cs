using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    [SerializeField] GameObject _redBall = null;
    [SerializeField] GameObject _blueBall = null;
    [SerializeField] GameObject _whiteBall = null;
    float Score = 0; 
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Rball")
        {
            Score += 1;
        }
        if(collision.gameObject.tag == "Bball")
        {
            Score += 3;
        }
        if (collision.gameObject.tag == "Wball")
        {
            Score += 5;
        }
    }
}
