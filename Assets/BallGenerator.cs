using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    [SerializeField] GameObject BrueBall = null;
    [SerializeField, Range(0.1f, 1f)] float m_interval = 0.25f;
    float m_timer;

    void Update()
    {
        m_timer += Time.deltaTime;

        if (m_timer > m_interval)
        {
            m_timer = 0;
            Instantiate(BrueBall, this.gameObject.transform.position, BrueBall.transform.rotation);
        }
    }
}
